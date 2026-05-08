namespace StudentTracker.Forms
{
    partial class DelGradeTypesForm
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
            this.dgvGradeTypesDel = new System.Windows.Forms.DataGridView();
            this.btnDelGradeTypes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeTypesDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradeTypesDel
            // 
            this.dgvGradeTypesDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeTypesDel.Location = new System.Drawing.Point(12, 12);
            this.dgvGradeTypesDel.Name = "dgvGradeTypesDel";
            this.dgvGradeTypesDel.Size = new System.Drawing.Size(164, 237);
            this.dgvGradeTypesDel.TabIndex = 0;
            // 
            // btnDelGradeTypes
            // 
            this.btnDelGradeTypes.Location = new System.Drawing.Point(182, 212);
            this.btnDelGradeTypes.Name = "btnDelGradeTypes";
            this.btnDelGradeTypes.Size = new System.Drawing.Size(140, 37);
            this.btnDelGradeTypes.TabIndex = 3;
            this.btnDelGradeTypes.Text = "Удалить";
            this.btnDelGradeTypes.UseVisualStyleBackColor = true;
            this.btnDelGradeTypes.Click += new System.EventHandler(this.btnDelGradeTypes_Click);
            // 
            // DelGradeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnDelGradeTypes);
            this.Controls.Add(this.dgvGradeTypesDel);
            this.Name = "DelGradeTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить тип оценки";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeTypesDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradeTypesDel;
        private System.Windows.Forms.Button btnDelGradeTypes;
    }
}