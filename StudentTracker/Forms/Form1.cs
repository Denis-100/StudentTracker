using System;
using System.Data;
using System.Windows.Forms;
using StudentTracker.Forms;

namespace StudentTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        // Метод загрузка данных из базы данных
        private void LoadData(DataTable dataTable = null)
        {
            try
            {
                // Загрузка данных в таблицу в форме
                if (dataTable != null) dgvMain.DataSource = dataTable;
                else dgvMain.DataSource = DataBaseManager.GetAllStudents();

                // Авто подбор ширины слобцов
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                // Режим только для чтения
                dgvMain.ReadOnly = true;
                // Убирает нижнюю пустую строку
                dgvMain.AllowUserToAddRows = false;
                // Выделяет всю строку сразу при нажатии на ячейку
                dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                // Запрет на изменение размеров строк и столбцов
                dgvMain.AllowUserToResizeColumns = false;
                dgvMain.AllowUserToResizeRows = false;
                // Запрет на изменение высоты заголовков
                dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        // --- Раздел Добавить ---
        // Добавить Направление
        private void направлениеХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpecialitiesForm addForm = new AddSpecialitiesForm();
            addForm.ShowDialog();
        }
        // Добавить Группу
        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addForm = new AddGroupForm();
            addForm.OnGroupAdd += () => LoadData();
            addForm.ShowDialog();
        }
        // Добавить Студента
        private void студентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.OnStudentAdd += () => LoadData();
            addForm.ShowDialog();
        }

        // --- Раздел Добавить ---
        //
        // --- Раздел Удалить ---

        // Удалить Направление
        private void направлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelSpecialtiesForm delSpecialtiesForm = new DelSpecialtiesForm();
            delSpecialtiesForm.OnDelSpecilties += () => LoadData();
            delSpecialtiesForm.ShowDialog();
        }

        // Удалить Группу
        private void группуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelGroupForm delForm = new DelGroupForm();
            delForm.OnGroupDel += () => LoadData();
            delForm.ShowDialog();
        }

        // Удалить Студента
        private void студентаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelStudentForm delForm = new DelStudentForm();
            delForm.OnDelStudent += () => LoadData();
            delForm.Show();
        }

        // --- Раздел Удалить ---
        //
        // --- Раздел Таблица ---

        // Таблица Направлений
        private void направленийХToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllSpecialties());
        }

        // Таблица Групп
        private void группToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllGroups());
        }

        // Таблица Студентов
        private void студентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllStudents());
        }

        // Таблица Пользователей
        private void пользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllUsers());
        }

        // Таблица Учителей
        private void учителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllTeachers());
        }

        // Таблица Предметов
        private void предметовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllSubjects());
        }

        // Таблица Оценок
        private void оценокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllGrades());
        }

        // Таблица Типов оценок
        private void типовОценокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(DataBaseManager.GetAllGradeTypes());
        }

        // --- Раздел Таблица ---
    }
}
