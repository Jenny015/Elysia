using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Elysia
{
    public partial class NewSupplier : UserControl
    {
        private string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";

        public NewSupplier()
        {
            InitializeComponent();
            lblsupplierID.Text = getAndReturnNewSupplierID();
        }

        private bool checkInput()
        {
            // Check if all required fields are filled
            if (spSupplierCompanyName.Text == "" || spAddress.Text == "")
            {
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                MessageBox.Show("Please enter all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the INSERT query
                    string insertQuery = "INSERT INTO supplier (supplierID,sComName, sAdd) VALUES (@SupplierID,@dCompanyName, @dAdd)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // Set parameter values from textboxes
                        cmd.Parameters.AddWithValue("@SupplierID", lblsupplierID.Text);
                        cmd.Parameters.AddWithValue("@dCompanyName", spSupplierCompanyName.Text);
                        cmd.Parameters.AddWithValue("@dAdd", spAddress.Text);

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

            lblsupplierID.Text = getAndReturnNewSupplierID();
            btnClear_Click(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            spSupplierCompanyName.Clear();
            spAddress.Clear();
        }

        public string getAndReturnNewSupplierID()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT MAX(SupplierID) FROM `supplier`";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        var maxSupplierID = reader2[0];
                        if (maxSupplierID != null && maxSupplierID != DBNull.Value)
                        {

                            string maxID = maxSupplierID.ToString();
                            int startIndex = maxID.IndexOf("S") + 1;
                            int nextID = int.Parse(maxID.Substring(startIndex)) + 1;
                            return $"S{nextID:D5}";
                        }
                    }
                }
                return "S00001";
            }
        }
    }
}