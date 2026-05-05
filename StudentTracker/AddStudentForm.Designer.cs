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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SurNameInput
            // 
            this.SurNameInput.Location = new System.Drawing.Point(172, 65);
            this.SurNameInput.Name = "SurNameInput";
            this.SurNameInput.Size = new System.Drawing.Size(100, 20);
            this.SurNameInput.TabIndex = 0;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(172, 131);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(169, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Фамилия";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(169, 115);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Имя";
            // 
            // GroupInput
            // 
            this.GroupInput.FormattingEnabled = true;
            this.GroupInput.Location = new System.Drawing.Point(172, 251);
            this.GroupInput.Name = "GroupInput";
            this.GroupInput.Size = new System.Drawing.Size(121, 21);
            this.GroupInput.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(169, 235);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Группа";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(172, 192);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameInput.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(172, 173);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Фамилия";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(394, 233);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(85, 39);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "AddStudentForm";
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
    }
}