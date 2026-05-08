using System;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class LoginForm : Form
    {
        private string connectionString = DatabaseInitializer.getConnectionString();
        public LoginForm()
        {
            InitializeComponent();
            PasswordInput.UseSystemPasswordChar = true;
            this.AcceptButton = btn_Authorization;
        }

        private void btn_Authorization_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            string enterPassword = SecurityHelper.HashPassword(PasswordInput.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Role FROM Users WHERE Login = @login AND Password = @password";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@login", LoginInput.Text);
                    command.Parameters.AddWithValue("@password", enterPassword);

                    object role = command.ExecuteScalar();
                    if (role != null)
                    {
                        MessageBox.Show($"Добро пожаловать, {role}");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                }
            }
        }

        private bool IsValid()
        {
            bool result = true;
            errorProviderLogin.Clear();

            if (string.IsNullOrWhiteSpace(LoginInput.Text))
            {
                errorProviderLogin.SetError(LoginInput, "Введите логин!");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                errorProviderLogin.SetError(PasswordInput, "Введите пароль!");
                result = false;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = !PasswordInput.UseSystemPasswordChar;
        }
    }
}
