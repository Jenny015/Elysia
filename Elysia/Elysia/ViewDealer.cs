using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewDealer : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        Filter filter;
        public ViewDealer()
        {
            InitializeComponent();
            reloadDataGridView("");
            dgvViewDealer.AllowUserToAddRows = false;
            dgvViewDealer.ReadOnly = false; // Allow editing
            dgvViewDealer.Columns["dealerID"].ReadOnly = true;
            addButtonColumns();
            dgvViewDealer.Columns[0].ReadOnly = true;

        }
        private void reloadDataGridView(string query)
        {
            query = query == "" ? "SELECT * FROM dealer" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvViewDealer.DataSource = ds.Tables[0];
                }
            }
        }

        private void addButtonColumns()
        {
            // Add "Update" button column
            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Update";
            updateColumn.Name = "Update";
            updateColumn.Text = "Update";
            updateColumn.UseColumnTextForButtonValue = true;
            dgvViewDealer.Columns.Add(updateColumn);

        }

        private void dgvViewDealer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvViewDealer.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var confirm = MessageBox.Show($"Do you want to change the data of {dgvViewDealer.Rows[e.RowIndex].Cells["dealerID"].Value}?", "Update information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    return;
                }
                // Update button clicked
                DataGridViewRow row = dgvViewDealer.Rows[e.RowIndex];

                string dealerID = row.Cells["dealerID"].Value.ToString();
                string dName = row.Cells["dName"].Value.ToString();
                string dCompany = row.Cells["dCompany"].Value.ToString();
                string dPhone = row.Cells["dPhone"].Value.ToString();
                string dEmail = row.Cells["dEmail"].Value.ToString();
                string dComAdd = row.Cells["dComAdd"].Value.ToString();
                string dDelivAdd = row.Cells["dDelivAdd"].Value.ToString();

                // Validate input fields
                if (string.IsNullOrWhiteSpace(dName) || string.IsNullOrWhiteSpace(dCompany)
                    || string.IsNullOrWhiteSpace(dPhone) || string.IsNullOrWhiteSpace(dEmail)
                    || string.IsNullOrWhiteSpace(dComAdd))
                {
                    MessageBox.Show("All fields except 'dDelivAdd' must be filled.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Update the database with the new dealer information
                    string updateQuery = "UPDATE dealer SET dName = @dName, dCompany = @dCompany, dPhone = @dPhone, dEmail = @dEmail, dComAdd = @dComAdd, dDelivAdd = @dDelivAdd WHERE dealerID = @dealerID";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@dName", dName);
                            cmd.Parameters.AddWithValue("@dCompany", dCompany);
                            cmd.Parameters.AddWithValue("@dPhone", dPhone);
                            cmd.Parameters.AddWithValue("@dEmail", dEmail);
                            cmd.Parameters.AddWithValue("@dComAdd", dComAdd);
                            cmd.Parameters.AddWithValue("@dDelivAdd", dDelivAdd);
                            cmd.Parameters.AddWithValue("@dealerID", dealerID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    MessageBox.Show("Dealer information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadDataGridView("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating dealer information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("dealer");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }
    }
}
