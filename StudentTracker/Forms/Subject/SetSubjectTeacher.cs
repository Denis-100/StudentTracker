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

namespace StudentTracker.Forms.Subject
{
    public partial class SetSubjectTeacher : Form
    {
        private string connectionString = DatabaseInitializer.getConnectionString();

        public SetSubjectTeacher()
        {
            InitializeComponent();
            LoadTeachers();
            LoadSubjects();
        }

        private void LoadTeachers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ID, SurName + ' ' + Name + ' ' + LastName AS FIO FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    TeacherInput.DataSource = dt;
                    TeacherInput.DisplayMember = "FIO";
                    TeacherInput.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных об учителях: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadSubjects()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT Id, Name FROM Subjects";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SubjectsSet.Items.Clear();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SubjectItem item = new SubjectItem
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString()
                            };

                            SubjectsSet.Items.Add(item);
                        }
                    }
                }
                TeacherInput_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при загрузке данных о предметах: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SubjectsSet_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (TeacherInput.SelectedValue == null || 
                    !int.TryParse(TeacherInput.SelectedValue.ToString(), out int teacherId))
                    return;

                var subject = SubjectsSet.Items[e.Index] as SubjectItem;

                int subjectId = subject.Id;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql;

                    if (e.NewValue == CheckState.Checked)
                    {
                        sql = "INSERT INTO TeacherSubjects (IdTeacher, IdSubject) VALUES (@Tid, @Sid)";
                    }
                    else
                    {
                        sql = "DELETE FROM TeacherSubjects WHERE IdTeacher = @Tid AND IdSubject = @Sid";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tid", teacherId);
                        cmd.Parameters.AddWithValue("@Sid", subjectId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при обновлении данных о предметах: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TeacherInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeacherInput.SelectedValue == null || !int.TryParse(TeacherInput.SelectedValue.ToString(), out int teacherId))
                return;

            SubjectsSet.ItemCheck -= SubjectsSet_ItemCheck;

            for (int i = 0; i < SubjectsSet.Items.Count; i++)
                SubjectsSet.SetItemChecked(i, false);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT IdSubject FROM TeacherSubjects WHERE IdTeacher = @Tid";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Tid", teacherId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idFromDb = (int)reader["IdSubject"];
                                for (int i = 0; i < SubjectsSet.Items.Count; i++)
                                {
                                    if (((SubjectItem)SubjectsSet.Items[i]).Id == idFromDb)
                                    {
                                        SubjectsSet.SetItemChecked(i, true);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                SubjectsSet.ItemCheck += SubjectsSet_ItemCheck;
            }
        }
    }
}
