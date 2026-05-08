using StudentTracker.Services;
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
        public event Action OnDelSpecilties;
        private string connectionString = DatabaseInitializer.getConnectionString();

        public DelSpecialtiesForm()
        {
            InitializeComponent();
            LoadData();
            this.AcceptButton = btnDelSpecilties;
        }

        private void LoadData()
        {
            dgvSpecialtiesDel.DataSource = DataBaseManager.GetAllSpecialties();

            SetDefaultDGVSettings.Default(dgvSpecialtiesDel);
        }

        private void btnDelSpecilties_Click(object sender, EventArgs e)
        {
            bool result = DataBaseManager.DelSpecilties(dgvSpecialtiesDel);

            if (result)
            {
                OnDelSpecilties?.Invoke();
                LoadData();
            }
        }
    }
}
