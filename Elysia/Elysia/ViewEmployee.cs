using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewEmployee : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewEmployee()
        {
            InitializeComponent();
            reloadDataGridView("");
            addButtonColumns();
            dgvEmp.Columns[0].ReadOnly = true;
            dgvEmp.Columns[1].ReadOnly = true;

        }

        private void reloadDataGridView(string query)
        {
            query = query == "" ? "SELECT e.empID, e.empName, e.empGander, e.empPhone, e.empEmail, d.deptName, e.empPostion, e.empStatus FROM emp e, dept d WHERE e.deptID = d.deptID ORDER BY empID" : query;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmp.DataSource = ds.Tables[0];
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
            dgvEmp.Columns.Add(updateColumn);

        }

        private void dgvViewDealer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmp.Columns["Update"].Index && e.RowIndex >= 0)
            {
                var confirm = MessageBox.Show($"Do you want to change the data of {dgvEmp.Rows[e.RowIndex].Cells["empID"].Value}?", "Update information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No)
                {
                    return;
                }
                // Update button clicked
                DataGridViewRow row = dgvEmp.Rows[e.RowIndex];

                string empID = row.Cells["empID"].Value.ToString();
                string empGander = row.Cells["empGander"].Value.ToString();
                string empPhone = row.Cells["empPhone"].Value.ToString();
                string empEmail = row.Cells["empEmail"].Value.ToString();
                string deptID = row.Cells["deptID"].Value.ToString();
                string empPostion = row.Cells["empPostion"].Value.ToString();
                string empStatus = row.Cells["empStatus"].Value.ToString();

                // Validate input fields
                if (string.IsNullOrWhiteSpace(empGander) || string.IsNullOrWhiteSpace(empPhone)
                    || string.IsNullOrWhiteSpace(empEmail) || string.IsNullOrWhiteSpace(deptID)
                    || string.IsNullOrWhiteSpace(empPostion) || string.IsNullOrWhiteSpace(empStatus))
                {
                    MessageBox.Show("All fields except must be filled.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Update the database with the new dealer information
                    string updateQuery = "UPDATE emp SET empGander = @empGander, empPhone = @empPhone, empEmail = @empEmail, deptID = @deptID, empPostion = @empPostion, empStatus = @empStatus WHERE empID = @empID";
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@empID", empID);
                            cmd.Parameters.AddWithValue("@empGander", empGander);
                            cmd.Parameters.AddWithValue("@empPhone", empPhone);
                            cmd.Parameters.AddWithValue("@empEmail", empEmail);
                            cmd.Parameters.AddWithValue("@deptID", deptID);
                            cmd.Parameters.AddWithValue("@empPostion", empPostion);
                            cmd.Parameters.AddWithValue("@empStatus", empStatus);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    MessageBox.Show("Employee information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadDataGridView("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {
            filter = new Filter("emp");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, System.EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }
    }
}
