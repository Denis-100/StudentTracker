using StudentTracker.Services;
using System.Windows.Forms;

namespace StudentTracker.Forms.Grade
{
    public partial class AvgGradeForm : Form
    {
        public AvgGradeForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvAvgGrade.DataSource = DataBaseManager.getAvgGrades();
            SetDefaultDGVSettings.Default(dgvAvgGrade);
        }
    }
}
