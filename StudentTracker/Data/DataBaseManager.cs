using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class DataBaseManager
{
    private static string connectionString = DatabaseInitializer.getConnectionString();

    //
    // Пользователи
    //

    public static DataTable GetAllUsers()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(sql ,conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    //
    // Пользователи
    //

    //
    // Учителя
    //

    public static DataTable GetAllTeachers()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Teachers";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    //
    // Учителя
    //

    //
    // Направления (Специальности)
    //
    public static DataTable GetAllSpecialties()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Name AS [Название] FROM Specialties";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Возникла ошибка при загрузке всех направлений: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    public static bool AddSpecialties(TextBox nameSpecilties)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlCheck = "SELECT TOP 1 1 FROM Specialties WHERE Name = @Name";
                using (SqlCommand cmd = new SqlCommand(sqlCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", nameSpecilties.Text.Trim());
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("Такое направление уже существует!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                string sql = "INSERT INTO Specialties (Name) VALUES (@Name)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", nameSpecilties.Text.Trim());
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Возникла ошибка при добавлении направления: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool DelSpecilties(DataGridView dgvSpecilties)
    {
        try
        {
            int id = Convert.ToInt32(dgvSpecilties.CurrentRow.Cells["Id"].Value);
            string nameSpec = dgvSpecilties.CurrentRow.Cells["Название"].Value.ToString().Trim();

            var confirm = MessageBox.Show($"Удалить направление: '{nameSpec}'?\nВсе группы и студенты этих группы удаляться.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "DELETE Specialties WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Возникла ошибка при удалении направления: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return false;
    }
    //
    // Направления (Специальности)
    //

    //  Группы
    //
    public static DataTable GetAllGroups()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT g.Id, 
                        g.Name AS [Название], 
                        s.Name AS [Направление]
                        FROM Groups AS g
                        LEFT JOIN Specialties AS s ON g.IdSpecialty = s.Id";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки таблицы групп: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    public static bool AddGroup(TextBox groupNameInput, ComboBox specialityInput)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sqlCheckGroup = "SELECT TOP 1 1 FROM Groups WHERE Name = @Name";

                using (SqlCommand cmd = new SqlCommand(sqlCheckGroup, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", groupNameInput.Text.Trim());
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("Такая группа уже существует!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                string sql = "INSERT INTO Groups (Name, IdSpecialty)" +
                            "VALUES (@Name, @Id)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", groupNameInput.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id", (int)specialityInput.SelectedValue);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Возникла ошибка при добавлении группы: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

    }

    public static bool DelGroup(DataGridView dgvGroup)
    {
        try
        {
            int id = Convert.ToInt32(dgvGroup.CurrentRow.Cells["Id"].Value);
            string nameGroup = dgvGroup.CurrentRow.Cells["Название"].Value.ToString().Trim();

            var confirm = MessageBox.Show($"Удалить группу: '{nameGroup}'?\n" +
                $"Все студенты этой группы так же удаляться.", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "DELETE Groups WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Возникла ошибка при удалении группы: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return false;
    }
    //
    // Группы
    //

    //
    // Студенты
    //

    public static DataTable GetAllStudents()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"SELECT s.Id,
                           s.SurName + ' ' + s.Name + ' ' + s.LastName AS [ФИО],
                           s.BirthDate AS [Дата рождения],
                           s.Phone AS [Телефон],
                           s.Email AS [Почта],
                           spec.Name AS [Направление],
                           g.Name AS [Группа],
                           ROUND(AVG(CAST(grd.Grade AS FLOAT)), 2) AS [Ср. Балл]
                           FROM Students as s
                           JOIN Groups AS g ON s.IdGroup = g.Id
                           LEFT JOIN Grades AS grd ON grd.IdStudent = s.Id
                           JOIN Specialties AS spec ON g.IdSpecialty = spec.Id
                           GROUP BY s.Id, s.SurName, s.Name, s.LastName, s.BirthDate, s.Phone, s.Email, spec.Name, g.Name";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    public static bool AddStudent(string SurName, string Name, string LastName,
        string BirthDate, string Phone, string Email, int IdGroup)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Students " +
                    "(SurName, Name, LastName, BirthDate, Phone, Email, IdGroup) " +
                    "VALUES " +
                    "(@surname, @name, @lastname, @birthdate, @phone, @email, @idgroup)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@surname", SurName);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@lastname", LastName);
                cmd.Parameters.AddWithValue("@birthdate", BirthDate);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@idgroup", IdGroup);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}");
            return false; 
        }
    }

    public static bool DelStudent(DataGridView dgv)
    {
        if (dgv.CurrentRow == null) return false;

        int studentId = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
        string studentName = dgv.CurrentRow.Cells["ФИО"].Value.ToString();
        var confirm = MessageBox.Show($"Удалить студента: {studentName}?",
            "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM Students WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", studentId);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления студента: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        return false;
    }
    //
    // Студенты
    //
    //
    
    //
    // Предметы
    //

    public static DataTable GetAllSubjects()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Subjects";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    //
    // Предметы
    //

    //
    // Оценки
    //

    public static DataTable GetAllGrades()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Grades";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    //
    // Оценки
    //

    //
    // Тип оценок
    //

    public static DataTable GetAllGradeTypes()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM GradeTypes";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }

    //
    // Тип оценок
    //
}

