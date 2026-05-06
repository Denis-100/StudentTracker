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
            try
            {
                // Загрузка данных в таблицу в форме
                dgvStudents.DataSource = DataBaseManager.GetAllStudents();
                // Авто подбор ширины слобцов
                dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                // Режим только для чтения
                dgvStudents.ReadOnly = true;
                // Убирает нижнюю пустую строку
                dgvStudents.AllowUserToAddRows = false;
                // Выделяет всю строку сразу при нажатии на ячейку
                dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            bool result = DataBaseManager.DelStudent(dgvStudents);

            if (result)
            {
                LoadData();
            }
        }



        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void студентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.OnStudentAdd += () => LoadData();
            addForm.ShowDialog();
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addForm = new AddGroupForm();
            addForm.OnGroupChange += () => LoadData();
            addForm.ShowDialog();
        }

        private void направлениеХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpecialitiesForm addForm = new AddSpecialitiesForm();
            addForm.ShowDialog();
        }

        private void направлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelSpecialtiesForm delSpecialtiesForm = new DelSpecialtiesForm();
            delSpecialtiesForm.OnDelSpecilties += () => LoadData();
            delSpecialtiesForm.ShowDialog();
        }
    }
}
