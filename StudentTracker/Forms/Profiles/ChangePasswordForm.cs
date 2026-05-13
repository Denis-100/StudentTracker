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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            this.AcceptButton = btnSave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProviderChangePassword.Clear();
            
            if (string.IsNullOrWhiteSpace(PasswordInput1.Text))
            {
                errorProviderChangePassword.SetError(PasswordInput1, "Введите новый пароль!");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(PasswordInput2.Text))
            {
                errorProviderChangePassword.SetError(PasswordInput2, "Подтвердите новый пароль!");
                return;
            }

            string pass1 = PasswordInput1.Text.Trim();
            string pass2 = PasswordInput2.Text.Trim();

            if (!pass1.Equals(pass2))
            {
                MessageBox.Show("Ошибка, пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseInitializer.getConnectionString()))
                {
                    conn.Open();

                    string role = LoginForm.currentRole;
                    int id = LoginForm.currentId;
                    string sql;

                    long newSalt = SecurityHelper.GenerateRandomSalt();
                    string newPassword = SecurityHelper.HashPassword(pass2, newSalt);

                    if (role.Equals("Admin"))
                    {
                        sql = @"UPDATE Users
                                SET Password = @Password, 
                                Salt = @Salt
                                WHERE Role = 'Admin'";
                    }
                    else if (role.Equals("Teacher"))
                    {
                        sql = @"UPDATE Users
                                SET Password = @Password, 
                                Salt = @Salt
                                WHERE IdTeacher = @Id";
                    }
                    else
                    {
                        sql = @"UPDATE Users
                                SET Password = @Password, 
                                Salt = @Salt
                                WHERE IdStudent = @Id";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Salt", newSalt);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно поменяли пароль!");
                        this.DialogResult = DialogResult.OK;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при смене пароля: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            PasswordInput1.UseSystemPasswordChar = !PasswordInput1.UseSystemPasswordChar;
            PasswordInput2.UseSystemPasswordChar = !PasswordInput2.UseSystemPasswordChar;
        }
    }
}
