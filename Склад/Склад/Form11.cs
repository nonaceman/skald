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

namespace Склад
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.dataSet1.Поставщики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sotr = фИО_ПроизводителяTextBox.Text.Trim(); 
            if (!string.IsNullOrEmpty(sotr)) 
            {
                FetchAppointments(sotr);
            }
            else
            {
                MessageBox.Show("Введите корректную Фамилию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FetchAppointments(string sotr)
        {
            string connectionString = "Data Source=02-server;Initial Catalog=Иващенко продуктовый склад;Integrated Security=True;";
            string query = @"
            SELECT 
            dbo.Поставщики.[ФИО Производителя], 
            dbo.Поставщики.[Название фирмы], 
            dbo.Товары.[Наименование товара], 
            dbo.Поставки.[Количество товара, шт.], 
            dbo.Поставки.Дата 
            FROM 
            dbo.Поставщики
            INNER JOIN 
            dbo.Поставки ON dbo.Поставщики.[ID Поставщика] = dbo.Поставки.[ID Поставщика]     
            INNER JOIN 
            dbo.Товары ON dbo.Поставки.[№ Поставки] = dbo.Товары.[№ Поставки]
            WHERE 
            dbo.Поставщики.[ФИО Производителя] = @sotr";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sotr", sotr);
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Записи не найдены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
