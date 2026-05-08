using StudentTracker.Services;
using System;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class AddSpecialitiesForm : Form
    {
        public event Action OnAddSpecialties;
        public AddSpecialitiesForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnAddSpecialies;
        }

        private void LoadData()
        {
            dgvSpecialtiesAdd.DataSource = DataBaseManager.GetAllSpecialties();
            SetDefaultDGVSettings.Default(dgvSpecialtiesAdd);
        }

        private void btnAddSpecialies_Click(object sender, EventArgs e)
        {
            errorProviderSpecilties.Clear();
            if (string.IsNullOrWhiteSpace(SpecialtiNameInput.Text))
            {
                errorProviderSpecilties.SetError(SpecialtiNameInput, "Введите название направления!");
                return;
            }
            bool result = DataBaseManager.AddSpecialties(SpecialtiNameInput);

            if (result)
            {
                OnAddSpecialties?.Invoke();
                LoadData();
            }
        }
    }
}
