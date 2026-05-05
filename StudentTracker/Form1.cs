using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class Form1 : Form
    {
        // Основная бд для приложения
        string connectionString = DatabaseInitializer.getConnectionString();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        // Метод загрузка данных из базы данных
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //string sql = @"SELECT Id, SurName AS [Фамилия], Name AS [Имя], LastName AS [Отчество] FROM Students";
                    string sql = @"SELECT S.Id,
S.SurName AS [Фамилия],
S.Name AS [Имя],
S.LastName AS [Отчество],
Groups.Name AS [Группа],
AVG(CAST(Grades.Grade AS FLOAT)) AS [Ср.Балл]
FROM Students AS S
JOIN Groups ON S.IdGroup = Groups.Id
LEFT JOIN Grades ON Grades.IdStudent = S.Id
GROUP BY S.Id, S.SurName, S.Name, S.LastName, Groups.Name";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvStudents.DataSource = dt;
                    dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvStudents.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Id"].Value);
            string studentName = dgvStudents.CurrentRow.Cells["Фамилия"].Value.ToString() + " " +
                dgvStudents.CurrentRow.Cells["Имя"].Value.ToString();
            var confirm = MessageBox.Show($"Удалить студента {studentName}?", 
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Students WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Id", studentId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadData();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void студентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addForm = new AddGroupForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
