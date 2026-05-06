namespace StudentTracker
{
    partial class DelSpecialtiesForm
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
            this.dgvSpecialtiesDel = new System.Windows.Forms.DataGridView();
            this.btnDelSpeciltiesForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialtiesDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecialtiesDel
            // 
            this.dgvSpecialtiesDel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSpecialtiesDel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSpecialtiesDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialtiesDel.Location = new System.Drawing.Point(12, 12);
            this.dgvSpecialtiesDel.Name = "dgvSpecialtiesDel";
            this.dgvSpecialtiesDel.RowHeadersVisible = false;
            this.dgvSpecialtiesDel.Size = new System.Drawing.Size(195, 150);
            this.dgvSpecialtiesDel.TabIndex = 1;
            // 
            // btnDelSpeciltiesForm
            // 
            this.btnDelSpeciltiesForm.Location = new System.Drawing.Point(213, 139);
            this.btnDelSpeciltiesForm.Name = "btnDelSpeciltiesForm";
            this.btnDelSpeciltiesForm.Size = new System.Drawing.Size(75, 23);
            this.btnDelSpeciltiesForm.TabIndex = 2;
            this.btnDelSpeciltiesForm.Text = "Удалить";
            this.btnDelSpeciltiesForm.UseVisualStyleBackColor = true;
            this.btnDelSpeciltiesForm.Click += new System.EventHandler(this.btnDelSpecilties_Click);
            // 
            // DelSpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 249);
            this.Controls.Add(this.btnDelSpeciltiesForm);
            this.Controls.Add(this.dgvSpecialtiesDel);
            this.Name = "DelSpecialtiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить направление";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialtiesDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecialtiesDel;
        private System.Windows.Forms.Button btnDelSpeciltiesForm;
    }
}