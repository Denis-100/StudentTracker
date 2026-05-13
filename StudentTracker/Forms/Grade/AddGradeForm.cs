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

namespace StudentTracker.Forms.Grade
{
    public partial class AddGradeForm : Form
    {
        private string connectionString = DatabaseInitializer.getConnectionString();
        public event Action OnAddGrade;

        public AddGradeForm()
        {
            InitializeComponent();
            LoadGroups();
            LoadAcademYear();
            LoadTeacher();
            LoadSubjects();
            LoadGrade();
            LoadGradeType();
            this.AcceptButton = btnAddGrade;
        }

        private void LoadGroups()
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных о группах: {ex.Message}\nПроверьте, создана ли хоть 1 группа.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GroupInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupInput.SelectedIndex == null ||
                !int.TryParse(GroupInput.SelectedValue.ToString(), out int idGroup)) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT Id, SurName + ' ' + Name + ' ' + LastName AS FIO FROM Students " +
                        "WHERE IdGroup = @IdGroup";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdGroup", GroupInput.SelectedValue);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            StudentInput.DataSource = dt;
                            StudentInput.DisplayMember = "FIO";
                            StudentInput.ValueMember = "Id";

                            if (dt.Rows.Count == 0)
                            {
                                errorProviderAddGrade.SetError(StudentInput, "Добавьте студентов!");
                            }
                            else
                            {
                                errorProviderAddGrade.SetError(StudentInput, "");
                            }
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных о студентах: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadAcademYear()
        {
            int currentYear = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            int startYear = (month >= 9) ? currentYear : currentYear - 1;

            AcademYearInput.Items.Add($"{startYear - 1}/{startYear}");
            AcademYearInput.Items.Add($"{startYear}/{startYear + 1}");
            AcademYearInput.Items.Add($"{startYear + 1}/{startYear + 2}");
            AcademYearInput.SelectedIndex = 1;
        }

        private void LoadSubjects()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql;

                    if (LoginForm.currentRole.Equals("Admin"))
                    {
                        if (TeacherInput.SelectedValue == null || TeacherInput.SelectedValue is DataRowView)
                            return;

                        //sql = "SELECT Id, Name FROM Subjects";
                        sql = $"SELECT s.Id, s.Name FROM Subjects s " +
                        $"JOIN TeacherSubjects ts ON s.Id = ts.IdSubject " +
                        $"WHERE ts.IdTeacher = {Convert.ToInt32(TeacherInput.SelectedValue)}";
                    }
                    else
                    {
                        sql = $"SELECT s.Id, s.Name FROM Subjects s " +
                        $"JOIN TeacherSubjects ts ON s.Id = ts.IdSubject " +
                        $"WHERE ts.IdTeacher = {LoginForm.currentId}";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        SubjectInput.DataSource = dt;
                        SubjectInput.DisplayMember = "Name";
                        SubjectInput.ValueMember = "Id";

                        if (dt.Rows.Count == 0)
                        {
                            errorProviderAddGrade.SetError(SubjectInput, "Добавьте предметы!");
                        }
                        else
                        {
                            errorProviderAddGrade.SetError(SubjectInput, "");
                        }
                    }
                    
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных о предметах: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadGrade()
        {
            for (int i = 5; i >= 2; i--)
            {
                GradeInput.Items.Add(i);
            }
        }

        private void LoadGradeType()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT Id, Name FROM GradeTypes";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        GradeTypeInput.DataSource = dt;
                        GradeTypeInput.DisplayMember = "Name";
                        GradeTypeInput.ValueMember = "Id";

                        if (dt.Rows.Count == 0)
                        {
                            errorProviderAddGrade.SetError(GradeTypeInput, "Добавьте типы оценок!");
                        }
                        else
                        {
                            errorProviderAddGrade.SetError(GradeTypeInput, "");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных о типах оценок: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadTeacher()
        {
            if (LoginForm.currentRole.Equals("Admin"))
            {
                TeacherInput.DataSource = DataBaseManager.GetAllTeachers();
                TeacherInput.DisplayMember = "ФИО";
                TeacherInput.ValueMember = "Id";
            }
            else
            {
                TeacherText.Visible = false;
                TeacherInput.Visible = false;
            }
        }

        private void TeacherInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            errorProviderAddGrade.Clear();

            // Проверка выбран ли студент
            if (StudentInput.SelectedValue == null || StudentInput.SelectedValue is DataRowView)
            {
                MessageBox.Show("Невозможно добавить оценку, так как в группе нет студентов!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProviderAddGrade.SetError(StudentInput, "Добавьте студентов!");
                return;
            }

            if (GradeInput.SelectedItem == null)
            {
                errorProviderAddGrade.SetError(GradeInput, "Выберите оценку!");
                return;
            }

            try
            {
                int idStudent = Convert.ToInt32(StudentInput.SelectedValue);
                int idSubject = Convert.ToInt32(SubjectInput.SelectedValue);
                int idGradeType = Convert.ToInt32(GradeTypeInput.SelectedValue);
                int idTeacher;
                if (LoginForm.currentRole.Equals("Admin"))
                {
                    idTeacher = Convert.ToInt32(TeacherInput.SelectedValue);
                }
                else
                {
                    idTeacher = LoginForm.currentId;
                }
                int grade = Convert.ToInt32(GradeInput.SelectedItem);
                string academYear = AcademYearInput.SelectedItem.ToString();
                DateTime date = DateInput.Value;

                DataBaseManager.AddGrade(idStudent, idSubject, idGradeType, idTeacher, grade, academYear, date);
                OnAddGrade?.Invoke();

                MessageBox.Show("Оценка добавлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при добавлении оценки: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
