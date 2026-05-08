using StudentTracker.Services;
using System;
using System.Windows.Forms;

namespace StudentTracker.Forms
{
    public partial class AddSubjectsForm : Form
    {
        public event Action OnAddSubjects;
        public AddSubjectsForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnAddSubjects;
        }

        private void LoadData()
        {
            dgvAddSubjects.DataSource = DataBaseManager.GetAllSubjects();
            SetDefaultDGVSettings.Default(dgvAddSubjects);
        }

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
            errorProviderSubjects.Clear();

            if (string.IsNullOrWhiteSpace(NameSubjectsInput.Text))
            {
                errorProviderSubjects.SetError(NameSubjectsInput, "Введите название!");
                return;
            }

            string name = NameSubjectsInput.Text.Trim();
            bool result = DataBaseManager.AddSubjects(name);

            if (result)
            {
                OnAddSubjects?.Invoke();
                LoadData();
            }
        }
    }
}
