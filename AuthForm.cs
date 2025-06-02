using Npgsql;
using System;
using System.Windows.Forms;

namespace goldfish
{
    public partial class AuthForm : Form
    {
        NpgsqlConnection connection;
        NpgsqlCommand command;
        public static bool authSuccessful = false;

        public AuthForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;

            try
            {
                connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=goldfish;Username=postgres;Password=1111;");
                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            string username = loginInput.Text.Trim();
            string password = passInput.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                if (UserExists(username, password))
                {
                    connection?.Close();
                    MessageBox.Show($"Добро пожаловать, {username}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    authSuccessful = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Допущена ошибка в данных пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private bool UserExists(string username, string password)
        {
            try
            {
                command = new NpgsqlCommand("SELECT count(*) FROM сотрудники WHERE логин = @Username AND пароль = @Password", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            finally
            {
                command?.Dispose();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            connection?.Close();
            connection?.Dispose();
            base.OnFormClosing(e);
        }
    }
}