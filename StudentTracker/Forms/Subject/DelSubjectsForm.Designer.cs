namespace StudentTracker.Forms
{
    partial class DelSubjectsForm
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
            this.dgvDelSubjects = new System.Windows.Forms.DataGridView();
            this.btnDelSubjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDelSubjects
            // 
            this.dgvDelSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelSubjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDelSubjects.Location = new System.Drawing.Point(0, 0);
            this.dgvDelSubjects.Name = "dgvDelSubjects";
            this.dgvDelSubjects.Size = new System.Drawing.Size(170, 211);
            this.dgvDelSubjects.TabIndex = 0;
            // 
            // btnDelSubjects
            // 
            this.btnDelSubjects.Location = new System.Drawing.Point(200, 170);
            this.btnDelSubjects.Name = "btnDelSubjects";
            this.btnDelSubjects.Size = new System.Drawing.Size(106, 28);
            this.btnDelSubjects.TabIndex = 1;
            this.btnDelSubjects.Text = "Удалить";
            this.btnDelSubjects.UseVisualStyleBackColor = true;
            this.btnDelSubjects.Click += new System.EventHandler(this.btnDelSubjects_Click);
            // 
            // DelSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.btnDelSubjects);
            this.Controls.Add(this.dgvDelSubjects);
            this.Name = "DelSubjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить предмет";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDelSubjects;
        private System.Windows.Forms.Button btnDelSubjects;
    }
}