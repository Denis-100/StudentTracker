namespace StudentTracker.Forms
{
    partial class DelStudentForm
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
            this.dgvStudentDel = new System.Windows.Forms.DataGridView();
            this.btnDelStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentDel
            // 
            this.dgvStudentDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvStudentDel.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStudentDel.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentDel.Name = "dgvStudentDel";
            this.dgvStudentDel.RowHeadersVisible = false;
            this.dgvStudentDel.Size = new System.Drawing.Size(777, 450);
            this.dgvStudentDel.TabIndex = 4;
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.Location = new System.Drawing.Point(783, 12);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(106, 53);
            this.btnDelStudent.TabIndex = 9;
            this.btnDelStudent.Text = "Удалить";
            this.btnDelStudent.UseVisualStyleBackColor = true;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // DelStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.btnDelStudent);
            this.Controls.Add(this.dgvStudentDel);
            this.Name = "DelStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить студента";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentDel;
        private System.Windows.Forms.Button btnDelStudent;
    }
}