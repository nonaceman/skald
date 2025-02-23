using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Склад
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void местоположение_товараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.местоположение_товараBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Местоположение_товара". При необходимости она может быть перемещена или удалена.
            this.местоположение_товараTableAdapter.Fill(this.dataSet1.Местоположение_товара);

        }
    }
}
