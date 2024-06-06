using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class NewDealer : UserControl
    {
        private string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";

        public NewDealer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the INSERT query
                    string insertQuery = "INSERT INTO dealer (dName, dCompany, dPhone, dEmail, dComAdd, dDelivAdd) " +
                                         "VALUES (@dName, @dCompany, @dPhone, @dEmail, @dComAdd, @dDelivAdd)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // Set parameter values from textboxes
                        cmd.Parameters.AddWithValue("@dName", tbDealerName.Text);
                        cmd.Parameters.AddWithValue("@dCompany", tbCompany.Text);
                        cmd.Parameters.AddWithValue("@dPhone", tbPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@dEmail", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@dComAdd", tbCompanyAddress.Text);
                        cmd.Parameters.AddWithValue("@dDelivAdd", tbDeliveryAddress.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dealer information added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding dealer information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            tbDealerName.Clear();
            tbCompany.Clear();
            tbPhoneNumber.Clear();
            tbEmail.Clear();
            tbCompanyAddress.Clear();
            tbDeliveryAddress.Clear();
        }
    }
}
