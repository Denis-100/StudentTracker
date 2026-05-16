using StudentTracker;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

public static class DataBaseManager
{
    private static string connectionString = DatabaseInitializer.getConnectionString();

    private static DataTable GetAllMethod(string sql)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

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
    // Пользователи
    //

    public static DataTable GetAllUsers()
    {
        string sql = "SELECT Id, Login, Password, Role, IdTeacher, IdStudent FROM Users";
        return GetAllMethod(sql);
    }

    //
    // Пользователи
    //

    //
    // Учителя
    //

    public static DataTable GetAllTeachers()
    {
        
        string sql = @"SELECT Id, 
                       SurName + ' ' + Name + ' ' + LastName AS [ФИО],
                       BirthDate AS [Дата рождения],
                       Phone AS [Телефон],
                       Email AS [Почта]
                       FROM Teachers";
        return GetAllMethod(sql);
    }

    public static bool AddTeacher(string SurName, string Name, string LastName, string BirthDate, string Phone, string Email,
        string Login, string Password)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlCheckLogin = "SELECT TOP 1 1 FROM Users WHERE Login = @Login";
                using (SqlCommand cmd = new SqlCommand(sqlCheckLogin, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", Login);
                    var res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        MessageBox.Show($"Логин занят!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                string sqlCheck = "SELECT TOP 1 1 FROM Teachers " +
                    "WHERE SurName = @SurName AND Name = @Name AND LastName = @LastName AND Email = @Email";

                using (SqlCommand cmd = new SqlCommand(sqlCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@SurName", SurName);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    var res = cmd.ExecuteScalar();

                    if (res != null) 
                    {
                        MessageBox.Show($"Такой учитель уже есть!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    };
                }
                try
                {

                    int idNewTeacher = -1;
                    string sqlAdd = "INSERT INTO Teachers " +
                                        "(SurName, Name, LastName, BirthDate, Phone, Email) " +
                                        "OUTPUT INSERTED.Id " +
                                        "VALUES (@SurName, @Name, @LastName, @BirthDate, @Phone, @Email)";
                    using (SqlCommand cmd = new SqlCommand(sqlAdd, conn))
                    {
                        cmd.Parameters.AddWithValue("@SurName", SurName);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Email", Email);

                        idNewTeacher = (int)cmd.ExecuteScalar();
                    }
                    
                    if (idNewTeacher == -1)
                    {
                        MessageBox.Show($"Не удалось добавить запись учителя в таблицу пользователей", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string sqlAddUser = "INSERT INTO Users (Login, Password, Salt, Role, IdTeacher) " +
                        "VALUES (@Login, @Password, @Salt, @Role, @IdTeacher)";

                    long salt = SecurityHelper.GenerateRandomSalt();
                    string passwordHash = SecurityHelper.HashPassword(Password, salt);

                    using (SqlCommand cmd = new SqlCommand(sqlAddUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@Login", Login);
                        cmd.Parameters.AddWithValue("@Password", passwordHash);
                        cmd.Parameters.AddWithValue("@Salt", salt);
                        cmd.Parameters.AddWithValue("@Role", "Teacher");
                        cmd.Parameters.AddWithValue("@IdTeacher", idNewTeacher);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось добавить учителя: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
                return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return false;
        }
    }

    public static bool DelTeacher(DataGridView dgvTeachers)
    {
        try
        {
            if (dgvTeachers.CurrentRow == null) return false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                int idTeacher = (int)dgvTeachers.CurrentRow.Cells["Id"].Value;
                string fullName = dgvTeachers.CurrentRow.Cells["ФИО"].Value.ToString();

                var confirm = MessageBox.Show($"Удалить учителя {fullName}?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.No) return false;

                string sqlDel = "DELETE FROM Users WHERE IdTeacher = @Id";

                using (SqlCommand cmd = new SqlCommand(sqlDel, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idTeacher);
                    cmd.ExecuteNonQuery();
                }

                string sql = "DELETE FROM Teachers WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idTeacher);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Возникла ошибка при удалении учителя: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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
        string sql = "SELECT Id, Name AS [Название] FROM Specialties";
        return GetAllMethod(sql);
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
            if (dgvSpecilties.CurrentRow == null) return false;
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
        string sql = @"SELECT g.Id, 
                        g.Name AS [Название], 
                        s.Name AS [Направление]
                        FROM Groups AS g
                        LEFT JOIN Specialties AS s ON g.IdSpecialty = s.Id";
        return GetAllMethod(sql);
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
            if (dgvGroup.CurrentRow == null) return false;
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
        return GetAllMethod(sql);
    }

    public static bool AddStudent(string SurName, string Name, string LastName,
        string BirthDate, string Phone, string Email, int IdGroup, string Login, string Password)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlCheck = "SELECT TOP 1 1 FROM Students WHERE " +
                    "Name = @Name AND SurName = @SurName AND Email = @Email AND Phone = @Phone";
                using (SqlCommand cmd = new SqlCommand(sqlCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@SurName", SurName);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    
                    object res = cmd.ExecuteScalar();

                    if (res != null)
                    {
                        MessageBox.Show($"Такой студент уже есть!");
                        return false;
                    }
                }

                int newIdStudent = -1;

                string sql = "INSERT INTO Students " +
                    "(SurName, Name, LastName, BirthDate, Phone, Email, IdGroup) " +
                    "VALUES " +
                    "(@surname, @name, @lastname, @birthdate, @phone, @email, @idgroup);" +
                    "SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@surname", SurName);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@lastname", LastName);
                    cmd.Parameters.AddWithValue("@birthdate", BirthDate);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@idgroup", IdGroup);

                    newIdStudent = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string sqlAdd = "INSERT INTO Users (Login, Password, Salt, Role, IdStudent) " +
                    "VALUES (@Login, @Password, @Salt, @Role, @IdStudent)";

                long salt = SecurityHelper.GenerateRandomSalt();
                string passwordHash = SecurityHelper.HashPassword(Password, salt);

                using (SqlCommand cmd = new SqlCommand(sqlAdd, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", Login);
                    cmd.Parameters.AddWithValue("@Password", passwordHash);
                    cmd.Parameters.AddWithValue("@Salt", salt);
                    cmd.Parameters.AddWithValue("@Role", "Student");
                    cmd.Parameters.AddWithValue("@IdStudent", newIdStudent);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}", "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    try
                    {
                        string sqlDelUsersStudent = "DELETE FROM Users WHERE IdStudent = @IdStudent";
                        using (SqlCommand cmd = new SqlCommand(sqlDelUsersStudent, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdStudent", studentId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удалось удалить данные о студенте из таблицы пользователей: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

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
        string sql = "SELECT Id, Name AS [Название] FROM Subjects";
        return GetAllMethod(sql);
    }

    public static bool AddSubjects(string name)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlCheck = "SELECT TOP 1 1 FROM Subjects WHERE Name = @Name";
                using (SqlCommand cmd = new SqlCommand(sqlCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    object res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        MessageBox.Show($"Такой предмет уже есть!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                string sql = "INSERT INTO Subjects (Name) VALUES (@Name)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении предмета: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool DelSubjects(DataGridView dgv)
    {
        try
        {
            if (dgv.CurrentRow == null) return false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                int id = (int)dgv.CurrentRow.Cells["Id"].Value;
                string name = dgv.CurrentRow.Cells["Название"].Value.ToString();

                var confirm = MessageBox.Show($"Удалить предмет {name}?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.No) return false;

                string sql = "DELETE FROM Subjects WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при удалении предмета: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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
        string sql;

        if (LoginForm.currentRole.Equals("Student"))
        {
            sql = "SELECT g.Id, " +
            "stud.SurName + ' ' + stud.Name + ' ' + stud.LastName AS [ФИО], " +
            "sub.Name AS [Предмет], " +
            "t.SurName + ' ' + t.Name + ' ' + t.LastName AS [Преподаватель], " +
            "gt.Name AS [Тип оценки], " +
            "Grade AS [Оценка], " +
            "FORMAT(g.Date, 'dd.MM.yyyy') AS [Дата], " +
            "AcademicYear AS [Академический год] " +
            "FROM Grades g " +
            "JOIN Students stud ON g.IdStudent = stud.Id " +
            "JOIN Subjects sub ON g.IdSubject = sub.Id " +
            "JOIN Teachers t ON g.IdTeacher = t.Id " +
            "JOIN GradeTypes gt ON g.IdType = gt.Id " +
            $"WHERE g.IdStudent = {LoginForm.currentId}";
        }
        else
        {
            sql = "SELECT g.Id, " +
            "stud.SurName + ' ' + stud.Name + ' ' + stud.LastName AS [ФИО], " +
            "sub.Name AS [Предмет], " +
            "t.SurName + ' ' + t.Name + ' ' + t.LastName AS [Преподаватель], " +
            "gt.Name AS [Тип оценки], " +
            "Grade AS [Оценка], " +
            "FORMAT(g.Date, 'dd.MM.yyyy') AS [Дата], " +
            "AcademicYear AS [Академический год] " +
            "FROM Grades g " +
            "JOIN Students stud ON g.IdStudent = stud.Id " +
            "JOIN Subjects sub ON g.IdSubject = sub.Id " +
            "JOIN Teachers t ON g.IdTeacher = t.Id " +
            "JOIN GradeTypes gt ON g.IdType = gt.Id";
        }
        
        return GetAllMethod(sql);
    }

    public static DataTable getAvgGrades()
    {
        string sql = $@"SELECT 
                        sub.Name AS [Предмет], 
                        ROUND(AVG(CAST(g.Grade AS FLOAT)), 2) AS [Средний балл], 
                        COUNT(g.Grade) AS [Оценок]
                        FROM Grades g
                        JOIN Subjects sub ON g.IdSubject = sub.Id 
                        WHERE g.IdStudent = {LoginForm.currentId} 
                        GROUP BY sub.Name";

        return GetAllMethod(sql);
    }

    public static bool AddGrade(int idStudent, int idSubject, int idGradeType, int idTeacher, int grade,
        string academicYear, DateTime date)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Grades (IdStudent, IdSubject, IdTeacher, IdType, Grade, AcademicYear, Date) " +
                    "VALUES (@IdStudent, @IdSubject, @IdTeacher, @IdType, @Grade, @AcademicYear, @Date)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdStudent", idStudent);
                    cmd.Parameters.AddWithValue("@IdSubject", idSubject);
                    cmd.Parameters.AddWithValue("@IdTeacher", idTeacher);
                    cmd.Parameters.AddWithValue("@IdType", idGradeType);
                    cmd.Parameters.AddWithValue("@Grade", grade);
                    cmd.Parameters.AddWithValue("@AcademicYear", academicYear);
                    cmd.Parameters.AddWithValue("@Date", date);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении оценки: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool DelGrade(DataGridView dgvGrade)
    {
        try
        {
            if (dgvGrade.CurrentRow == null) return false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                int id = Convert.ToInt32(dgvGrade.CurrentRow.Cells["Id"].Value);
                string text = $"Удалить оценку {dgvGrade.CurrentRow.Cells["Оценка"].Value.ToString()} у " +
                    $"{dgvGrade.CurrentRow.Cells["ФИО"].Value.ToString()} " +
                    $"по предмету {dgvGrade.CurrentRow.Cells["Предмет"].Value.ToString()}?";

                var result = MessageBox.Show(text, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    string sql = "DELETE FROM Grades WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при удалении оценки: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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
        string sql = "SELECT Id, Name AS [Название] FROM GradeTypes";
        return GetAllMethod(sql);
    }

    public static bool AddGradeTypes(string name)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlCheck = "SELECT TOP 1 1 FROM GradeTypes " +
                    "WHERE Name = @Name";

                using (SqlCommand cmd = new SqlCommand(sqlCheck, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    var res = cmd.ExecuteScalar();

                    if (res != null)
                    {
                        MessageBox.Show($"Такой тип оценки уже есть!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    ;
                }

                string sql = "INSERT INTO GradeTypes (Name) VALUES (@Name)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при добавлении типа оценки: {ex.Message}");
            return false;
        }
    }

    public static bool DelGradeTypes(DataGridView dgvGradeTypes)
    {
        try
        {
            if (dgvGradeTypes.CurrentRow == null) return false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM GradeTypes WHERE Id = @Id";
                int id = (int)dgvGradeTypes.CurrentRow.Cells["Id"].Value;
                string name = dgvGradeTypes.CurrentRow.Cells["Название"].Value.ToString();

                var confirm = MessageBox.Show($"Удалить тип оценки: {name}?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка удаления типа оценки: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    //
    // Тип оценок
    //
}

