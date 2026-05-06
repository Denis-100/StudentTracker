namespace StudentTracker.Forms
{
    partial class DelGroupForm
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
            this.GroupListDel = new System.Windows.Forms.DataGridView();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListDel)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupListDel
            // 
            this.GroupListDel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupListDel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupListDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupListDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupListDel.Location = new System.Drawing.Point(0, 0);
            this.GroupListDel.Name = "GroupListDel";
            this.GroupListDel.RowHeadersVisible = false;
            this.GroupListDel.Size = new System.Drawing.Size(263, 206);
            this.GroupListDel.TabIndex = 4;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(269, 12);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(130, 35);
            this.btnDeleteGroup.TabIndex = 5;
            this.btnDeleteGroup.Text = "Удалить";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // DelGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 206);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.GroupListDel);
            this.Name = "DelGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DelGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.GroupListDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupListDel;
        private System.Windows.Forms.Button btnDeleteGroup;
    }
}