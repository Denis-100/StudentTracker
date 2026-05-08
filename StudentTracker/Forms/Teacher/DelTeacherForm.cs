using StudentTracker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker.Forms
{
    public partial class DelTeacherForm : Form
    {
        public event Action OnDelTeacher;
        public DelTeacherForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnDelTeacher;
        }

        private void LoadData()
        {
            dgvTeacherDel.DataSource = DataBaseManager.GetAllTeachers();

            SetDefaultDGVSettings.Default(dgvTeacherDel);
        }

        private void btnDelTeacher_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelTeacher(dgvTeacherDel);
            if (result)
            {
                LoadData();
                OnDelTeacher?.Invoke();
            }
        }
    }
}
