﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void категорииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.категорииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.dataSet1.Категории);

        }
    }
}
