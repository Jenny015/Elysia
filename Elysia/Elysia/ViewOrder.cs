using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewOrder : Form
    {
        private MySqlConnection cnn = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";");

        public void ConnectToSql()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to connect MySQL\n" + ex.Message);
            }
        }

        public ViewOrder()
        {
            InitializeComponent();
            setDataGridView();
            dataGridVieworder.AllowUserToAddRows = false;
        }

        private void setDataGridView()
        {
            string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
            string query = "SELECT * FROM `order`";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridVieworder.DataSource = ds.Tables[0];
                    dataGridVieworder.Columns[0].ReadOnly = true;
                    dataGridVieworder.Columns[1].ReadOnly = true;
                    dataGridVieworder.Columns[4].ReadOnly = true;

                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
            string query = "UPDATE order SET orderStatus = @orderStatus  WHERE orderID=@orderID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@orderID", "N000000004");
                    command.Parameters.AddWithValue("@orderStatus", "Cancelled");
                    command.Parameters.AddWithValue("@phone", "555-1234");

                    command.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        private void btnNewOrder_CheckedChanged(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.Show();
            this.Close();
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}

