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
    public partial class DelGradeTypesForm : Form
    {
        public event Action OnDelGradeTypes;
        public DelGradeTypesForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvGradeTypesDel.DataSource = DataBaseManager.GetAllGradeTypes();

            SetDefaultDGVSettings.Default(dgvGradeTypesDel);
        }

        private void btnDelGradeTypes_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelGradeTypes(dgvGradeTypesDel);

            if (result)
            {
                LoadData();
                OnDelGradeTypes?.Invoke();
            }
        }
    }
}
