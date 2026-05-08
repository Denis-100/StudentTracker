using System;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class AddSpecialitiesForm : Form
    {
        public AddSpecialitiesForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Загрузка данных в таблицу в форме
            dgvSpecialtiesAdd.DataSource = DataBaseManager.GetAllSpecialties();
            // Авто подбор ширины слобцов
            dgvSpecialtiesAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Режим только для чтения
            dgvSpecialtiesAdd.ReadOnly = true;
            // Убирает нижнюю пустую строку
            dgvSpecialtiesAdd.AllowUserToAddRows = false;
            // Выделяет всю строку сразу при нажатии на ячейку
            dgvSpecialtiesAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

            if (result) LoadData();
        }
    }
}
