using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class AddStudentForm : Form
    {
        public event Action OnStudentAdd;
        private string connectionString = DatabaseInitializer.getConnectionString();

        public AddStudentForm()
        {
            InitializeComponent();
            LoadGroups();
            this.AcceptButton = btnAddStudent;
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

                GroupInput_SelectedIndexChanged(null, null);
            }
        }

        private void GroupInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupInput.SelectedIndex == null ||
                !int.TryParse(GroupInput.SelectedValue.ToString(), out int id)) return;

            int idSpec = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    id = (int)GroupInput.SelectedValue;

                    string sqlSpec = "SELECT IdSpecialty FROM Groups WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sqlSpec, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        idSpec = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string sqlSpecName = "SELECT Name FROM Specialties WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sqlSpecName, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idSpec);
                        textBoxSpecialtiesAddStudentForm.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных о группах: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            bool result = DataBaseManager.AddStudent(
                SurNameInput.Text.Trim(),
                NameInput.Text.Trim(),
                LastNameInput.Text.Trim(),
                BirthDateInput.Text.Trim(),
                PhoneInput.Text.Trim(),
                EmailInput.Text.Trim(),
                (int)GroupInput.SelectedValue
                );

            if (result)
            {
                MessageBox.Show("Студент добавлен!");
                OnStudentAdd?.Invoke();

                SurNameInput.Clear();
                NameInput.Clear();
                LastNameInput.Clear();
                BirthDateInput.Clear();
                PhoneInput.Clear();
                EmailInput.Clear();
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
            
            if (string.IsNullOrWhiteSpace(BirthDateInput.Text))
            {
                errorProvider.SetError(BirthDateInput, "Введите дату рождения!");
                result = false;
            }
            
            if (string.IsNullOrWhiteSpace(PhoneInput.Text))
            {
                errorProvider.SetError(PhoneInput, "Введите телефон!");
                result = false;
            }
            
            if (string.IsNullOrWhiteSpace(PhoneInput.Text))
            {
                errorProvider.SetError(PhoneInput, "Введите телефон!");
                result = false;
            }
            
            if (string.IsNullOrWhiteSpace(EmailInput.Text))
            {
                errorProvider.SetError(EmailInput, "Введите почту!");
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
