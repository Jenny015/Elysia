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
            DataGridViewButtonColumn detailBtn = new DataGridViewButtonColumn();
            detailBtn.HeaderText = "Detail";
            detailBtn.Name = "detailBtn";
            detailBtn.Text = "Detail";
            detailBtn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGridVieworder.Columns.Add(detailBtn);


            DataGridViewButtonColumn cancelBtn = new DataGridViewButtonColumn();
            cancelBtn.HeaderText = "Cancel";
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Text = "Cancel";
            cancelBtn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGridVieworder.Columns.Add(cancelBtn);

        }
        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `order` ORDER BY orderDate DESC, orderID DESC" : query;

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
                if (e.ColumnIndex == dataGridVieworder.Columns["cancelBtn"].Index && e.RowIndex >= 0)
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
                        cmd.CommandText = @"UPDATE `order` SET orderStatus = 'Cancelled' WHERE orderID = @orderID;" +
                            @"UPDATE `orderpart` SET opStatus = 'Cancelled' WHERE orderID = @orderID";
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
                else if (e.ColumnIndex == dataGridVieworder.Columns["detailBtn"].Index && e.RowIndex >= 0)
                {
                    viewOrderDetail(dataGridVieworder.Rows[e.RowIndex].Cells["orderID"].Value.ToString());
                }
            }
        }
        private void viewOrderDetail(String orderID)
        {
            heading.Visible = true;
            InvPreview.Visible = true;
            btnBack.Visible = true;
            btnFilter.Visible = false;
            dataGridVieworder.Visible = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT O.orderDate, D.dCompany, D.dName, D.dPhone, D.dComAdd, D.dDelivAdd FROM `order` O, `orderpart` OP, dealer D, part P WHERE O.orderID = OP.orderID AND O.dealerID = D.dealerID AND P.partID = OP.partID AND O.orderID = '{orderID}';";
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblOrderDate.Text = reader.GetDateTime(0).ToString("d");
                            lblDCom.Text = reader.GetString(1);
                            lblDName.Text = reader.GetString(2);
                            lblDPhone.Text = reader.GetString(3);
                            lblAddr.Text = reader.GetString(5) != "" ? reader.GetString(5) : reader.GetString(4);
                        }
                    }

                    String query = $"SELECT OP.partID AS `Part ID`, P.partName AS `Part Name`, OP.orderQty AS `Order Quantity`, OP.OSQty AS `Previous Order Quantity`, OP.actDespQty AS `Despatch Quantity` FROM orderpart OP, part P WHERE OP.partID = P.partID AND OP.orderID = '{orderID}';";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgv.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex.Message);
                }

            }
            lblOrderID.Text = orderID;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            heading.Visible = false;
            InvPreview.Visible = false;
            btnBack.Visible = false;
            btnFilter.Visible = true;
            dataGridVieworder.Visible = true;
        }
    }
}




