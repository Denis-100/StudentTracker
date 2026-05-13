namespace StudentTracker.Forms.Grade
{
    partial class DelGradeForm
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
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.btnDelGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrade
            // 
            this.dgvGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(12, 12);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.Size = new System.Drawing.Size(697, 312);
            this.dgvGrade.TabIndex = 0;
            // 
            // btnDelGrade
            // 
            this.btnDelGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelGrade.Location = new System.Drawing.Point(715, 291);
            this.btnDelGrade.Name = "btnDelGrade";
            this.btnDelGrade.Size = new System.Drawing.Size(113, 33);
            this.btnDelGrade.TabIndex = 1;
            this.btnDelGrade.Text = "Удалить";
            this.btnDelGrade.UseVisualStyleBackColor = true;
            this.btnDelGrade.Click += new System.EventHandler(this.btnDelGrade_Click);
            // 
            // DelGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 336);
            this.Controls.Add(this.btnDelGrade);
            this.Controls.Add(this.dgvGrade);
            this.Name = "DelGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить оценку";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.Button btnDelGrade;
    }
}