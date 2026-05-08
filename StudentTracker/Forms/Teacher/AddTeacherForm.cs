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
    public partial class AddTeacherForm : Form
    {
        public event Action OnAddTeacher;
        public AddTeacherForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnAddTeacher;
        }

        private void LoadData()
        {
            dgvTeacherAdd.DataSource = DataBaseManager.GetAllTeachers();

            SetDefaultDGVSettings.Default(dgvTeacherAdd);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            errorProviderAddTeacher.Clear();
            if (string.IsNullOrWhiteSpace(SurNameTeacherInput.Text))
            {
                errorProviderAddTeacher.SetError(SurNameTeacherInput, "Введите фамилию!");
                return;
            }
            if (string.IsNullOrWhiteSpace(NameTeacherInput.Text))
            {
                errorProviderAddTeacher.SetError(NameTeacherInput, "Введите имя!");
                return;
            }
            if (string.IsNullOrWhiteSpace(LastNameTeacherInput.Text))
            {
                errorProviderAddTeacher.SetError(LastNameTeacherInput, "Введите отчество!");
                return;
            }
            if (string.IsNullOrWhiteSpace(LoginTeacherInput.Text))
            {
                errorProviderAddTeacher.SetError(LoginTeacherInput, "Введите логин!");
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordTeacherInput.Text))
            {
                errorProviderAddTeacher.SetError(PasswordTeacherInput, "Введите пароль!");
                return;
            }

            bool result = DataBaseManager.AddTeacher(
                SurNameTeacherInput.Text.Trim(),
                NameTeacherInput.Text.Trim(),
                LastNameTeacherInput.Text.Trim(),
                LoginTeacherInput.Text.Trim(),
                PasswordTeacherInput.Text.Trim()
                );
            if (result)
            {

                SurNameTeacherInput.Clear();
                NameTeacherInput.Clear();
                LastNameTeacherInput.Clear();
                LoginTeacherInput.Clear();
                PasswordTeacherInput.Clear();


                OnAddTeacher?.Invoke();
                LoadData();

            }

        }
    }
}
