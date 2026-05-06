using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class AddGroupForm : Form
    {
        public event Action OnGroupAdd;
        public AddGroupForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable result = DataBaseManager.GetAllGroups();
            if (result == null) return;

            DataTable dtSpecilties = DataBaseManager.GetAllSpecialties();

            SpecialityComboBoxInput.DataSource = dtSpecilties;
            SpecialityComboBoxInput.ValueMember = "Id";
            SpecialityComboBoxInput.DisplayMember = "Название";

            // Загрузка данных в таблицу в форме
            GroupListAdd.DataSource = result;
            // Авто подбор ширины слобцов
            GroupListAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Режим только для чтения
            GroupListAdd.ReadOnly = true;
            // Убирает нижнюю пустую строку
            GroupListAdd.AllowUserToAddRows = false;

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            errorProviderAddGroup.Clear();

            if (string.IsNullOrWhiteSpace(GroupNameInput.Text))
            {
                errorProviderAddGroup.SetError(GroupNameInput, "Введите название группы!");
                return;
            }
            if (SpecialityComboBoxInput.SelectedValue == null)
            {
                errorProviderAddGroup.SetError(SpecialityComboBoxInput, "Выберите направление!");
                return;
            }

            DataBaseManager.AddGroup(GroupNameInput, SpecialityComboBoxInput);
            OnGroupAdd?.Invoke();
            LoadData();
        }
    }
}
