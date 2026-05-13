namespace StudentTracker.Forms.Grade
{
    partial class AddGradeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AcademYearInput = new System.Windows.Forms.ComboBox();
            this.SubjectInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GradeInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GradeTypeInput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderAddGrade = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TeacherText = new System.Windows.Forms.Label();
            this.TeacherInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupInput
            // 
            this.GroupInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupInput.FormattingEnabled = true;
            this.GroupInput.Location = new System.Drawing.Point(12, 38);
            this.GroupInput.Name = "GroupInput";
            this.GroupInput.Size = new System.Drawing.Size(121, 21);
            this.GroupInput.TabIndex = 0;
            this.GroupInput.SelectedIndexChanged += new System.EventHandler(this.GroupInput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа";
            // 
            // StudentInput
            // 
            this.StudentInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentInput.FormattingEnabled = true;
            this.StudentInput.Location = new System.Drawing.Point(12, 91);
            this.StudentInput.Name = "StudentInput";
            this.StudentInput.Size = new System.Drawing.Size(121, 21);
            this.StudentInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Студент";
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(302, 246);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 4;
            this.btnAddGrade.Text = "Добавить";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Академический год";
            // 
            // AcademYearInput
            // 
            this.AcademYearInput.AllowDrop = true;
            this.AcademYearInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcademYearInput.FormattingEnabled = true;
            this.AcademYearInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AcademYearInput.Location = new System.Drawing.Point(12, 202);
            this.AcademYearInput.Name = "AcademYearInput";
            this.AcademYearInput.Size = new System.Drawing.Size(121, 21);
            this.AcademYearInput.TabIndex = 5;
            // 
            // SubjectInput
            // 
            this.SubjectInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectInput.FormattingEnabled = true;
            this.SubjectInput.Location = new System.Drawing.Point(12, 145);
            this.SubjectInput.Name = "SubjectInput";
            this.SubjectInput.Size = new System.Drawing.Size(121, 21);
            this.SubjectInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Предмет";
            // 
            // GradeInput
            // 
            this.GradeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeInput.FormattingEnabled = true;
            this.GradeInput.Location = new System.Drawing.Point(160, 145);
            this.GradeInput.Name = "GradeInput";
            this.GradeInput.Size = new System.Drawing.Size(46, 21);
            this.GradeInput.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Оценка";
            // 
            // GradeTypeInput
            // 
            this.GradeTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeTypeInput.FormattingEnabled = true;
            this.GradeTypeInput.Location = new System.Drawing.Point(231, 145);
            this.GradeTypeInput.Name = "GradeTypeInput";
            this.GradeTypeInput.Size = new System.Drawing.Size(148, 21);
            this.GradeTypeInput.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Тип оценки";
            // 
            // errorProviderAddGrade
            // 
            this.errorProviderAddGrade.ContainerControl = this;
            // 
            // DateInput
            // 
            this.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInput.Location = new System.Drawing.Point(231, 202);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(146, 20);
            this.DateInput.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Дата";
            // 
            // TeacherText
            // 
            this.TeacherText.AutoSize = true;
            this.TeacherText.Location = new System.Drawing.Point(157, 75);
            this.TeacherText.Name = "TeacherText";
            this.TeacherText.Size = new System.Drawing.Size(49, 13);
            this.TeacherText.TabIndex = 1;
            this.TeacherText.Text = "Учитель";
            // 
            // TeacherInput
            // 
            this.TeacherInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherInput.FormattingEnabled = true;
            this.TeacherInput.Location = new System.Drawing.Point(160, 91);
            this.TeacherInput.Name = "TeacherInput";
            this.TeacherInput.Size = new System.Drawing.Size(217, 21);
            this.TeacherInput.TabIndex = 8;
            this.TeacherInput.SelectedIndexChanged += new System.EventHandler(this.TeacherInput_SelectedIndexChanged);
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 281);
            this.Controls.Add(this.TeacherInput);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AcademYearInput);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradeInput);
            this.Controls.Add(this.GradeTypeInput);
            this.Controls.Add(this.SubjectInput);
            this.Controls.Add(this.StudentInput);
            this.Controls.Add(this.TeacherText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupInput);
            this.Name = "AddGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить оценку";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StudentInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AcademYearInput;
        private System.Windows.Forms.ComboBox SubjectInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GradeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GradeTypeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProviderAddGrade;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TeacherText;
        private System.Windows.Forms.ComboBox TeacherInput;
    }
}