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
    public partial class AddGradeTypesForm : Form
    {
        public event Action OnAddGradeTypes;
        public AddGradeTypesForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnAddGradeTypes;
        }

        public void LoadData()
        {
            dgvGradeTypesAdd.DataSource = DataBaseManager.GetAllGradeTypes();

            SetDefaultDGVSettings.Default(dgvGradeTypesAdd);
        }

        private void btnAddGradeTypes_Click(object sender, EventArgs e)
        {
            errorProviderGradeTypes.Clear();
            if (string.IsNullOrWhiteSpace(GradeTypesNameInput.Text))
            {
                errorProviderGradeTypes.SetError(GradeTypesNameInput, "Введите название типа оценки!");
                return;
            }

            bool result = DataBaseManager.AddGradeTypes(GradeTypesNameInput.Text.Trim());

            if (result)
            {
                OnAddGradeTypes?.Invoke();
                LoadData();
            }
        }
    }
}
