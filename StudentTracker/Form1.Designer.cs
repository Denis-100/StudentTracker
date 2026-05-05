namespace StudentTracker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.пользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направленийХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.студентаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.группуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.направлениеХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.Location = new System.Drawing.Point(0, 28);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(800, 422);
            this.dgvStudents.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(698, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователейToolStripMenuItem,
            this.учителейToolStripMenuItem,
            this.направленийХToolStripMenuItem,
            this.группToolStripMenuItem,
            this.студентовToolStripMenuItem,
            this.предметовToolStripMenuItem,
            this.оценокToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton3.Text = "Таблица";
            // 
            // пользователейToolStripMenuItem
            // 
            this.пользователейToolStripMenuItem.Name = "пользователейToolStripMenuItem";
            this.пользователейToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пользователейToolStripMenuItem.Text = "Пользователей (Х)";
            // 
            // направленийХToolStripMenuItem
            // 
            this.направленийХToolStripMenuItem.Name = "направленийХToolStripMenuItem";
            this.направленийХToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.направленийХToolStripMenuItem.Text = "Направлений (Х)";
            // 
            // группToolStripMenuItem
            // 
            this.группToolStripMenuItem.Name = "группToolStripMenuItem";
            this.группToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.группToolStripMenuItem.Text = "Групп (Х)";
            // 
            // студентовToolStripMenuItem
            // 
            this.студентовToolStripMenuItem.Name = "студентовToolStripMenuItem";
            this.студентовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентовToolStripMenuItem.Text = "Студентов (Х)";
            // 
            // предметовToolStripMenuItem
            // 
            this.предметовToolStripMenuItem.Name = "предметовToolStripMenuItem";
            this.предметовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.предметовToolStripMenuItem.Text = "Предметов (Х)";
            // 
            // оценокToolStripMenuItem
            // 
            this.оценокToolStripMenuItem.Name = "оценокToolStripMenuItem";
            this.оценокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оценокToolStripMenuItem.Text = "Оценок (Х)";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группаToolStripMenuItem,
            this.учителяToolStripMenuItem,
            this.студентаToolStripMenuItem,
            this.оценкуToolStripMenuItem,
            this.направлениеХToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton1.Text = "Добавить";
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.группаToolStripMenuItem.Text = "Группу";
            this.группаToolStripMenuItem.Click += new System.EventHandler(this.группаToolStripMenuItem_Click);
            // 
            // учителяToolStripMenuItem
            // 
            this.учителяToolStripMenuItem.Name = "учителяToolStripMenuItem";
            this.учителяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.учителяToolStripMenuItem.Text = "Учителя ()";
            // 
            // студентаToolStripMenuItem
            // 
            this.студентаToolStripMenuItem.Name = "студентаToolStripMenuItem";
            this.студентаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентаToolStripMenuItem.Text = "Студента";
            this.студентаToolStripMenuItem.Click += new System.EventHandler(this.студентаToolStripMenuItem_Click);
            // 
            // оценкуToolStripMenuItem
            // 
            this.оценкуToolStripMenuItem.Name = "оценкуToolStripMenuItem";
            this.оценкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оценкуToolStripMenuItem.Text = "Оценку (Х)";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентаToolStripMenuItem1,
            this.группуToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(64, 22);
            this.toolStripDropDownButton2.Text = "Удалить";
            // 
            // студентаToolStripMenuItem1
            // 
            this.студентаToolStripMenuItem1.Name = "студентаToolStripMenuItem1";
            this.студентаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.студентаToolStripMenuItem1.Text = "Студента (Х)";
            // 
            // группуToolStripMenuItem
            // 
            this.группуToolStripMenuItem.Name = "группуToolStripMenuItem";
            this.группуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.группуToolStripMenuItem.Text = "Группу (Х)";
            // 
            // учителейToolStripMenuItem
            // 
            this.учителейToolStripMenuItem.Name = "учителейToolStripMenuItem";
            this.учителейToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.учителейToolStripMenuItem.Text = "Учителей (Х)";
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(86, 22);
            this.toolStripDropDownButton4.Text = "Сортировка";
            // 
            // направлениеХToolStripMenuItem
            // 
            this.направлениеХToolStripMenuItem.Name = "направлениеХToolStripMenuItem";
            this.направлениеХToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.направлениеХToolStripMenuItem.Text = "Направление (Х)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет оценок";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem студентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem группуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem пользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направленийХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направлениеХToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
    }
}

