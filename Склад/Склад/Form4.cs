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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void поставкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.dataSet1.Поставки);

        }

        private void количество_товара__шт_Label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void количество_товара__шт_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_СотрудникаLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form7();
            ifrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form10();
            ifrm.ShowDialog();
        }
    }
}
