using StudentTracker.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentTracker.Forms
{
    public partial class DelGroupForm : Form
    {
        public event Action OnGroupDel;
        public DelGroupForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnDeleteGroup;
        }

        private void LoadData()
        {
            GroupListDel.DataSource = DataBaseManager.GetAllGroups();

            DataTable dtSpecilties = DataBaseManager.GetAllSpecialties();

            SetDefaultDGVSettings.Default(GroupListDel);
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelGroup(GroupListDel);

            if (result)
            {
                OnGroupDel?.Invoke();
                LoadData();
            }
        }
    }
}
