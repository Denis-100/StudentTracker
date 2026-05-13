namespace StudentTracker.Forms.Subject
{
    partial class SetSubjectTeacher
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
            this.SubjectsSet = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubjectsSet
            // 
            this.SubjectsSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectsSet.CheckOnClick = true;
            this.SubjectsSet.FormattingEnabled = true;
            this.SubjectsSet.Location = new System.Drawing.Point(12, 91);
            this.SubjectsSet.Name = "SubjectsSet";
            this.SubjectsSet.Size = new System.Drawing.Size(195, 169);
            this.SubjectsSet.TabIndex = 0;
            this.SubjectsSet.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SubjectsSet_ItemCheck);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предметы";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Учитель";
            // 
            // TeacherInput
            // 
            this.TeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherInput.FormattingEnabled = true;
            this.TeacherInput.Location = new System.Drawing.Point(12, 26);
            this.TeacherInput.Name = "TeacherInput";
            this.TeacherInput.Size = new System.Drawing.Size(195, 21);
            this.TeacherInput.TabIndex = 2;
            this.TeacherInput.SelectedIndexChanged += new System.EventHandler(this.TeacherInput_SelectedIndexChanged);
            // 
            // SetSubjectTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 268);
            this.Controls.Add(this.TeacherInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectsSet);
            this.Name = "SetSubjectTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настроить предметы учителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SubjectsSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TeacherInput;
    }
}