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
    public partial class DelSpecialtiesForm : Form
    {
        private string connectionString = DatabaseInitializer.getConnectionString();

        public DelSpecialtiesForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Загрузка данных в таблицу в форме
            dgvSpecialtiesDel.DataSource = DataBaseManager.GetAllSpecialties();
            // Авто подбор ширины слобцов
            dgvSpecialtiesDel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Режим только для чтения
            dgvSpecialtiesDel.ReadOnly = true;
            // Убирает нижнюю пустую строку
            dgvSpecialtiesDel.AllowUserToAddRows = false;
            // Выделяет всю строку сразу при нажатии на ячейку
            dgvSpecialtiesDel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnDelSpecilties_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelSpecilties(dgvSpecialtiesDel);
            if (result) LoadData();
        }
    }
}
