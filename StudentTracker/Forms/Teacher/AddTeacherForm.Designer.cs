namespace StudentTracker.Forms
{
    partial class AddTeacherForm
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
            this.dgvTeacherAdd = new System.Windows.Forms.DataGridView();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.SurNameTeacherInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTeacherInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameTeacherInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginTeacherInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTeacherInput = new System.Windows.Forms.TextBox();
            this.errorProviderAddTeacher = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherAdd
            // 
            this.dgvTeacherAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherAdd.Location = new System.Drawing.Point(12, 12);
            this.dgvTeacherAdd.Name = "dgvTeacherAdd";
            this.dgvTeacherAdd.Size = new System.Drawing.Size(328, 264);
            this.dgvTeacherAdd.TabIndex = 0;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(349, 249);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(100, 27);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Добавить";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // SurNameTeacherInput
            // 
            this.SurNameTeacherInput.Location = new System.Drawing.Point(349, 29);
            this.SurNameTeacherInput.Name = "SurNameTeacherInput";
            this.SurNameTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.SurNameTeacherInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // NameTeacherInput
            // 
            this.NameTeacherInput.Location = new System.Drawing.Point(349, 74);
            this.NameTeacherInput.Name = "NameTeacherInput";
            this.NameTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.NameTeacherInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // LastNameTeacherInput
            // 
            this.LastNameTeacherInput.Location = new System.Drawing.Point(349, 118);
            this.LastNameTeacherInput.Name = "LastNameTeacherInput";
            this.LastNameTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameTeacherInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин";
            // 
            // LoginTeacherInput
            // 
            this.LoginTeacherInput.Location = new System.Drawing.Point(349, 163);
            this.LoginTeacherInput.Name = "LoginTeacherInput";
            this.LoginTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.LoginTeacherInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // PasswordTeacherInput
            // 
            this.PasswordTeacherInput.Location = new System.Drawing.Point(349, 205);
            this.PasswordTeacherInput.Name = "PasswordTeacherInput";
            this.PasswordTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordTeacherInput.TabIndex = 10;
            // 
            // errorProviderAddTeacher
            // 
            this.errorProviderAddTeacher.ContainerControl = this;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTeacherInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginTeacherInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTeacherInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTeacherInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurNameTeacherInput);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.dgvTeacherAdd);
            this.Name = "AddTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить учителя";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherAdd;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.TextBox SurNameTeacherInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTeacherInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameTeacherInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginTeacherInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTeacherInput;
        private System.Windows.Forms.ErrorProvider errorProviderAddTeacher;
    }
}