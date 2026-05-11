namespace StudentTracker.Forms.Profiles
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordInput2 = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProviderChangePassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый пароль";
            // 
            // PasswordInput1
            // 
            this.PasswordInput1.Location = new System.Drawing.Point(16, 29);
            this.PasswordInput1.Name = "PasswordInput1";
            this.PasswordInput1.Size = new System.Drawing.Size(112, 20);
            this.PasswordInput1.TabIndex = 1;
            this.PasswordInput1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подтвердите пароль";
            // 
            // PasswordInput2
            // 
            this.PasswordInput2.Location = new System.Drawing.Point(16, 73);
            this.PasswordInput2.Name = "PasswordInput2";
            this.PasswordInput2.Size = new System.Drawing.Size(112, 20);
            this.PasswordInput2.TabIndex = 3;
            this.PasswordInput2.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowPassword.BackgroundImage = global::StudentTracker.Properties.Resources.eye_14618401;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowPassword.Location = new System.Drawing.Point(137, 45);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(35, 35);
            this.btnShowPassword.TabIndex = 6;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProviderChangePassword
            // 
            this.errorProviderChangePassword.ContainerControl = this;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 169);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.PasswordInput2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordInput1);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordInput2;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProviderChangePassword;
    }
}