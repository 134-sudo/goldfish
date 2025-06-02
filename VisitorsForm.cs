using Npgsql;

namespace goldfish
{

    public partial class VisitorsForm : Form
    {
        NpgsqlCommand cmd;
        NpgsqlDataReader reader;
        public VisitorsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            using (var command = new NpgsqlCommand("select * from клубы;", MainForm.conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clubs.Items.Add(reader[1].ToString());
                    }
                }
            }

            LoadData();
        }

        void LoadData()
        {
            visitorsList.Controls.Clear();

            string query = $"select " +
                        $"фамилия," +
                        $"имя," +
                        $"отчество," +
                        $"(date(now()) - дата_рождения)/365 возраст," +
                        $"клубы.название as клуб, " +
                        $"max(дата_заезда) последняя_дата_заезда," +
                        $"sum(количество_дней) колво_посещений," +
                        $"sum(get_fish_price(форель, 'форель', дата_заезда) + " +
                        $"get_fish_price(толстолобик, 'толстолобик', дата_заезда) + " +
                        $"get_fish_price(карп, 'карп', дата_заезда) + " +
                        $"get_fish_price(карась, 'карась', дата_заезда)) сумма " +
                        $"from посещения join клиенты on клиенты.ин = клиент join клубы on клубы.ин = клуб";
            if (toggleFilters.Checked == true)
            {
                query += $" where дата_заезда = '{date.Value.ToString("yyyy-MM-dd")}'";
                if (clubs.Text != "")
                    query += $" and клубы.название = '{clubs.Text}'";
            }
            query += " group by фамилия, имя, отчество, возраст, клубы.название, клиенты order by клиенты";
            cmd = new NpgsqlCommand(query, MainForm.conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Location = new Point(3, 3);
                panel.Name = "panel";
                panel.Size = new Size(500, 140);
                panel.TabIndex = 1;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(2);

                CreateLabel(panel, new Point(10, 10), "ФИО: " + reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                CreateLabel(panel, new Point(10, 25), "Возраст: " + reader[3].ToString());
                CreateLabel(panel, new Point(10, 40), "Клуб: " + reader[4].ToString());
                CreateLabel(panel, new Point(10, 55), "Дата последнего заезда: " + reader[5].ToString());
                CreateLabel(panel, new Point(10, 70), "Кол-во посещений: " + reader[6].ToString());
                CreateLabel(panel, new Point(10, 85), "Общая сумма: " + reader[7].ToString());
                string sale = "Скидка ";
                string sumText = reader[7].ToString();
                decimal count = string.IsNullOrEmpty(sumText) ? 0 : decimal.Parse(sumText);
                if (count > 10000)
                    sale += "15%";
                else if (count > 7000)
                    sale += "10%";
                else if (count > 5000)
                    sale += "5%";
                else
                    sale += "0%";
                CreateLabel(panel, new Point(200, 85), sale);

                visitorsList.Controls.Add(panel);
            }
            cmd.Dispose();
            cmd.Cancel();
            reader.Close();
        }

        private void CreateLabel(Panel parent, Point pos, string text, string? name = "label")
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = pos;
            label.Name = name;
            label.Size = new Size(80, 15);
            label.TabIndex = 11;
            label.Text = text;
            parent.Controls.Add(label);
        }



        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clubs_TextChanged(object sender, EventArgs e)
        {
            if (toggleFilters.Checked == true) { LoadData(); }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (toggleFilters.Checked == true) { LoadData(); }
        }

        private void toggleFilters_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
