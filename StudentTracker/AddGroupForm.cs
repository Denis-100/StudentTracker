using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class AddGroupForm : Form
    {
        public event Action OnGroupChange;
        private string connectionString = DatabaseInitializer.getConnectionString();
        public AddGroupForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable result = DataBaseManager.GetAllGroups();
                if (result == null) return;

                DataTable dtSpecilties = DataBaseManager.GetAllSpecialties();

                SpecialityComboBoxInput.DataSource = dtSpecilties;
                SpecialityComboBoxInput.DisplayMember = "Name";
                SpecialityComboBoxInput.ValueMember = "Id";

                // Загрузка данных в таблицу в форме
                GroupList.DataSource = result;
                // Авто подбор ширины слобцов
                GroupList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                // Режим только для чтения
                GroupList.ReadOnly = true;
                // Убирает нижнюю пустую строку
                GroupList.AllowUserToAddRows = false;

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
            OnGroupChange?.Invoke();
            LoadData();
        }


        // Удалить от сюда, будет отдельная форма для удаления
        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (GroupList.CurrentRow == null) return;

            int groupId = Convert.ToInt32(GroupList.CurrentRow.Cells["Id"].Value);
            string groupName = GroupList.CurrentRow.Cells["Название"].Value.ToString();

            var confirm = MessageBox.Show($"Удалить группу: '{groupName}'?\nВсе студенты этой группы так же удаляться.", 
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE Groups WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Id", groupId);
                        command.ExecuteNonQuery();
                        OnGroupChange?.Invoke();
                        LoadData();
                    }
                }
            }
        }
    }
}
