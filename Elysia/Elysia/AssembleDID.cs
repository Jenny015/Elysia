using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class AssembleDID : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public AssembleDID()
        {
            InitializeComponent();
            reloadDataGridView("");
            setDataGridView();
            dgvDID.Columns[0].ReadOnly = true;
            dgvDID.Columns[1].ReadOnly = true;
            dgvDID.Columns[2].ReadOnly = true;
            dgvDID.Columns[4].ReadOnly = true;
            this.dgvDID.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Assemble";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Assemble";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvDID.Columns.Add(buttonColumn);
        }

        private void reloadDataGridView(String query)
        {
            if (query == "")
            {
                query = "SELECT OP.orderID, OP.partID, (OP.orderQty+OP.OSQty) AS TotalQty, actDespQty, opStatus FROM orderpart OP, `order` O WHERE opStatus = 'Processing' AND OP.orderID = O.orderID ORDER BY O.orderDate;";
            }
            else
            {
                dgvDID.Columns["buttonColumn"].Visible = false;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvDID.DataSource = ds.Tables[0];
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dgvDID.Columns["buttonColumn"].Index && e.RowIndex >= 0)
                {
                    if (dgvDID.Rows[e.RowIndex].Cells["actDespQty"].Value.ToString() == "")
                    {
                        MessageBox.Show("Actual Despecth Quantity cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataGridViewRow row = dgvDID.Rows[e.RowIndex];
                    String actDespQtyData = row.Cells["actDespQty"].Value.ToString();
                    int totalQty = int.Parse(row.Cells["TotalQty"].Value.ToString());
                    String orderID = row.Cells["orderID"].Value.ToString();
                    String partID = row.Cells["partID"].Value.ToString();
                    int partQty = 0;

                    cmd.CommandText = $"SELECT partQty FROM part WHERE partID = '{partID}'";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            partQty = reader.GetInt32(0);
                        }
                    }
                    if (partQty < int.Parse(actDespQtyData))
                    {
                        MessageBox.Show("Actual despatch quantity more than stocking.\n\nPlease check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the 'actDespQty' data is  null
                    if (actDespQtyData == "" || int.Parse(actDespQtyData) < 0)
                    {
                        MessageBox.Show("The 'actDespQty' value should be positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // if actual despatch quantity > total quantity, set despatch quantity = total quantity
                    if (int.Parse(actDespQtyData) >= totalQty)
                    {
                        cmd.CommandText = $"UPDATE `orderpart` SET opStatus = 'Assembled', actDespQty = {totalQty} WHERE orderID = '{orderID}' AND partID = '{partID}';";
                    }
                    else
                    {
                        String osOrderID = "";
                        String dealerID = "";
                        var confirmResult = MessageBox.Show("Actual Despatch quantity not euqal to order quantity\nAre you sure to continue?", "Please confirm the quantity!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        // If actual despatch qty < order qty, generate outstanding order, and oustanding orderpart
                        if (confirmResult == DialogResult.Yes)
                        {
                            //Check if the current order has an outstanding order
                            cmd.CommandText = $"SELECT orderID, dealerID FROM `order` WHERE fromOrder = '{orderID}' AND orderStatus = 'OStanding'";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                // If there's no outstanding order, create one
                                if (!reader.Read())
                                {
                                    reader.Close();
                                    //get dealerID of the current order
                                    cmd.CommandText = $"SELECT dealerID FROM `order` WHERE orderID = '{orderID}'";
                                    try
                                    {
                                        using (MySqlDataReader reader2 = cmd.ExecuteReader())
                                        {
                                            if (reader2.Read())
                                            {
                                                dealerID = reader2.GetString(0).ToString();
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        // Handle any errors that occurred
                                        Console.WriteLine(ex.Message);
                                    }
                                    //create a new outstanding order
                                    osOrderID = NewOrder.getOrderID('O');
                                    cmd.CommandText = $"INSERT INTO `order` (orderID, dealerID, orderStatus, fromOrder) VALUES ('{osOrderID}', '{dealerID}', 'OStanding', '{orderID}')";
                                    // Execute the SQL statement
                                    cmd.ExecuteNonQuery();
                                }
                                else // If there has an outstanding order for this order, get the outstanding orderID
                                {
                                    osOrderID = reader.GetString(0);
                                    dealerID = reader.GetString(1);
                                    reader.Close();
                                }
                            }
                            //add new did that belongs to new OSorder, new orderQty = (currentOrderQty - currentActDespQty)
                            int osQty = totalQty - int.Parse(actDespQtyData);
                            cmd.CommandText = $"UPDATE `orderpart` SET opStatus = 'Assembled', actDespQty = {actDespQtyData} WHERE orderID = '{orderID}' AND partID = '{partID}';";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"UPDATE part SET partQty = partQty - {actDespQtyData} WHERE partID = '{partID}';";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = $"INSERT INTO orderpart (orderID, partID, orderQty, opStatus) VALUES ('{osOrderID}', '{partID}', {osQty}, 'OStanding');";
                        }
                        if (int.Parse(actDespQtyData) > 0)
                        {
                            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssff");
                            int qtyChange = -int.Parse(actDespQtyData);
                            cmd.CommandText += $"INSERT INTO log VALUES ('{timestamp}', '{StaticVariable.empID}', '{partID}', {qtyChange}, 'Despatched');";
                        }
                    }
                    try
                    {
                        // Execute the SQl statement
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Failed");
                    }
                    finally
                    {
                        StaticVariable.UpdateAllOutstandingOrders();
                        assembledOrder(orderID);
                        reloadDataGridView("");
                    }
                }
            }
        }
        private void assembledOrder(String orderID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = $"SELECT COUNT(*) FROM `orderpart` WHERE orderID = '{orderID}' AND opStatus != 'Assembled';";

                using (MySqlCommand checkStatusCmd = new MySqlCommand(query, conn))
                {
                    int nonCompliantEntries = Convert.ToInt32(checkStatusCmd.ExecuteScalar());

                    if (nonCompliantEntries == 0)
                    {
                        query = $"UPDATE `order` SET orderStatus = 'Assembled' WHERE orderID = '{orderID}'";
                        using (MySqlCommand insertCmd = new MySqlCommand(query, conn))
                        {
                            insertCmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("DID");
            filter.Query += filter_Query;
            filter.Show();
        }
        private void filter_Query(object sender, EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }
    }
}
