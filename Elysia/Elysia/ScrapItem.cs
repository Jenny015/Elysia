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
            LoadInformation();
        }
        public void LoadInformation()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load dealerIDs
                cmd.CommandText = "SELECT partID FROM part";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    tbPartID.Items.Clear();

                    while (reader.Read())
                    {
                        tbPartID.Items.Add(reader.GetString(0));
                    }
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPartID.Text.ToString() == "" || tbQuantity.Value <= 0)
            {
                MessageBox.Show("Please select a part item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirm = MessageBox.Show("Do you want to add the scrap item?", "Scrap Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string partID = tbPartID.SelectedItem.ToString();
                    int quantity = (int)tbQuantity.Value;

                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = $"SELECT partQty FROM `part`";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32(0) > quantity)
                            {
                                MessageBox.Show("Scrap item quantity should not be more than stock quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

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
                    logCommand.Parameters.AddWithValue("@logDes", "Scrap item");
                    int insertedRows = logCommand.ExecuteNonQuery();

                    if (updatedRows > 0 && insertedRows > 0)
                    {
                        MessageBox.Show("Scrap item saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbPartID.Text = "";
                        tbQuantity.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to save scrap item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPartID.Text = "";
            tbQuantity.Text = "";
        }
    }
}
