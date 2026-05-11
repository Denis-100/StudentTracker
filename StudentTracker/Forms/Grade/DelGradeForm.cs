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

namespace StudentTracker.Forms.Grade
{
    public partial class DelGradeForm : Form
    {
        public event Action OnDelGrade;
        public DelGradeForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnDelGrade;
        }

        private void LoadData()
        {
            dgvGrade.DataSource = DataBaseManager.GetAllGrades();
            SetDefaultDGVSettings.Default(dgvGrade);
        }

        private void btnDelGrade_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelGrade(dgvGrade);

            if (result)
            {
                LoadData();
                OnDelGrade?.Invoke();
            }
        }
    }
}
