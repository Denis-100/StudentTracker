using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using StudentTracker.Forms;
using StudentTracker.Forms.Grade;
using StudentTracker.Forms.Profiles;
using StudentTracker.Forms.Subject;
using StudentTracker.Services;

namespace StudentTracker
{
    public partial class Form1 : Form
    {
        private string thisTable = "Grades";
        private DataTable thisDataTable = DataBaseManager.GetAllGrades();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            AccessLevel();
        }


        // Метод загрузка данных из базы данных
        private void LoadData(DataTable dataTable = null)
        {
            try
            {
                if (dataTable != null) dgvMain.DataSource = dataTable;
                else dgvMain.DataSource = thisDataTable;

                SetDefaultDGVSettings.Default(dgvMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void AccessLevel()
        {
            string role = LoginForm.currentRole;
            if (role.Equals("Admin")) { }
            else
            {
                // Вкладка таблица
                toolStripSettings.Visible = false;
                table_users.Visible = false;

                // Вкладка добавить
                add_specialties.Visible = false;
                add_group.Visible = false;
                add_teacher.Visible = false;
                add_student.Visible = false;
                add_subject.Visible = false;
                add_grade_type.Visible = false;

                // Вкладка удалить
                del_specialties.Visible = false;
                del_group.Visible = false;
                del_teacher.Visible = false;
                del_student.Visible = false;
                del_subject.Visible = false;
                del_grade_type.Visible = false;

                if (role.Equals("Student"))
                {
                    table_teachers.Visible = false;
                    table_groups.Visible = false;
                    table_students.Visible = false;

                    table_avg_grade.Visible = true;

                    toolStripAdd.Visible = false;
                    toolStripDel.Visible = false;
                }
            }
        }

        private void RefreshActiveTable()
        {
            switch (thisTable)
            {
                case "Users":
                    thisDataTable = DataBaseManager.GetAllUsers();
                    break;
                case "Teachers":
                    thisDataTable = DataBaseManager.GetAllTeachers();
                    break;
                case "Specialties":
                    thisDataTable = DataBaseManager.GetAllSpecialties();
                    break;
                case "Groups":
                    thisDataTable = DataBaseManager.GetAllGroups();
                    break;
                case "Students":
                    thisDataTable = DataBaseManager.GetAllStudents();
                    break;
                case "Subjects":
                    thisDataTable = DataBaseManager.GetAllSubjects();
                    break;
                case "Grades":
                    thisDataTable = DataBaseManager.GetAllGrades();
                    break;
                case "GradeTypes":
                    thisDataTable = DataBaseManager.GetAllGradeTypes();
                    break;
                default:
                    return;
            }

            LoadData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshActiveTable();
        }


        // --- Раздел Добавить ---
        // Добавить Направление
        private void направлениеХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpecialitiesForm addForm = new AddSpecialitiesForm();
            addForm.OnAddSpecialties += () => RefreshActiveTable();
            addForm.ShowDialog();
        }
        // Добавить Группу
        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addForm = new AddGroupForm();
            addForm.OnGroupAdd += () => RefreshActiveTable();
            addForm.ShowDialog();
        }

        // Учителя
        private void учителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherForm addForm = new AddTeacherForm();
            addForm.OnAddTeacher += () => RefreshActiveTable();
            addForm.ShowDialog();
        }

