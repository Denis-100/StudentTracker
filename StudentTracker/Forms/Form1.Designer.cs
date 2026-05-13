namespace StudentTracker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.table_users = new System.Windows.Forms.ToolStripMenuItem();
            this.table_teachers = new System.Windows.Forms.ToolStripMenuItem();
            this.table_specialties = new System.Windows.Forms.ToolStripMenuItem();
            this.table_groups = new System.Windows.Forms.ToolStripMenuItem();
            this.table_students = new System.Windows.Forms.ToolStripMenuItem();
            this.table_subjects = new System.Windows.Forms.ToolStripMenuItem();
            this.table_grades = new System.Windows.Forms.ToolStripMenuItem();
            this.table_grade_types = new System.Windows.Forms.ToolStripMenuItem();
            this.table_avg_grade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.add_specialties = new System.Windows.Forms.ToolStripMenuItem();
            this.add_group = new System.Windows.Forms.ToolStripMenuItem();
            this.add_teacher = new System.Windows.Forms.ToolStripMenuItem();
            this.add_student = new System.Windows.Forms.ToolStripMenuItem();
            this.add_subject = new System.Windows.Forms.ToolStripMenuItem();
            this.add_grade = new System.Windows.Forms.ToolStripMenuItem();
            this.add_grade_type = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDel = new System.Windows.Forms.ToolStripDropDownButton();
            this.del_specialties = new System.Windows.Forms.ToolStripMenuItem();
            this.del_group = new System.Windows.Forms.ToolStripMenuItem();
            this.del_teacher = new System.Windows.Forms.ToolStripMenuItem();
            this.del_student = new System.Windows.Forms.ToolStripMenuItem();
            this.del_subject = new System.Windows.Forms.ToolStripMenuItem();
            this.del_grade = new System.Windows.Forms.ToolStripMenuItem();
            this.del_grade_type = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.назначитьПредметыУчителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProfilOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПредметуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeachFIOInput = new System.Windows.Forms.ToolStripTextBox();
            this.SearchSubjectInput = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.Location = new System.Drawing.Point(0, 28);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(800, 422);
            this.dgvMain.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refresh,
            this.toolStripDropDownButton3,
            this.toolStripAdd,
            this.toolStripDel,
            this.toolStripSettings,
            this.btnProfilOpen,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(65, 22);
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.table_users,
            this.table_teachers,
            this.table_specialties,
            this.table_groups,
            this.table_students,
            this.table_subjects,
            this.table_grades,
            this.table_grade_types,
            this.table_avg_grade});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton3.Text = "Таблица";
            // 
            // table_users
            // 
            this.table_users.Name = "table_users";
            this.table_users.Size = new System.Drawing.Size(162, 22);
            this.table_users.Text = "Пользователей";
            this.table_users.Click += new System.EventHandler(this.пользователейToolStripMenuItem_Click);
            // 
            // table_teachers
            // 
            this.table_teachers.Name = "table_teachers";
            this.table_teachers.Size = new System.Drawing.Size(162, 22);
            this.table_teachers.Text = "Учителей";
            this.table_teachers.Click += new System.EventHandler(this.учителейToolStripMenuItem_Click);
            // 
            // table_specialties
            // 
            this.table_specialties.Name = "table_specialties";
            this.table_specialties.Size = new System.Drawing.Size(162, 22);
            this.table_specialties.Text = "Направлений";
            this.table_specialties.Click += new System.EventHandler(this.направленийХToolStripMenuItem_Click_Click);
            // 
            // table_groups
            // 
            this.table_groups.Name = "table_groups";
            this.table_groups.Size = new System.Drawing.Size(162, 22);
            this.table_groups.Text = "Групп";
            this.table_groups.Click += new System.EventHandler(this.группToolStripMenuItem_Click);
            // 
            // table_students
            // 
            this.table_students.Name = "table_students";
            this.table_students.Size = new System.Drawing.Size(162, 22);
            this.table_students.Text = "Студентов";
            this.table_students.Click += new System.EventHandler(this.студентовToolStripMenuItem_Click);
            // 
            // table_subjects
            // 
            this.table_subjects.Name = "table_subjects";
            this.table_subjects.Size = new System.Drawing.Size(162, 22);
            this.table_subjects.Text = "Предметов";
            this.table_subjects.Click += new System.EventHandler(this.предметовToolStripMenuItem_Click);
            // 
            // table_grades
            // 
            this.table_grades.Name = "table_grades";
            this.table_grades.Size = new System.Drawing.Size(162, 22);
            this.table_grades.Text = "Оценок";
            this.table_grades.Click += new System.EventHandler(this.оценокToolStripMenuItem_Click);
            // 
            // table_grade_types
            // 
            this.table_grade_types.Name = "table_grade_types";
            this.table_grade_types.Size = new System.Drawing.Size(162, 22);
            this.table_grade_types.Text = "Типов оценок";
            this.table_grade_types.Click += new System.EventHandler(this.типовОценокToolStripMenuItem_Click);
            // 
            // table_avg_grade
            // 
            this.table_avg_grade.Name = "table_avg_grade";
            this.table_avg_grade.Size = new System.Drawing.Size(162, 22);
            this.table_avg_grade.Text = "Среднего балла";
            this.table_avg_grade.Visible = false;
            this.table_avg_grade.Click += new System.EventHandler(this.table_avg_grade_Click);
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_specialties,
            this.add_group,
            this.add_teacher,
            this.add_student,
            this.add_subject,
            this.add_grade,
            this.add_grade_type});
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(72, 22);
            this.toolStripAdd.Text = "Добавить";
            // 
            // add_specialties
            // 
            this.add_specialties.Name = "add_specialties";
            this.add_specialties.Size = new System.Drawing.Size(148, 22);
            this.add_specialties.Text = "Направление";
            this.add_specialties.Click += new System.EventHandler(this.направлениеХToolStripMenuItem_Click);
            // 
            // add_group
            // 
            this.add_group.Name = "add_group";
            this.add_group.Size = new System.Drawing.Size(148, 22);
            this.add_group.Text = "Группу";
            this.add_group.Click += new System.EventHandler(this.группаToolStripMenuItem_Click);
            // 
            // add_teacher
            // 
            this.add_teacher.Name = "add_teacher";
            this.add_teacher.Size = new System.Drawing.Size(148, 22);
            this.add_teacher.Text = "Учителя";
            this.add_teacher.Click += new System.EventHandler(this.учителяToolStripMenuItem_Click);
            // 
            // add_student
            // 
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(148, 22);
            this.add_student.Text = "Студента";
            this.add_student.Click += new System.EventHandler(this.студентаToolStripMenuItem_Click);
            // 
            // add_subject
            // 
            this.add_subject.Name = "add_subject";
            this.add_subject.Size = new System.Drawing.Size(148, 22);
            this.add_subject.Text = "Предмет";
            this.add_subject.Click += new System.EventHandler(this.предметToolStripMenuItem_Click);
            // 
            // add_grade
            // 
            this.add_grade.Name = "add_grade";
            this.add_grade.Size = new System.Drawing.Size(148, 22);
            this.add_grade.Text = "Оценку";
            this.add_grade.Click += new System.EventHandler(this.оценкуToolStripMenuItem_Click);
            // 
            // add_grade_type
            // 
            this.add_grade_type.Name = "add_grade_type";
            this.add_grade_type.Size = new System.Drawing.Size(148, 22);
            this.add_grade_type.Text = "Тип оценки";
            this.add_grade_type.Click += new System.EventHandler(this.типОценкиХToolStripMenuItem_Click);
            // 
            // toolStripDel
            // 
            this.toolStripDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.del_specialties,
            this.del_group,
            this.del_teacher,
            this.del_student,
            this.del_subject,
            this.del_grade,
            this.del_grade_type});
            this.toolStripDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDel.Image")));
            this.toolStripDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.Size = new System.Drawing.Size(64, 22);
            this.toolStripDel.Text = "Удалить";
            // 
            // del_specialties
            // 
            this.del_specialties.Name = "del_specialties";
            this.del_specialties.Size = new System.Drawing.Size(148, 22);
            this.del_specialties.Text = "Направление";
            this.del_specialties.Click += new System.EventHandler(this.направлениеToolStripMenuItem_Click);
            // 
            // del_group
            // 
            this.del_group.Name = "del_group";
            this.del_group.Size = new System.Drawing.Size(148, 22);
            this.del_group.Text = "Группу";
            this.del_group.Click += new System.EventHandler(this.группуToolStripMenuItem_Click);
            // 
            // del_teacher
            // 
            this.del_teacher.Name = "del_teacher";
            this.del_teacher.Size = new System.Drawing.Size(148, 22);
            this.del_teacher.Text = "Учителя";
            this.del_teacher.Click += new System.EventHandler(this.учителяХToolStripMenuItem_Click);
            // 
            // del_student
            // 
            this.del_student.Name = "del_student";
            this.del_student.Size = new System.Drawing.Size(148, 22);
            this.del_student.Text = "Студента";
            this.del_student.Click += new System.EventHandler(this.студентаToolStripMenuItem1_Click);
            // 
            // del_subject
            // 
            this.del_subject.Name = "del_subject";
            this.del_subject.Size = new System.Drawing.Size(148, 22);
            this.del_subject.Text = "Предмет";
            this.del_subject.Click += new System.EventHandler(this.предметХToolStripMenuItem_Click);
            // 
            // del_grade
            // 
            this.del_grade.Name = "del_grade";
            this.del_grade.Size = new System.Drawing.Size(148, 22);
            this.del_grade.Text = "Оценку";
            this.del_grade.Click += new System.EventHandler(this.оценкуХToolStripMenuItem_Click);
            // 
            // del_grade_type
            // 
            this.del_grade_type.Name = "del_grade_type";
            this.del_grade_type.Size = new System.Drawing.Size(148, 22);
            this.del_grade_type.Text = "Тип оценки";
            this.del_grade_type.Click += new System.EventHandler(this.типОценкиХToolStripMenuItem1_Click);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назначитьПредметыУчителюToolStripMenuItem});
            this.toolStripSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSettings.Image")));
            this.toolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(80, 22);
            this.toolStripSettings.Text = "Настройки";
            // 
            // назначитьПредметыУчителюToolStripMenuItem
            // 
            this.назначитьПредметыУчителюToolStripMenuItem.Name = "назначитьПредметыУчителюToolStripMenuItem";
            this.назначитьПредметыУчителюToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.назначитьПредметыУчителюToolStripMenuItem.Text = "Назначить предметы учителю";
            this.назначитьПредметыУчителюToolStripMenuItem.Click += new System.EventHandler(this.назначитьПредметыУчителюToolStripMenuItem_Click);
            // 
            // btnProfilOpen
            // 
            this.btnProfilOpen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnProfilOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnProfilOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilOpen.Image")));
            this.btnProfilOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfilOpen.Name = "btnProfilOpen";
            this.btnProfilOpen.Size = new System.Drawing.Size(63, 22);
            this.btnProfilOpen.Text = "Профиль";
            this.btnProfilOpen.Click += new System.EventHandler(this.btnProfilOpen_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поИмениToolStripMenuItem,
            this.поПредметуToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButton1.Text = "Поиск";
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeachFIOInput});
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поИмениToolStripMenuItem.Text = "По ФИО";
            // 
            // поПредметуToolStripMenuItem
            // 
            this.поПредметуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchSubjectInput});
            this.поПредметуToolStripMenuItem.Name = "поПредметуToolStripMenuItem";
            this.поПредметуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поПредметуToolStripMenuItem.Text = "По предмету";
            // 
            // SeachFIOInput
            // 
            this.SeachFIOInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SeachFIOInput.Name = "SeachFIOInput";
            this.SeachFIOInput.Size = new System.Drawing.Size(100, 23);
            this.SeachFIOInput.TextChanged += new System.EventHandler(this.SeachFIOInput_TextChanged);
            // 
            // SearchSubjectInput
            // 
            this.SearchSubjectInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchSubjectInput.Name = "SearchSubjectInput";
            this.SearchSubjectInput.Size = new System.Drawing.Size(100, 23);
            this.SearchSubjectInput.TextChanged += new System.EventHandler(this.SearchSubjectInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет оценок";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripAdd;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDel;
        private System.Windows.Forms.ToolStripMenuItem add_student;
        private System.Windows.Forms.ToolStripMenuItem add_group;
        private System.Windows.Forms.ToolStripMenuItem add_grade;
        private System.Windows.Forms.ToolStripMenuItem del_student;
        private System.Windows.Forms.ToolStripMenuItem del_group;
        private System.Windows.Forms.ToolStripMenuItem add_teacher;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem table_users;
        private System.Windows.Forms.ToolStripMenuItem table_specialties;
        private System.Windows.Forms.ToolStripMenuItem table_groups;
        private System.Windows.Forms.ToolStripMenuItem table_students;
        private System.Windows.Forms.ToolStripMenuItem table_subjects;
        private System.Windows.Forms.ToolStripMenuItem table_grades;
        private System.Windows.Forms.ToolStripMenuItem table_teachers;
        private System.Windows.Forms.ToolStripMenuItem add_specialties;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.ToolStripMenuItem del_specialties;
        private System.Windows.Forms.ToolStripMenuItem table_grade_types;
        private System.Windows.Forms.ToolStripMenuItem add_grade_type;
        private System.Windows.Forms.ToolStripMenuItem del_teacher;
        private System.Windows.Forms.ToolStripMenuItem del_grade;
        private System.Windows.Forms.ToolStripMenuItem del_grade_type;
        private System.Windows.Forms.ToolStripMenuItem add_subject;
        private System.Windows.Forms.ToolStripMenuItem del_subject;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem назначитьПредметыУчителюToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnProfilOpen;
        private System.Windows.Forms.ToolStripMenuItem table_avg_grade;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SeachFIOInput;
        private System.Windows.Forms.ToolStripMenuItem поПредметуToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SearchSubjectInput;
    }
}

