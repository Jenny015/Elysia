using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewSparePart : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewSparePart()
        {
            InitializeComponent();
            reloadDataGridView("");
            dgvPart.Columns[0].ReadOnly = true;
            dgvPart.Columns[1].ReadOnly = true;
            dgvPart.Columns[5].ReadOnly = true;
        }

        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `part` ORDER BY partID" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds);
                    dgvPart.DataSource = ds.Tables[0];
                }
                dgvPart.Columns["partQty"].DefaultCellStyle.Format = "N0";
                dgvPart.Columns["price"].DefaultCellStyle.Format = "N2";
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("part");
            filter.Query += filter_Query;
            filter.Show();
        }

        private void filter_Query(object sender, EventArgs e)
        {
            string query = "SELECT p.* FROM `part` p, `category` c WHERE p.categoryID = c.categoryID " + filter.queryString;
            reloadDataGridView(query);
        }

        private void dgvViewDealer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPart.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var confirm = MessageBox.Show($"Do you want to change the data of {dgvEmp.Rows[e.RowIndex].Cells["empID"].Value}?", "Update information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    return;
                }
                // Update button clicked
                DataGridViewRow row = dgvPart.Rows[e.RowIndex];

                string partID = row.Cells["partID"].Value.ToString();
                string partName = row.Cells["partName"].Value.ToString();
                string price = row.Cells["price"].Value.ToString();
                string partQty = row.Cells["partQty"].Value.ToString();

                // Validate input fields
                if (string.IsNullOrWhiteSpace(partName) || string.IsNullOrWhiteSpace(price)
                    || string.IsNullOrWhiteSpace(partQty))
                {
                    MessageBox.Show("All fields except must be filled.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Update the database with the new dealer information
                    string updateQuery = "UPDATE emp SET partName = @partName, price = @price, partQty = @partQty WHERE partID = @partID";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@partID", partID);
                            cmd.Parameters.AddWithValue("@partName", partName);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@partQty", partQty);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    MessageBox.Show("Spare Part information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadDataGridView("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = dgvPart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            string primaryKey = dgvPart.Rows[e.RowIndex].Cells["partID"].Value.ToString();
            string updateCommand = $"UPDATE part SET {dgvPart.Columns[e.ColumnIndex].Name} = '{newValue}' WHERE partID = '{primaryKey}'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateCommand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            if (e.ColumnIndex == 4)
            {
                StaticVariable.updatePartStatus(primaryKey);
            }
            reloadDataGridView("");
        }

        private void dgvPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
