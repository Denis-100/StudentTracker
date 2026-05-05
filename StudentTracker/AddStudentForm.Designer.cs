namespace StudentTracker
{
    partial class AddStudentForm
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
            this.SurNameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupInput = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BirthDateInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SurNameInput
            // 
            this.SurNameInput.Location = new System.Drawing.Point(12, 31);
            this.SurNameInput.Name = "SurNameInput";
            this.SurNameInput.Size = new System.Drawing.Size(100, 20);
            this.SurNameInput.TabIndex = 0;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(131, 31);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Фамилия";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(128, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Имя";
            // 
            // GroupInput
            // 
            this.GroupInput.FormattingEnabled = true;
            this.GroupInput.Location = new System.Drawing.Point(12, 160);
            this.GroupInput.Name = "GroupInput";
            this.GroupInput.Size = new System.Drawing.Size(100, 21);
            this.GroupInput.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 144);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Группа";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(246, 31);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameInput.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(246, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Отчество";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(246, 160);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 21);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BirthDateInput
            // 
            this.BirthDateInput.Location = new System.Drawing.Point(12, 100);
            this.BirthDateInput.Name = "BirthDateInput";
            this.BirthDateInput.Size = new System.Drawing.Size(100, 20);
            this.BirthDateInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата рождения";
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(131, 100);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(100, 20);
            this.PhoneInput.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Телефон";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(246, 100);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(100, 20);
            this.EmailInput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Почта";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 204);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthDateInput);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.GroupInput);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.SurNameInput);
            this.Name = "AddStudentForm";
            this.Text = " Добавить студента";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurNameInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox GroupInput;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BirthDateInput;
    }
}