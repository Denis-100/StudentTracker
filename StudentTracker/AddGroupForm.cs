using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class AddGroupForm : Form
    {
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
                try
                {
                    conn.Open();
                    string sql = "SELECT Id, Name FROM Groups";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GroupList.DataSource = dt;
                    GroupList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GroupNameInput.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkGroup = "SELECT COUNT(*) FROM Groups WHERE Name = @Name";

                using (SqlCommand command = new SqlCommand(checkGroup, conn))
                {
                    command.Parameters.AddWithValue("@Name", GroupNameInput.Text.Trim());

                    if ((int)command.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Такая группа уже существует!");
                        return;
                    }
                }

                string sql = "INSERT INTO Groups (Name) VALUES (@Name)";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Name", GroupNameInput.Text.Trim());
                        command.ExecuteNonQuery();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (GroupList.CurrentRow == null) return;

            int groupId = Convert.ToInt32(GroupList.CurrentRow.Cells["Id"].Value);
            string groupName = GroupList.CurrentRow.Cells["Name"].Value.ToString();

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
                    }
                }
                LoadData();
            }
        }
    }
}
