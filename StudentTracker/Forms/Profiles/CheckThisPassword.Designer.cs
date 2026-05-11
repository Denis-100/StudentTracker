namespace StudentTracker.Forms.Profiles
{
    partial class CheckThisPassword
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
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProviderCheckPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnShowPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCheckPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текущий пароль";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(16, 30);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(131, 20);
            this.PasswordInput.TabIndex = 1;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Дальше";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProviderCheckPassword
            // 
            this.errorProviderCheckPassword.ContainerControl = this;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowPassword.BackgroundImage = global::StudentTracker.Properties.Resources.eye_14618401;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowPassword.Location = new System.Drawing.Point(153, 22);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(35, 35);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // CheckThisPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 91);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label1);
            this.Name = "CheckThisPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCheckPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProviderCheckPassword;
        private System.Windows.Forms.Button btnShowPassword;
    }
}