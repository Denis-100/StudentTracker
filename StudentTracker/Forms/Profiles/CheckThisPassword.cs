using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker.Forms.Profiles
{
    public partial class CheckThisPassword : Form
    {
        public CheckThisPassword()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProviderCheckPassword.Clear();
            if (string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                errorProviderCheckPassword.SetError(PasswordInput, "Введите пароль!");
                return;
            }

            try
            {
                string sql;
                string password;

                if (LoginForm.currentRole.Equals("Teacher"))
                {
                    sql = "SELECT Password FROM Users WHERE IdTeacher = @Id";
                }
                else if (LoginForm.currentRole.Equals("Student"))
                {
                    sql = "SELECT Password FROM Users WHERE IdStudent = @Id";
                }
                else
                {
                    sql = "SELECT Password FROM Users WHERE Role = 'Admin'";
                }
                using (SqlConnection conn = new SqlConnection(DatabaseInitializer.getConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", LoginForm.currentId);
                        password = cmd.ExecuteScalar().ToString();
                    }

                    if (SecurityHelper.HashPassword(PasswordInput.Text) == password)
                    {
                        ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                        changePasswordForm.ShowDialog();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки пароля: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = !PasswordInput.UseSystemPasswordChar;
        }
    }
}
