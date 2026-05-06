namespace StudentTracker
{
    partial class AddSpecialitiesForm
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
            this.dgvSpecialtiesAdd = new System.Windows.Forms.DataGridView();
            this.SpecialtiNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSpecialies = new System.Windows.Forms.Button();
            this.errorProviderSpecilties = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialtiesAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSpecilties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecialtiesAdd
            // 
            this.dgvSpecialtiesAdd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSpecialtiesAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSpecialtiesAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialtiesAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSpecialtiesAdd.Location = new System.Drawing.Point(0, 0);
            this.dgvSpecialtiesAdd.Name = "dgvSpecialtiesAdd";
            this.dgvSpecialtiesAdd.RowHeadersVisible = false;
            this.dgvSpecialtiesAdd.Size = new System.Drawing.Size(237, 246);
            this.dgvSpecialtiesAdd.TabIndex = 0;
            // 
            // SpecialtiNameInput
            // 
            this.SpecialtiNameInput.Location = new System.Drawing.Point(246, 174);
            this.SpecialtiNameInput.Name = "SpecialtiNameInput";
            this.SpecialtiNameInput.Size = new System.Drawing.Size(117, 20);
            this.SpecialtiNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // btnAddSpecialies
            // 
            this.btnAddSpecialies.Location = new System.Drawing.Point(246, 200);
            this.btnAddSpecialies.Name = "btnAddSpecialies";
            this.btnAddSpecialies.Size = new System.Drawing.Size(117, 36);
            this.btnAddSpecialies.TabIndex = 3;
            this.btnAddSpecialies.Text = "Добавить";
            this.btnAddSpecialies.UseVisualStyleBackColor = true;
            this.btnAddSpecialies.Click += new System.EventHandler(this.btnAddSpecialies_Click);
            // 
            // errorProviderSpecilties
            // 
            this.errorProviderSpecilties.ContainerControl = this;
            // 
            // AddSpecialitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 246);
            this.Controls.Add(this.btnAddSpecialies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpecialtiNameInput);
            this.Controls.Add(this.dgvSpecialtiesAdd);
            this.Name = "AddSpecialitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить направление";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialtiesAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSpecilties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecialtiesAdd;
        private System.Windows.Forms.TextBox SpecialtiNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSpecialies;
        private System.Windows.Forms.ErrorProvider errorProviderSpecilties;
    }
}