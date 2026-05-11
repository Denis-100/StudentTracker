using StudentTracker.Forms.Profiles;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class LoginForm : Form
    {
        public static string currentRole = "";
        public static int currentId = -1;

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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int id;
                    string sql = "SELECT Role, IdTeacher, IdStudent FROM Users WHERE Login = @login AND Password = @password";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@login", LoginInput.Text);
                        command.Parameters.AddWithValue("@password", enterPassword);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                currentRole = role;

                                if (role.Equals("Teacher")) currentId = Convert.ToInt32(reader["IdTeacher"]);
                                else if (role.Equals("Student")) currentId = Convert.ToInt32(reader["IdStudent"]);
                                else
                                {
                                    checkPassAdmin();
                                    currentId = -1;
                                }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при авторизации: {ex.Message}",
            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void checkPassAdmin()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Password FROM Users WHERE Role = 'Admin'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                string pas = cmd.ExecuteScalar().ToString();
                if (pas.Equals(SecurityHelper.HashPassword("admin")))
                {
                    MessageBox.Show("Администратор, смените пароль для безопасности!");
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                    changePasswordForm.ShowDialog();
                }
            }
        }
    }
}
