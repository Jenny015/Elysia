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

        }
        private void setDataGridView()
        {
            
            string query = "SELECT * FROM orderpart WHERE opStatus = 'Processing'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {

                    reloadDataGridView();
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "Assemble";
                    buttonColumn.Name = "buttonColumn";
                    buttonColumn.Text = "Assemble";
                    buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

                    // Add the button column to the DataGridView
                    dataGridView1.Columns.Add(buttonColumn);
                }
            }
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
                        // Perform the action you want to take when the button is clicked
                        MessageBox.Show("The 'actDespQty' value is NULL.");

                    }
                    else if (actDespQtyData == orderQtyData)
                    {
                        cmd.CommandText = $"UPDATE `orderpart` SET opStatus = 'Assembled', actDespQty = {actDespQtyData} WHERE orderID = \'{orderID}\' AND partID = \'{partID}\'";
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

                        var confirmResult = MessageBox.Show("Actual Despetch quantity not euqal to order quantity\nAre you sure ?", "Please confirm the quantity!", MessageBoxButtons.YesNo);

                        if (confirmResult == DialogResult.Yes)
                        {
                            // If 'Yes', do something here.
                            cmd.CommandText = $"UPDATE `orderpart` SET opStatus = 'Assembled', actDespQty = {actDespQtyData} WHERE orderID = \'{orderID}\' AND partID = \'{partID}\'";
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
