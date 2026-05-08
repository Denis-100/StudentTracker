namespace StudentTracker.Forms
{
    partial class AddGradeTypesForm
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
            this.dgvGradeTypesAdd = new System.Windows.Forms.DataGridView();
            this.btnAddGradeTypes = new System.Windows.Forms.Button();
            this.GradeTypesNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderGradeTypes = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeTypesAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGradeTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGradeTypesAdd
            // 
            this.dgvGradeTypesAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradeTypesAdd.Location = new System.Drawing.Point(12, 12);
            this.dgvGradeTypesAdd.Name = "dgvGradeTypesAdd";
            this.dgvGradeTypesAdd.Size = new System.Drawing.Size(164, 237);
            this.dgvGradeTypesAdd.TabIndex = 1;
            // 
            // btnAddGradeTypes
            // 
            this.btnAddGradeTypes.Location = new System.Drawing.Point(182, 212);
            this.btnAddGradeTypes.Name = "btnAddGradeTypes";
            this.btnAddGradeTypes.Size = new System.Drawing.Size(140, 37);
            this.btnAddGradeTypes.TabIndex = 2;
            this.btnAddGradeTypes.Text = "Добавить";
            this.btnAddGradeTypes.UseVisualStyleBackColor = true;
            this.btnAddGradeTypes.Click += new System.EventHandler(this.btnAddGradeTypes_Click);
            // 
            // GradeTypesNameInput
            // 
            this.GradeTypesNameInput.Location = new System.Drawing.Point(182, 186);
            this.GradeTypesNameInput.Name = "GradeTypesNameInput";
            this.GradeTypesNameInput.Size = new System.Drawing.Size(140, 20);
            this.GradeTypesNameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // errorProviderGradeTypes
            // 
            this.errorProviderGradeTypes.ContainerControl = this;
            // 
            // AddGradeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeTypesNameInput);
            this.Controls.Add(this.btnAddGradeTypes);
            this.Controls.Add(this.dgvGradeTypesAdd);
            this.Name = "AddGradeTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тип оценки";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradeTypesAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGradeTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGradeTypesAdd;
        private System.Windows.Forms.Button btnAddGradeTypes;
        private System.Windows.Forms.TextBox GradeTypesNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderGradeTypes;
    }
}