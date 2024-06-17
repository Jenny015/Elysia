using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class NewSupplier : UserControl
    {
        private string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public NewSupplier()
        {
            InitializeComponent();

        }

        private bool checkInput()
        {
            if (spSupplierName.Text.Length > 0 && spPhoneNumber.Text.Length > 0 && spAddress.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the INSERT query
                    string insertQuery = "INSERT INTO dealer VALUES (@dealerID, @dName, @dCompany, @dPhone, @dEmail, @dComAdd, @dDelivAdd)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // Set parameter values from textboxes
                        cmd.Parameters.AddWithValue("@dName", spSupplierName.Text);
                        cmd.Parameters.AddWithValue("@dCompany", spAddress.Text);
                        cmd.Parameters.AddWithValue("@dPhone", spPhoneNumber.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Supplier information added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Supplier information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnClear_Click(null, null);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            spSupplierName.Clear();
            spAddress.Clear();
            spPhoneNumber.Clear();

        }
    }
}
