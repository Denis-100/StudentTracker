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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.пользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направленийХToolStripMenuItem_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.группToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типовОценокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.направлениеХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типОценкиХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.направлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учителяХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.предметХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкуХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типОценкиХToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMain.Location = new System.Drawing.Point(0, 28);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(800, 422);
            this.dgvMain.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refresh,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_refresh
            // 
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(65, 22);
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователейToolStripMenuItem,
            this.учителейToolStripMenuItem,
            this.направленийХToolStripMenuItem_Click,
            this.группToolStripMenuItem,
            this.студентовToolStripMenuItem,
            this.предметовToolStripMenuItem,
            this.оценокToolStripMenuItem,
            this.типовОценокToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton3.Text = "Таблица";
            // 
            // пользователейToolStripMenuItem
            // 
            this.пользователейToolStripMenuItem.Name = "пользователейToolStripMenuItem";
            this.пользователейToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.пользователейToolStripMenuItem.Text = "Пользователей";
            this.пользователейToolStripMenuItem.Click += new System.EventHandler(this.пользователейToolStripMenuItem_Click);
            // 
            // учителейToolStripMenuItem
            // 
            this.учителейToolStripMenuItem.Name = "учителейToolStripMenuItem";
            this.учителейToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.учителейToolStripMenuItem.Text = "Учителей";
            this.учителейToolStripMenuItem.Click += new System.EventHandler(this.учителейToolStripMenuItem_Click);
            // 
            // направленийХToolStripMenuItem_Click
            // 
            this.направленийХToolStripMenuItem_Click.Name = "направленийХToolStripMenuItem_Click";
            this.направленийХToolStripMenuItem_Click.Size = new System.Drawing.Size(158, 22);
            this.направленийХToolStripMenuItem_Click.Text = "Направлений";
            this.направленийХToolStripMenuItem_Click.Click += new System.EventHandler(this.направленийХToolStripMenuItem_Click_Click);
            // 
            // группToolStripMenuItem
            // 
            this.группToolStripMenuItem.Name = "группToolStripMenuItem";
            this.группToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.группToolStripMenuItem.Text = "Групп";
            this.группToolStripMenuItem.Click += new System.EventHandler(this.группToolStripMenuItem_Click);
            // 
            // студентовToolStripMenuItem
            // 
            this.студентовToolStripMenuItem.Name = "студентовToolStripMenuItem";
            this.студентовToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.студентовToolStripMenuItem.Text = "Студентов";
            this.студентовToolStripMenuItem.Click += new System.EventHandler(this.студентовToolStripMenuItem_Click);
            // 
            // предметовToolStripMenuItem
            // 
            this.предметовToolStripMenuItem.Name = "предметовToolStripMenuItem";
            this.предметовToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.предметовToolStripMenuItem.Text = "Предметов";
            this.предметовToolStripMenuItem.Click += new System.EventHandler(this.предметовToolStripMenuItem_Click);
            // 
            // оценокToolStripMenuItem
            // 
            this.оценокToolStripMenuItem.Name = "оценокToolStripMenuItem";
            this.оценокToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оценокToolStripMenuItem.Text = "Оценок";
            this.оценокToolStripMenuItem.Click += new System.EventHandler(this.оценокToolStripMenuItem_Click);
            // 
            // типовОценокToolStripMenuItem
            // 
            this.типовОценокToolStripMenuItem.Name = "типовОценокToolStripMenuItem";
            this.типовОценокToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.типовОценокToolStripMenuItem.Text = "Типов оценок";
            this.типовОценокToolStripMenuItem.Click += new System.EventHandler(this.типовОценокToolStripMenuItem_Click);
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
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.направлениеХToolStripMenuItem,
            this.группаToolStripMenuItem,
            this.учителяToolStripMenuItem,
            this.студентаToolStripMenuItem,
            this.предметToolStripMenuItem,
            this.оценкуToolStripMenuItem,
            this.типОценкиХToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton1.Text = "Добавить";
            // 
            // направлениеХToolStripMenuItem
            // 
            this.направлениеХToolStripMenuItem.Name = "направлениеХToolStripMenuItem";
            this.направлениеХToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.направлениеХToolStripMenuItem.Text = "Направление";
            this.направлениеХToolStripMenuItem.Click += new System.EventHandler(this.направлениеХToolStripMenuItem_Click);
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
            this.учителяToolStripMenuItem.Text = "Учителя";
            this.учителяToolStripMenuItem.Click += new System.EventHandler(this.учителяToolStripMenuItem_Click);
            // 
            // студентаToolStripMenuItem
            // 
            this.студентаToolStripMenuItem.Name = "студентаToolStripMenuItem";
            this.студентаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентаToolStripMenuItem.Text = "Студента";
            this.студентаToolStripMenuItem.Click += new System.EventHandler(this.студентаToolStripMenuItem_Click);
            // 
            // предметToolStripMenuItem
            // 
            this.предметToolStripMenuItem.Name = "предметToolStripMenuItem";
            this.предметToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.предметToolStripMenuItem.Text = "Предмет";
            this.предметToolStripMenuItem.Click += new System.EventHandler(this.предметToolStripMenuItem_Click);
            // 
            // оценкуToolStripMenuItem
            // 
            this.оценкуToolStripMenuItem.Name = "оценкуToolStripMenuItem";
            this.оценкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оценкуToolStripMenuItem.Text = "Оценку (Х)";
            // 
            // типОценкиХToolStripMenuItem
            // 
            this.типОценкиХToolStripMenuItem.Name = "типОценкиХToolStripMenuItem";
            this.типОценкиХToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.типОценкиХToolStripMenuItem.Text = "Тип оценки";
            this.типОценкиХToolStripMenuItem.Click += new System.EventHandler(this.типОценкиХToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.направлениеToolStripMenuItem,
            this.группуToolStripMenuItem,
            this.учителяХToolStripMenuItem,
            this.студентаToolStripMenuItem1,
            this.предметХToolStripMenuItem,
            this.оценкуХToolStripMenuItem,
            this.типОценкиХToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(64, 22);
            this.toolStripDropDownButton2.Text = "Удалить";
            // 
            // направлениеToolStripMenuItem
            // 
            this.направлениеToolStripMenuItem.Name = "направлениеToolStripMenuItem";
            this.направлениеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.направлениеToolStripMenuItem.Text = "Направление";
            this.направлениеToolStripMenuItem.Click += new System.EventHandler(this.направлениеToolStripMenuItem_Click);
            // 
            // группуToolStripMenuItem
            // 
            this.группуToolStripMenuItem.Name = "группуToolStripMenuItem";
            this.группуToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.группуToolStripMenuItem.Text = "Группу";
            this.группуToolStripMenuItem.Click += new System.EventHandler(this.группуToolStripMenuItem_Click);
            // 
            // учителяХToolStripMenuItem
            // 
            this.учителяХToolStripMenuItem.Name = "учителяХToolStripMenuItem";
            this.учителяХToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.учителяХToolStripMenuItem.Text = "Учителя";
            this.учителяХToolStripMenuItem.Click += new System.EventHandler(this.учителяХToolStripMenuItem_Click);
            // 
            // студентаToolStripMenuItem1
            // 
            this.студентаToolStripMenuItem1.Name = "студентаToolStripMenuItem1";
            this.студентаToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.студентаToolStripMenuItem1.Text = "Студента";
            this.студентаToolStripMenuItem1.Click += new System.EventHandler(this.студентаToolStripMenuItem1_Click);
            // 
            // предметХToolStripMenuItem
            // 
            this.предметХToolStripMenuItem.Name = "предметХToolStripMenuItem";
            this.предметХToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.предметХToolStripMenuItem.Text = "Предмет";
            this.предметХToolStripMenuItem.Click += new System.EventHandler(this.предметХToolStripMenuItem_Click);
            // 
            // оценкуХToolStripMenuItem
            // 
            this.оценкуХToolStripMenuItem.Name = "оценкуХToolStripMenuItem";
            this.оценкуХToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.оценкуХToolStripMenuItem.Text = "Оценку (Х)";
            // 
            // типОценкиХToolStripMenuItem1
            // 
            this.типОценкиХToolStripMenuItem1.Name = "типОценкиХToolStripMenuItem1";
            this.типОценкиХToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.типОценкиХToolStripMenuItem1.Text = "Тип оценки";
            this.типОценкиХToolStripMenuItem1.Click += new System.EventHandler(this.типОценкиХToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет оценок";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem студентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem группуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem пользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направленийХToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem группToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направлениеХToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.ToolStripMenuItem направлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типовОценокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типОценкиХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учителяХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкуХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типОценкиХToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметХToolStripMenuItem;
    }
}

