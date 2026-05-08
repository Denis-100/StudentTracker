namespace StudentTracker.Forms
{
    partial class DelTeacherForm
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
            this.dgvTeacherDel = new System.Windows.Forms.DataGridView();
            this.btnDelTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherDel
            // 
            this.dgvTeacherDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherDel.Location = new System.Drawing.Point(12, 12);
            this.dgvTeacherDel.Name = "dgvTeacherDel";
            this.dgvTeacherDel.Size = new System.Drawing.Size(328, 264);
            this.dgvTeacherDel.TabIndex = 1;
            // 
            // btnDelTeacher
            // 
            this.btnDelTeacher.Location = new System.Drawing.Point(346, 240);
            this.btnDelTeacher.Name = "btnDelTeacher";
            this.btnDelTeacher.Size = new System.Drawing.Size(108, 36);
            this.btnDelTeacher.TabIndex = 2;
            this.btnDelTeacher.Text = "Удалить";
            this.btnDelTeacher.UseVisualStyleBackColor = true;
            this.btnDelTeacher.Click += new System.EventHandler(this.btnDelTeacher_Click);
            // 
            // DelTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 301);
            this.Controls.Add(this.btnDelTeacher);
            this.Controls.Add(this.dgvTeacherDel);
            this.Name = "DelTeacherForm";
            this.Text = "Удалить учителя";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherDel;
        private System.Windows.Forms.Button btnDelTeacher;
    }
}