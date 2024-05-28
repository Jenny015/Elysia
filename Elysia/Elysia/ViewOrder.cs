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
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";

        public ViewOrder()
        {
            InitializeComponent();
            setDataGridView();

            if (dataGridVieworder != null)
            {
                setDataGridView();
            }
            else
            {
                MessageBox.Show("dataGridView1 is null");
            }
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
                    buttonColumn.HeaderText = "Cancel";
                    buttonColumn.Name = "buttonColumn";
                    buttonColumn.Text = "Cancel";
                    buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

                    // Add the button column to the DataGridView
                    dataGridVieworder.Columns.Add(buttonColumn);
                }
            }
        }
        private void reloadDataGridView()
        {
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e){
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dataGridVieworder.Columns["buttonColumn"].Index && e.RowIndex >= 0)
                {

                    DataGridViewRow row = dataGridVieworder.Rows[e.RowIndex];
                    String orderID = row.Cells["orderID"].Value.ToString();
                    String partID = row.Cells["XXXXX"].Value.ToString();


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
                            MessageBox.Show("Failed" + ex.Message);
                        }
                    }

                }
}
 
   

