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
            lblDealerID.Text = getAndReturnNewDealerID();
        }
        private bool checkInput()
        {
            if (tbDealerName.Text.Length > 0 && tbCompany.Text.Length > 0 &&
                tbPhoneNumber.Text.Length > 0 && tbEmail.Text.Length > 0 && tbCompany.Text.Length > 0)
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
                        cmd.Parameters.AddWithValue("@dealerID", getAndReturnNewDealerID());
                        cmd.Parameters.AddWithValue("@dName", tbDealerName.Text);
                        cmd.Parameters.AddWithValue("@dCompany", tbCompany.Text);
                        cmd.Parameters.AddWithValue("@dPhone", tbPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@dEmail", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@dComAdd", tbCompanyAddress.Text);
                        if (tbDeliveryAddress.Text == "")
                        {
                            cmd.Parameters.AddWithValue("@dDelivAdd", tbCompanyAddress.Text);
                        }
                        else
                        {

                            cmd.Parameters.AddWithValue("@dDelivAdd", tbDeliveryAddress.Text);
                        }

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
            lblDealerID.Text = getAndReturnNewDealerID();
            btnClear_Click(null, null);
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

        public String getAndReturnNewDealerID()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT MAX(DealerID) FROM `dealer`";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        var maxDealerID = reader2[0];
                        if (maxDealerID != null && maxDealerID != DBNull.Value)
                        {
                            return $"DL{int.Parse(maxDealerID.ToString().Substring(2)) + 1:D5}";
                        }
                    }
                }
                return "DL00001";
            }
        }
    }
}
