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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            IdLabel.Text = LoginForm.currentId.ToString();
            RoleLabel.Text = LoginForm.currentRole.ToString();

            if (LoginForm.currentRole.Equals("Admin"))
            {
                FIOLabel.Text = "Администратор";
                LoginLabel.Text = "admin";
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseInitializer.getConnectionString()))
                    {
                        conn.Open();
                        string sql;

                        if (LoginForm.currentRole.Equals("Teacher"))
                        {
                            sql = @"SELECT t.SurName + ' ' + t.Name + ' ' + t.LastName AS FIO, u.Login 
                                    FROM Teachers t 
                                    JOIN Users u ON t.Id = u.IdTeacher 
                                    WHERE t.Id = @Id";
                        }
                        else
                        {
                            sql = @"SELECT s.SurName + ' ' + s.Name + ' ' + s.LastName AS FIO, u.Login 
                                    FROM Students s 
                                    JOIN Users u ON s.Id = u.IdStudent 
                                    WHERE s.Id = @Id";
                        }

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", LoginForm.currentId);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    FIOLabel.Text = reader["FIO"].ToString();
                                    LoginLabel.Text = reader["Login"].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке ФИО и логина: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            CheckThisPassword check = new CheckThisPassword();
            check.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
