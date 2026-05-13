namespace StudentTracker.Forms
{
    partial class AddSubjectsForm
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
            this.dgvAddSubjects = new System.Windows.Forms.DataGridView();
            this.btnAddSubjects = new System.Windows.Forms.Button();
            this.NameSubjectsInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderSubjects = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddSubjects
            // 
            this.dgvAddSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSubjects.Location = new System.Drawing.Point(0, 0);
            this.dgvAddSubjects.Name = "dgvAddSubjects";
            this.dgvAddSubjects.Size = new System.Drawing.Size(170, 211);
            this.dgvAddSubjects.TabIndex = 0;
            // 
            // btnAddSubjects
            // 
            this.btnAddSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSubjects.Location = new System.Drawing.Point(200, 170);
            this.btnAddSubjects.Name = "btnAddSubjects";
            this.btnAddSubjects.Size = new System.Drawing.Size(106, 28);
            this.btnAddSubjects.TabIndex = 1;
            this.btnAddSubjects.Text = "Добавить";
            this.btnAddSubjects.UseVisualStyleBackColor = true;
            this.btnAddSubjects.Click += new System.EventHandler(this.btnAddSubjects_Click);
            // 
            // NameSubjectsInput
            // 
            this.NameSubjectsInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSubjectsInput.Location = new System.Drawing.Point(200, 144);
            this.NameSubjectsInput.Name = "NameSubjectsInput";
            this.NameSubjectsInput.Size = new System.Drawing.Size(106, 20);
            this.NameSubjectsInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // errorProviderSubjects
            // 
            this.errorProviderSubjects.ContainerControl = this;
            // 
            // AddSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameSubjectsInput);
            this.Controls.Add(this.btnAddSubjects);
            this.Controls.Add(this.dgvAddSubjects);
            this.Name = "AddSubjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить предмет";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddSubjects;
        private System.Windows.Forms.Button btnAddSubjects;
        private System.Windows.Forms.TextBox NameSubjectsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderSubjects;
    }
}