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
            this.btnGenerateLogPas = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BirthDateInput = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneInput = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherAdd
            // 
            this.dgvTeacherAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherAdd.Location = new System.Drawing.Point(12, 12);
            this.dgvTeacherAdd.Name = "dgvTeacherAdd";
            this.dgvTeacherAdd.Size = new System.Drawing.Size(283, 264);
            this.dgvTeacherAdd.TabIndex = 0;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTeacher.Location = new System.Drawing.Point(415, 241);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(100, 35);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Добавить";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // SurNameTeacherInput
            // 
            this.SurNameTeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurNameTeacherInput.Location = new System.Drawing.Point(304, 29);
            this.SurNameTeacherInput.Name = "SurNameTeacherInput";
            this.SurNameTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.SurNameTeacherInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // NameTeacherInput
            // 
            this.NameTeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTeacherInput.Location = new System.Drawing.Point(304, 74);
            this.NameTeacherInput.Name = "NameTeacherInput";
            this.NameTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.NameTeacherInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // LastNameTeacherInput
            // 
            this.LastNameTeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTeacherInput.Location = new System.Drawing.Point(304, 118);
            this.LastNameTeacherInput.Name = "LastNameTeacherInput";
            this.LastNameTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.LastNameTeacherInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин";
            // 
            // LoginTeacherInput
            // 
            this.LoginTeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTeacherInput.Location = new System.Drawing.Point(304, 163);
            this.LoginTeacherInput.Name = "LoginTeacherInput";
            this.LoginTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.LoginTeacherInput.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // PasswordTeacherInput
            // 
            this.PasswordTeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTeacherInput.Location = new System.Drawing.Point(304, 205);
            this.PasswordTeacherInput.Name = "PasswordTeacherInput";
            this.PasswordTeacherInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordTeacherInput.TabIndex = 10;
            // 
            // errorProviderAddTeacher
            // 
            this.errorProviderAddTeacher.ContainerControl = this;
            // 
            // btnGenerateLogPas
            // 
            this.btnGenerateLogPas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateLogPas.Location = new System.Drawing.Point(304, 241);
            this.btnGenerateLogPas.Name = "btnGenerateLogPas";
            this.btnGenerateLogPas.Size = new System.Drawing.Size(100, 35);
            this.btnGenerateLogPas.TabIndex = 12;
            this.btnGenerateLogPas.Text = "Сгенерировать \r\nлогин и пароль\r\n\r\n";
            this.btnGenerateLogPas.UseVisualStyleBackColor = true;
            this.btnGenerateLogPas.Click += new System.EventHandler(this.btnGenerateLogPas_Click);
            // 
            // BirthDateInput
            // 
            this.BirthDateInput.Location = new System.Drawing.Point(413, 130);
            this.BirthDateInput.Mask = "0000-00-00";
            this.BirthDateInput.Name = "BirthDateInput";
            this.BirthDateInput.Size = new System.Drawing.Size(100, 20);
            this.BirthDateInput.TabIndex = 21;
            this.BirthDateInput.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Дата рождения \r\nгггг-мм-дд";
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(410, 29);
            this.PhoneInput.Mask = "+70000000000";
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(100, 20);
            this.PhoneInput.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Почта";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(412, 74);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(100, 20);
            this.EmailInput.TabIndex = 24;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 309);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.PhoneInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDateInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerateLogPas);
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
        private System.Windows.Forms.Button btnGenerateLogPas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox BirthDateInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox PhoneInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailInput;
    }
}