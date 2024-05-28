using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elysia
{
    public partial class ViewDID : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewDID()
        {
            InitializeComponent();
            setDataGridView();
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            btnDID.Checked = true;
            dataGridView1.AllowUserToAddRows = false;

        }
        private void setDataGridView()
        {
            reloadDataGridView();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Assemble";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Assemble";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGridView1.Columns.Add(buttonColumn);
        }

        private void reloadDataGridView()
        {
            string query = "SELECT * FROM orderpart WHERE opStatus = 'Processing'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[2].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    dataGridView1.Columns[5].ReadOnly = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dataGridView1.Columns["buttonColumn"].Index && e.RowIndex >= 0)
                {

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    String actDespQtyData = row.Cells["actDespQty"].Value.ToString();
                    String orderQtyData = row.Cells["orderQty"].Value.ToString();
                    String orderID = row.Cells["orderID"].Value.ToString();
                    String partID = row.Cells["partID"].Value.ToString();


                    // Check if the 'actDespQty' data is  null
                    if (actDespQtyData == "")
                    {
                        MessageBox.Show("The 'actDespQty' value is NULL.");
                        return;

                    }
                    else if (int.Parse(actDespQtyData) < 0)
                    {
                        MessageBox.Show("The 'actDespQty' value must be positive integer.");
                        return;
                    }
                    else if (int.Parse(actDespQtyData) >= int.Parse(orderQtyData))
                    {
                        cmd.CommandText = $"UPDATE `orderpart` SET opStatus = 'Assembled', actDespQty = {orderQtyData} WHERE orderID = \'{orderID}\' AND partID = \'{partID}\'";
                        try
                        {
                            // Execute the SQl statement
                            cmd.ExecuteNonQuery();
                            reloadDataGridView();
                            return;

                        }
                        catch (Exception ex)
                        {
                            // if error occurs, show fail message
                            MessageBox.Show("Failed"+ex.Message);
                        }
                    }
                    else
                    {
                        String osOrderID = "";
                        String dealerID = "";
                        var confirmResult = MessageBox.Show("Actual Despetch quantity not euqal to order quantity\nAre you sure to continue?", "Please confirm the quantity!", MessageBoxButtons.YesNo);
                        // If actual despetch qty < order qty, generate outstanding order, and oustanding orderpart
                        if (confirmResult == DialogResult.Yes)
                        {
                            //Check if the current order has an outstanding order
                            cmd.CommandText = $"SELECT orderID, dealerID FROM `order` WHERE fromOrder = '{orderID}'";
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                // If there's no outstanding order, create one
                                if (!reader.Read())
                                {
                                    // Close the reader before executing another command
                                    reader.Close();
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
                                    osOrderID = NewOrder.getOrderID('O');
                                    MessageBox.Show($"New orderID: {osOrderID}\ndealerID: {dealerID}\norigin orderID: {orderID}", "Error");
                                    cmd.CommandText = $"INSERT INTO `order` (orderID, dealerID, orderStatus, fromOrder) VALUES ('{osOrderID}', '{dealerID}', 'OStanding', '{orderID}')";
                                    // Execute the SQL statement
                                    cmd.ExecuteNonQuery();
                                }
                                else // If there is, get the orderID
                                {
                                    osOrderID = reader.GetString(0);
                                    reader.Close(); // Close the reader before executing another command
                                }
                            }
                            //add did orderQty - actDespQty to o order
                            /* TODO */
                            cmd.CommandText = $"UPDATE `orderpart` SET opStatus = 'Assembled', actDespQty = {actDespQtyData} WHERE orderID = '{orderID}' AND partID = '{partID}';" +
                                $"INSERT INTO orderpart (orderID, partID, orderQty, opStatus) VALUES ('{osOrderID}', '{partID}', {int.Parse(orderQtyData)-int.Parse(actDespQtyData)}, 'OStanding')";
                            try
                            {
                                // Execute the SQl statement
                                cmd.ExecuteNonQuery();
                                reloadDataGridView();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter("DID");
            filter.Show();
        }
    }
}
