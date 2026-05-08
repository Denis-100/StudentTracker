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
            this.GroupList = new System.Windows.Forms.DataGridView();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecialityComboBoxInput = new System.Windows.Forms.ComboBox();
            this.errorProviderAddGroup = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GroupList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupNameInput
            // 
            this.GroupNameInput.Location = new System.Drawing.Point(355, 49);
            this.GroupNameInput.Name = "GroupNameInput";
            this.GroupNameInput.Size = new System.Drawing.Size(100, 20);
            this.GroupNameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название группы";
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(355, 136);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(75, 23);
            this.btnGroup.TabIndex = 2;
            this.btnGroup.Text = "Добавить";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // GroupList
            // 
            this.GroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupList.Location = new System.Drawing.Point(12, 30);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(323, 150);
            this.GroupList.TabIndex = 3;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(355, 165);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGroup.TabIndex = 4;
            this.btnDeleteGroup.Text = "Удалить";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Направление";
            // 
            // SpecialityComboBoxInput
            // 
            this.SpecialityComboBoxInput.FormattingEnabled = true;
            this.SpecialityComboBoxInput.Location = new System.Drawing.Point(355, 96);
            this.SpecialityComboBoxInput.Name = "SpecialityComboBoxInput";
            this.SpecialityComboBoxInput.Size = new System.Drawing.Size(100, 21);
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
            this.ClientSize = new System.Drawing.Size(542, 206);
            this.Controls.Add(this.SpecialityComboBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupNameInput);
            this.Name = "AddGroupForm";
            this.Text = "Добавить группу";
            ((System.ComponentModel.ISupportInitialize)(this.GroupList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GroupNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.DataGridView GroupList;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpecialityComboBoxInput;
        private System.Windows.Forms.ErrorProvider errorProviderAddGroup;
    }
}