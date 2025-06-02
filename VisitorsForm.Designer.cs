namespace goldfish
{
    partial class VisitorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorsForm));
            visitorsList = new FlowLayoutPanel();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            back = new Button();
            clubs = new ComboBox();
            date = new DateTimePicker();
            toggleFilters = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // visitorsList
            // 
            visitorsList.AutoScroll = true;
            visitorsList.BackColor = Color.White;
            visitorsList.Font = new Font("Times New Roman", 10.2F);
            visitorsList.Location = new Point(12, 12);
            visitorsList.Name = "visitorsList";
            visitorsList.Size = new Size(547, 288);
            visitorsList.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(2, 46, 77);
            back.Font = new Font("Times New Roman", 10.2F);
            back.ForeColor = Color.White;
            back.Location = new Point(565, 309);
            back.Name = "back";
            back.Size = new Size(125, 30);
            back.TabIndex = 7;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // clubs
            // 
            clubs.FormattingEnabled = true;
            clubs.Location = new Point(565, 80);
            clubs.Name = "clubs";
            clubs.Size = new Size(125, 27);
            clubs.TabIndex = 8;
            clubs.TextChanged += clubs_TextChanged;
            // 
            // date
            // 
            date.Location = new Point(12, 314);
            date.Name = "date";
            date.Size = new Size(200, 27);
            date.TabIndex = 9;
            date.ValueChanged += date_ValueChanged;
            // 
            // toggleFilters
            // 
            toggleFilters.AutoSize = true;
            toggleFilters.Location = new Point(218, 314);
            toggleFilters.Name = "toggleFilters";
            toggleFilters.Size = new Size(93, 23);
            toggleFilters.TabIndex = 10;
            toggleFilters.Text = "Фильтры";
            toggleFilters.UseVisualStyleBackColor = true;
            toggleFilters.CheckedChanged += toggleFilters_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(565, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // VisitorsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 343);
            Controls.Add(pictureBox1);
            Controls.Add(toggleFilters);
            Controls.Add(date);
            Controls.Add(clubs);
            Controls.Add(back);
            Controls.Add(visitorsList);
            Font = new Font("Times New Roman", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VisitorsForm";
            Text = "Посетители";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel visitorsList;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button back;
        private ComboBox clubs;
        private DateTimePicker date;
        private CheckBox toggleFilters;
        private PictureBox pictureBox1;
    }
}