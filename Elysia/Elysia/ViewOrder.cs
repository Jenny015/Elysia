using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewOrder : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        private Filter filter;
        public ViewOrder()
        {
            InitializeComponent();
            reloadDataGridView("");
            setDataGridView();
            dataGridVieworder.ReadOnly = true;
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Cancel";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Cancel";
            buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

            // Add the button column to the DataGridView
            dataGridVieworder.Columns.Add(buttonColumn);
        }
        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `order` ORDER BY orderDate DESC" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridVieworder.DataSource = ds.Tables[0];

                }
            }
        }
        private void dataGridVieworder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dataGridVieworder.Columns["buttonColumn"].Index && e.RowIndex >= 0)
                {

                    DataGridViewRow row = dataGridVieworder.Rows[e.RowIndex];
                    String orderID = row.Cells["orderID"].Value.ToString();
                    String orderStatus = row.Cells["orderStatus"].Value.ToString();


                    // Check if the 'orderStatus' data is  null
                    if (orderStatus != "Processing" && orderStatus != "OStanding")
                    {
                        // Perform the action you want to take when the button is clicked
                        MessageBox.Show("This order status cannot be changed.");
                        return;

                    }
                    else
                    {
                        cmd.CommandText = "UPDATE `order` SET orderStatus = 'Cancelled' WHERE orderID = @orderID";
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        try
                        {
                            // Execute the SQl statement
                            cmd.ExecuteNonQuery();
                            reloadDataGridView("");
                            MessageBox.Show($"Order: {orderID} has been cancelled.");
                            return;

                        }
                        catch (Exception ex)
                        {
                            // if error occurs, show fail message
                            MessageBox.Show("Failed" + ex.Message);
                        }
                    }

                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("Order");
            filter.Query += filter_Query;
            filter.Show();
        }

        private void filter_Query(object sender, EventArgs e)
        {
            string query = filter.queryString;
            reloadDataGridView(query);
        }
    }
}




