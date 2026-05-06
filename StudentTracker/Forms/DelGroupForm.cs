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
        }

        private void LoadData()
        {
            DataTable result = DataBaseManager.GetAllGroups();
            if (result == null) return;

            DataTable dtSpecilties = DataBaseManager.GetAllSpecialties();
            
            // Загрузка данных в таблицу в форме
            GroupListDel.DataSource = result;
            // Авто подбор ширины слобцов
            GroupListDel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Режим только для чтения
            GroupListDel.ReadOnly = true;
            // Убирает нижнюю пустую строку
            GroupListDel.AllowUserToAddRows = false;
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
