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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sotr = фИОTextBox.Text.Trim(); // Убираем лишние пробелы.
            if (!string.IsNullOrEmpty(sotr)) // Проверка на пустую строку
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
            dbo.Сотрудники.ФИО, 
            dbo.Поставки.Дата, 
            dbo.Поставки.[№ Поставки], 
            dbo.Товары.[Наименование товара], 
            dbo.Поставки.[Название фирмы]
            FROM 
            dbo.Поставки
            INNER JOIN 
            dbo.Товары ON dbo.Поставки.[№ Поставки] = dbo.Товары.[№ Поставки]
            INNER JOIN 
            dbo.Поставщики ON dbo.Поставки.[ID Поставщика] = dbo.Поставщики.[ID Поставщика]
            INNER JOIN 
            dbo.Сотрудники ON dbo.Поставки.[ID Сотрудника] = dbo.Сотрудники.[ID Сотрудника]
            WHERE 
            dbo.Сотрудники.[ФИО] = @sotr";

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

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dataSet1.Сотрудники);

        }
    }
}
