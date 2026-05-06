namespace StudentTracker
{
    partial class AddGroupForm
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
            this.GroupNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGroup = new System.Windows.Forms.Button();
            this.GroupListAdd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecialityComboBoxInput = new System.Windows.Forms.ComboBox();
            this.errorProviderAddGroup = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GroupListAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupNameInput
            // 
            this.GroupNameInput.Location = new System.Drawing.Point(304, 30);
            this.GroupNameInput.Name = "GroupNameInput";
            this.GroupNameInput.Size = new System.Drawing.Size(130, 20);
            this.GroupNameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название группы";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(304, 117);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(130, 35);
            this.btnGroup.TabIndex = 2;
            this.btnGroup.Text = "Добавить";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // GroupListAdd
            // 
            this.GroupListAdd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupListAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupListAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupListAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupListAdd.Location = new System.Drawing.Point(0, 0);
            this.GroupListAdd.Name = "GroupListAdd";
            this.GroupListAdd.RowHeadersVisible = false;
            this.GroupListAdd.Size = new System.Drawing.Size(263, 206);
            this.GroupListAdd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Направление";
            // 
            // SpecialityComboBoxInput
            // 
            this.SpecialityComboBoxInput.FormattingEnabled = true;
            this.SpecialityComboBoxInput.Location = new System.Drawing.Point(304, 77);
            this.SpecialityComboBoxInput.Name = "SpecialityComboBoxInput";
            this.SpecialityComboBoxInput.Size = new System.Drawing.Size(130, 21);
            this.SpecialityComboBoxInput.TabIndex = 7;
            // 
            // errorProviderAddGroup
            // 
            this.errorProviderAddGroup.ContainerControl = this;
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 206);
            this.Controls.Add(this.SpecialityComboBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupListAdd);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupNameInput);
            this.Name = "AddGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить группу";
            ((System.ComponentModel.ISupportInitialize)(this.GroupListAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GroupNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.DataGridView GroupListAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpecialityComboBoxInput;
        private System.Windows.Forms.ErrorProvider errorProviderAddGroup;
    }
}