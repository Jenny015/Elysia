using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ScrapItem : UserControl
    {

        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ScrapItem()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string partID = tbPartID.Text.Trim();
                    int quantity = int.Parse(tbQuantity.Text.Trim());

                    // Update the part quantity in the part table
                    string updatePartSql = "UPDATE part SET partQty = partQty - @quantity WHERE partID = @partID";
                    MySqlCommand updatePartCommand = new MySqlCommand(updatePartSql, connection);
                    updatePartCommand.Parameters.AddWithValue("@quantity", quantity);
                    updatePartCommand.Parameters.AddWithValue("@partID", partID);
                    int updatedRows = updatePartCommand.ExecuteNonQuery();

                    // Insert the scrap item into the log table
                    string logID = DateTime.Now.ToString("yyyyMMddHHmmssff");
                    string logSql = "INSERT INTO log (logID, empID, partID, logChanges, logDes) VALUES (@logID, @empID, @partID, @logChanges, @logDes)";
                    MySqlCommand logCommand = new MySqlCommand(logSql, connection);
                    logCommand.Parameters.AddWithValue("@logID", logID);
                    logCommand.Parameters.AddWithValue("@empID", StaticVariable.empID);
                    logCommand.Parameters.AddWithValue("@partID", partID);
                    logCommand.Parameters.AddWithValue("@logChanges", -quantity);
                    logCommand.Parameters.AddWithValue("@logDes", "scrap item");
                    int insertedRows = logCommand.ExecuteNonQuery();

                    if (updatedRows > 0 && insertedRows > 0)
                    {
                        MessageBox.Show("Scrap item saved successfully.");
                        tbPartID.Text = "";
                        tbQuantity.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to save scrap item.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPartID.Text = "";
            tbQuantity.Text = "";
        }
    }
}
