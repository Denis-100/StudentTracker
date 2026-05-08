using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker.Services
{
    public static class SetDefaultDGVSettings
    {
        public static void Default(DataGridView dgv)
        {

            // Авто подбор ширины слобцов
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Режим только для чтения
            dgv.ReadOnly = true;
            // Убирает нижнюю пустую строку
            dgv.AllowUserToAddRows = false;
            // Выделяет всю строку сразу при нажатии на ячейку
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Запрет на изменение размеров строк и столбцов
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            // Запрет на изменение высоты заголовков
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // Скрытие пустого столбца
            dgv.RowHeadersVisible = false;
        }
    }
}
