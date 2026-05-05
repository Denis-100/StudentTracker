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

namespace StudentTracker
{
    public partial class AddStudentForm : Form
    {
        private string connectionString = DatabaseInitializer.getConnectionString();

        public AddStudentForm()
        {
            InitializeComponent();
            LoadGroups();
        }

        private void LoadGroups()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Name FROM Groups";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                GroupInput.DataSource = dt;
                GroupInput.DisplayMember = "Name";
                GroupInput.ValueMember = "Id";
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Students (SurName, Name, LastName, IdGroup)" +
                        "VALUES (@SurName, @Name, @LastName, @IdGroup)";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@SurName", SurNameInput.Text.Trim());
                        command.Parameters.AddWithValue("@Name", NameInput.Text.Trim());
                        command.Parameters.AddWithValue("@LastName", LastNameInput.Text.Trim());
                        command.Parameters.AddWithValue("@IdGroup", GroupInput.SelectedValue);

                        command.ExecuteNonQuery();
                    }

                }
                LoadGroups();
                MessageBox.Show("Студент успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private bool IsValid()
        {
            bool result = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(SurNameInput.Text))
            {
                errorProvider.SetError(SurNameInput, "Введите фамилию!");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(NameInput.Text))
            {
                errorProvider.SetError(NameInput, "Введите имя!");
                result = false;
            }

            if (GroupInput.SelectedValue == null)
            {
                errorProvider.SetError(GroupInput, "Выберитер группу!");
                result = false;
            }

            return result;
        }
    }
}
