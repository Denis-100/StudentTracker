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
    public partial class DelSubjectsForm : Form
    {
        public event Action OnDelSubjects;

        public DelSubjectsForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnDelSubjects;
        }

        private void LoadData()
        {
            dgvDelSubjects.DataSource = DataBaseManager.GetAllSubjects();
            SetDefaultDGVSettings.Default(dgvDelSubjects);
        }

        private void btnDelSubjects_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelSubjects(dgvDelSubjects);

            if (result)
            {
                OnDelSubjects?.Invoke();
                LoadData();
            }
        }
    }
}
