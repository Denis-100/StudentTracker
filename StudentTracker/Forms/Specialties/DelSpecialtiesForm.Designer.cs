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
            this.btnDelSpecilties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialtiesDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecialtiesDel
            // 
            this.dgvSpecialtiesDel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSpecialtiesDel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSpecialtiesDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialtiesDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSpecialtiesDel.Location = new System.Drawing.Point(0, 0);
            this.dgvSpecialtiesDel.Name = "dgvSpecialtiesDel";
            this.dgvSpecialtiesDel.RowHeadersVisible = false;
            this.dgvSpecialtiesDel.Size = new System.Drawing.Size(237, 246);
            this.dgvSpecialtiesDel.TabIndex = 1;
            // 
            // btnDelSpecilties
            // 
            this.btnDelSpecilties.Location = new System.Drawing.Point(248, 198);
            this.btnDelSpecilties.Name = "btnDelSpecilties";
            this.btnDelSpecilties.Size = new System.Drawing.Size(117, 36);
            this.btnDelSpecilties.TabIndex = 2;
            this.btnDelSpecilties.Text = "Удалить";
            this.btnDelSpecilties.UseVisualStyleBackColor = true;
            this.btnDelSpecilties.Click += new System.EventHandler(this.btnDelSpecilties_Click);
            // 
            // DelSpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 246);
            this.Controls.Add(this.btnDelSpecilties);
            this.Controls.Add(this.dgvSpecialtiesDel);
            this.Name = "DelSpecialtiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить направление";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialtiesDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecialtiesDel;
        private System.Windows.Forms.Button btnDelSpecilties;
    }
}