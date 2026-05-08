using System;
using System.Data.SqlClient;
using System.Windows.Forms;


public static class DatabaseInitializer
{
    // Строка для подключение к бд master
    private static string masterConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
    // Строка для подключения к нашей бд
    private static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=StudentsDB;Trusted_Connection=True;";
    
    public static string getConnectionString() { return connectionString; }

    public static void Init()
    {
        try
        {
            CreateDatabase();
            CreateTable();
            CreateDefaultAdmin();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private static void CreateDatabase()
    {
        using (SqlConnection connection = new SqlConnection(masterConnectionString))
        {
            connection.Open();

            string sql = @"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'StudentsDB')
                            CREATE DATABASE StudentsDB";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    private static void CreateTable()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = @"
                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Specialties')
                            CREATE TABLE Specialties(
                                Id INT PRIMARY KEY IDENTITY,
                                Name NVARCHAR(100) NOT NULL
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Teachers')
                            CREATE TABLE Teachers(
                                Id INT PRIMARY KEY IDENTITY,
                                SurName NVARCHAR(30) NOT NULL,
                                Name NVARCHAR(30) NOT NULL,
                                LastName NVARCHAR(30) NOT NULL DEFAULT ''
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GradeTypes')
                            CREATE TABLE GradeTypes(
                                Id INT PRIMARY KEY IDENTITY,
                                Name NVARCHAR(50) NOT NULL
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Groups')
                            CREATE TABLE Groups(
                                Id INT PRIMARY KEY IDENTITY,
                                Name NVARCHAR(50) NOT NULL,
                                IdSpecialty INT REFERENCES Specialties(Id) ON DELETE CASCADE
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Students')
                            CREATE TABLE Students(
                                Id INT PRIMARY KEY IDENTITY,
                                SurName NVARCHAR(30) NOT NULL,
                                Name NVARCHAR(30) NOT NULL,
                                LastName NVARCHAR(30) NOT NULL DEFAULT '',
                                BirthDate DATE NOT NULL,
                                Phone NVARCHAR(20) NOT NULL DEFAULT '',
                                Email NVARCHAR(50) NOT NULL DEFAULT '',
                                IdGroup INT REFERENCES Groups(Id) ON DELETE CASCADE
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
                            CREATE TABLE Users(
                                Id INT PRIMARY KEY IDENTITY,
                                Login NVARCHAR(50) NOT NULL UNIQUE,
                                Password NVARCHAR(MAX) NOT NULL,
                                Role NVARCHAR(20) NOT NULL,
                                IdTeacher INT REFERENCES Teachers(Id) ON DELETE SET NULL,
                                IdStudent INT REFERENCES Students(Id) ON DELETE SET NULL
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Subjects')
                            CREATE TABLE Subjects(
                                Id INT PRIMARY KEY IDENTITY,
                                Name NVARCHAR(100) NOT NULL
                            )

                            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Grades')
                            CREATE TABLE Grades(
                                Id INT PRIMARY KEY IDENTITY,
                                IdStudent INT REFERENCES Students(Id) ON DELETE CASCADE,
                                IdSubject INT REFERENCES Subjects(Id) ON DELETE CASCADE,
                                IdTeacher INT REFERENCES Teachers(Id),
                                IdType INT REFERENCES GradeTypes(Id),
                                Grade INT NOT NULL CHECK (Grade BETWEEN 2 AND 5),
                                AcademicYear NVARCHAR(10) NOT NULL,
                                Date DATETIME2 DEFAULT GETDATE()
                            )";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    private static void CreateDefaultAdmin()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string sql = @"IF NOT EXISTS (SELECT 1 FROM Users WHERE Login = 'admin')
                           BEGIN
                                INSERT INTO Users (Login, Password, Role)
                                VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'Admin')
                           END";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}

