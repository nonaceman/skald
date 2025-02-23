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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void поставкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.dataSet1.Поставки);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_dat = датаTextBox.Text;
            

            if (DateTime.TryParse(input_dat, out DateTime parsedDate))
            {
                FetchAppointments(parsedDate); 
            }
            else
            {
                MessageBox.Show("Введите корректную дату в формате YYYY-MM-DD.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FetchAppointments(DateTime date)
        {
            string connectionString = "Data Source=02-server;Initial Catalog=Иващенко продуктовый склад;Integrated Security=True;";
            string query = @"SELECT dbo.Поставки.Дата, dbo.Товары.[Наименование товара], dbo.Поставки.[Количество товара, шт.], dbo.Сотрудники.ФИО
            FROM dbo.Поставки 
            INNER JOIN dbo.Сотрудники ON dbo.Поставки.[ID Сотрудника] = dbo.Сотрудники.[ID Сотрудника]
            INNER JOIN dbo.Поставщики ON dbo.Поставки.[ID Поставщика] = dbo.Поставщики.[ID Поставщика]
            INNER JOIN dbo.Товары ON dbo.Поставки.[№ Поставки] = dbo.Товары.[№ Поставки]
            WHERE dbo.Поставки.[Дата]=@date";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", date.Date);
                    

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