        // Добавить Студента
        private void студентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.OnStudentAdd += () => RefreshActiveTable();
            addForm.ShowDialog();
        }

        // Добавить Предмет
        private void предметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubjectsForm addForm = new AddSubjectsForm();
            addForm.OnAddSubjects += () => RefreshActiveTable();
            addForm.ShowDialog();
        }

        // Добавить Оценку
        private void оценкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGradeForm addForm = new AddGradeForm();
            addForm.OnAddGrade += () => RefreshActiveTable();
            addForm.ShowDialog();
        }

        // Добавить Тип оценки
        private void типОценкиХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGradeTypesForm addForm = new AddGradeTypesForm();
            addForm.OnAddGradeTypes += () => RefreshActiveTable();
            addForm.ShowDialog();
        }

        // --- Раздел Добавить ---
        //
        // --- Раздел Удалить ---

        // Удалить Направление
        private void направлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelSpecialtiesForm delSpecialtiesForm = new DelSpecialtiesForm();
            delSpecialtiesForm.OnDelSpecilties += () => RefreshActiveTable();
            delSpecialtiesForm.ShowDialog();
        }

        // Удалить Группу
        private void группуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelGroupForm delForm = new DelGroupForm();
            delForm.OnGroupDel += () => RefreshActiveTable();
            delForm.ShowDialog();
        }

        // Удалить Учителя
        private void учителяХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelTeacherForm delForm = new DelTeacherForm();
            delForm.OnDelTeacher += () => RefreshActiveTable();
            delForm.ShowDialog();
        }

        // Удалить Студента
        private void студентаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelStudentForm delForm = new DelStudentForm();
            delForm.OnDelStudent += () => RefreshActiveTable();
            delForm.ShowDialog();
        }

        // Удалить Предмет
        private void предметХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelSubjectsForm delForm = new DelSubjectsForm();
            delForm.OnDelSubjects += () => RefreshActiveTable();
            delForm.ShowDialog();
        }

        // Удалить Оценку
        private void оценкуХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelGradeForm delGrade = new DelGradeForm();
            delGrade.OnDelGrade += () => RefreshActiveTable();
            delGrade.ShowDialog();
        }

        // Удалить Тип оценки
        private void типОценкиХToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DelGradeTypesForm delForm = new DelGradeTypesForm();
            delForm.OnDelGradeTypes += () => RefreshActiveTable();
            delForm.ShowDialog();
        }

        // --- Раздел Удалить ---
        //
        // --- Раздел Таблица ---

        // Таблица Пользователей
        private void пользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "Users";
            thisDataTable = DataBaseManager.GetAllUsers();
            LoadData(DataBaseManager.GetAllUsers());
        }

        // Таблица Учителей
        private void учителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "Teachers";
            thisDataTable = DataBaseManager.GetAllTeachers();
            LoadData(DataBaseManager.GetAllTeachers());
        }

        // Таблица Направлений
        private void направленийХToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            thisTable = "Specialties";
            thisDataTable = DataBaseManager.GetAllSpecialties();
            LoadData(DataBaseManager.GetAllSpecialties());
        }

        // Таблица Групп
        private void группToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "Groups";
            thisDataTable = DataBaseManager.GetAllGroups();
            LoadData(DataBaseManager.GetAllGroups());
        }

        // Таблица Студентов
        private void студентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "Students";
            thisDataTable = DataBaseManager.GetAllStudents();
            LoadData(DataBaseManager.GetAllStudents());
        }

        // Таблица Предметов
        private void предметовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "Subjects";
            thisDataTable = DataBaseManager.GetAllSubjects();
            LoadData(DataBaseManager.GetAllSubjects());
        }

        // Таблица Оценок
        private void оценокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "Grades";
            thisDataTable = DataBaseManager.GetAllGrades();
            LoadData(DataBaseManager.GetAllGrades());
        }

        // Таблица Типов оценок
        private void типовОценокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisTable = "GradeTypes";
            thisDataTable = DataBaseManager.GetAllGradeTypes();
            LoadData(DataBaseManager.GetAllGradeTypes());
        }

        // --- Раздел Таблица ---



        private void назначитьПредметыУчителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSubjectTeacher setSubject = new SetSubjectTeacher();
            setSubject.ShowDialog();
        }

        private void btnProfilOpen_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void table_avg_grade_Click(object sender, EventArgs e)
        {
            AvgGradeForm avgForm = new AvgGradeForm();
            avgForm.ShowDialog();
        }
    }
}
