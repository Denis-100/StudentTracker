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
            toolTip1.SetToolTip(this.btnGenerateLogPas, "Логин сгенерируется из первых 3-х букв имени и фамили\n" +
                "а так же из 2-х случайных чисел.\n" +
                "Пароль сгенерируется случайно из цифр");
        }

        private void LoadData()
        {
            dgvTeacherAdd.DataSource = DataBaseManager.GetAllTeachers();

            SetDefaultDGVSettings.Default(dgvTeacherAdd);
        }

        private void btnGenerateLogPas_Click(object sender, EventArgs e)
        {
            try
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

                string surName = SurNameTeacherInput.Text.Substring(0, 3).ToLower();
                string name = NameTeacherInput.Text.Substring(0, 3).ToLower();
                Random rand = new Random();
                LoginTeacherInput.Text = $"{surName}{name}_{rand.Next(10, 100)}";

                PasswordTeacherInput.Text = $"{rand.Next(10000, 10000000)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при генерации логина и пароля: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (string.IsNullOrWhiteSpace(EmailInput.Text))
            {
                errorProviderAddTeacher.SetError(EmailInput, "Введите почту!");
                return;
            }
            if (!PhoneInput.MaskCompleted)
            {
                errorProviderAddTeacher.SetError(PhoneInput, "Введите телефон!");
                return;
            }
            if (!BirthDateInput.MaskCompleted)
            {
                errorProviderAddTeacher.SetError(BirthDateInput, "Введите дату рождения!");
                return;
            }

            bool result = DataBaseManager.AddTeacher(
                SurNameTeacherInput.Text.Trim(),
                NameTeacherInput.Text.Trim(),
                LastNameTeacherInput.Text.Trim(),
                BirthDateInput.Text.Trim(),
                PhoneInput.Text.Trim(),
                EmailInput.Text.Trim(),
                LoginTeacherInput.Text.Trim(),
                PasswordTeacherInput.Text.Trim()
                );
            if (result)
            {

                SurNameTeacherInput.Clear();
                NameTeacherInput.Clear();
                LastNameTeacherInput.Clear();
                BirthDateInput.Clear();
                PhoneInput.Clear();
                EmailInput.Clear();
                LoginTeacherInput.Clear();
                PasswordTeacherInput.Clear();


                OnAddTeacher?.Invoke();
                LoadData();
            }
        }
    }
}
