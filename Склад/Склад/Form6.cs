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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


            string connectionString = "Data Source=02-server;Initial Catalog=Иващенко продуктовый склад;Integrated Security=True;";
            string query = @"SELECT dbo.Товары.[Наименование товара], dbo.Товары.[Количество, шт.], dbo.[Местоположение товара].[№ Стелажа], dbo.[Местоположение товара].[№ Полки], dbo.[Местоположение товара].[Холоднй цех]
            FROM dbo.Товары
            INNER JOIN dbo.[Местоположение товара] ON dbo.Товары.[№] = dbo.[Местоположение товара].[№]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {


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
        