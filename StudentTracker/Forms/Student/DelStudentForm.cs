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
    public partial class DelStudentForm : Form
    {
        public event Action OnDelStudent; 

        public DelStudentForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnDelStudent;
        }

        private void LoadData()
        {
            dgvStudentDel.DataSource = DataBaseManager.GetAllStudents();

            SetDefaultDGVSettings.Default(dgvStudentDel);
        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelStudent(dgvStudentDel);

            if (result)
            {
                OnDelStudent?.Invoke();
                LoadData();
            }
        }
    }
}
