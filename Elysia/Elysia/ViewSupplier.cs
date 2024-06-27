using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewSupplier : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewSupplier()
        {
            InitializeComponent();
            reloadDataGridView("");
            setDataGridView();
            dgvSupplier.Columns[0].ReadOnly = true;


        }
        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT supplierID, sComName, sAdd  FROM `supplier` ORDER BY supplierID" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvSupplier.DataSource = ds.Tables[0];

                }
            }
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Detail";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Detail";
            buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

            // Add the button column to the DataGridView
            dgvSupplier.Columns.Add(buttonColumn);

            // Add "Update" button column
            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Update";
            updateColumn.Name = "Update";
            updateColumn.Text = "Update";
            updateColumn.UseColumnTextForButtonValue = true;
            dgvSupplier.Columns.Add(updateColumn);
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                // Check if the click is on the button column
                if (e.ColumnIndex == dgvSupplier.Columns["buttonColumn"].Index && e.RowIndex >= 0)
                {
                    String supplierID = dgvSupplier.Rows[e.RowIndex].Cells["supplierID"].Value.ToString();
                    ViewSupplierPart spp = new ViewSupplierPart(supplierID);
                    this.Controls.Clear();
                    this.Controls.Add(spp);
                    this.Refresh();
                } 
                else if (e.ColumnIndex == dgvSupplier.Columns["Update"].Index && e.RowIndex >= 0)
                {
                    var confirm = MessageBox.Show($"Do you want to change the data of {dgvSupplier.Rows[e.RowIndex].Cells["supplierID"].Value}?", "Update information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.No)
                    {
                        return;
                    }
                    // Update button clicked
                    DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                    string supplierID = row.Cells["supplierID"].Value.ToString();
                    string sComName = row.Cells["sComName"].Value.ToString();
                    string sAdd = row.Cells["sAdd"].Value.ToString();

                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(sComName) || string.IsNullOrWhiteSpace(sAdd))
                    {
                        MessageBox.Show("All fields except must be filled.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        // Update the database with the new dealer information
                        string updateQuery = "UPDATE supplier SET sComName = @sComName, sAdd = @sAdd WHERE supplierID = @supplierID";
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@supplierID", supplierID);
                            cmd.Parameters.AddWithValue("@sComName", sComName);
                            cmd.Parameters.AddWithValue("@sAdd", sAdd);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Supplier information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadDataGridView("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //filter
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            filter = new Filter("Sup");
            filter.Query += filter_Query;
            filter.Show();
        }
        private void filter_Query(object sender, EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }

    }
}
