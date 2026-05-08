using StudentTracker.Services;
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
            this.AcceptButton = btnGroupAdd;
        }

        private void LoadData()
        {
            try
            {
                GroupListAdd.DataSource = DataBaseManager.GetAllGroups();

                DataTable dtSpecilties = DataBaseManager.GetAllSpecialties();

                SpecialityComboBoxInput.DataSource = dtSpecilties;
                SpecialityComboBoxInput.ValueMember = "Id";
                SpecialityComboBoxInput.DisplayMember = "Название";

                SetDefaultDGVSettings.Default(GroupListAdd);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
