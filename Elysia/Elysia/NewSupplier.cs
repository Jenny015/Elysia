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

        }

        private bool checkInput() { 
           // Check if all required fields are filled
            if (spSupplierName.Text == "" || spPhoneNumber.Text == "" ||
                spAddress.Text == "")
            {
                return false;
            }

            // Validate phone number
            if (!Regex.IsMatch(spPhoneNumber.Text, @"^\d{8}$"))
            {
                MessageBox.Show("Phone number must be 8 numeric digits only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string insertQuery = "INSERT INTO supplier VALUES (@dName, @dPhone, @dCompany)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // Set parameter values from textboxes
                        cmd.Parameters.AddWithValue("@dName", spSupplierName.Text);
                        cmd.Parameters.AddWithValue("@dPhone", spPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@dCompany", spAddress.Text);


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
        