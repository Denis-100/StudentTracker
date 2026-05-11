namespace StudentTracker.Forms.Grade
{
    partial class AvgGradeForm
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
            this.dgvAvgGrade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvgGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvgGrade
            // 
            this.dgvAvgGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvgGrade.Location = new System.Drawing.Point(12, 12);
            this.dgvAvgGrade.Name = "dgvAvgGrade";
            this.dgvAvgGrade.Size = new System.Drawing.Size(252, 201);
            this.dgvAvgGrade.TabIndex = 0;
            // 
            // AvgGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 225);
            this.Controls.Add(this.dgvAvgGrade);
            this.Name = "AvgGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СР. Балл";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvgGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvgGrade;
    }
}