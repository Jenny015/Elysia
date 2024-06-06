using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysia
{
    public partial class NewSparePart : UserControl
    {
        public static string connectionString = "server=localhost;database=elysia;user=root;password=''";
        List<string> categoryIndex = new List<string>();
        public NewSparePart()
        {
            InitializeComponent();
            LoadInformation();
            partPrice.KeyPress += new KeyPressEventHandler(partPrice_KeyPress);
        }
        public void LoadInformation()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load dealerIDs
                cmd.CommandText = "SELECT * FROM category";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cate.Items.Clear();

                    while (reader.Read())
                    {
                        categoryIndex.Add(reader.GetString(0));
                        cate.Items.Add(reader.GetString(1));
                    }
                }
            }
        }

        public void updatePartID(string category)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT MAX(partID) FROM `part` WHERE partID LIKE '{category}%'";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        var maxPartID = reader2[0];
                        if (maxPartID != null && maxPartID != DBNull.Value)
                        {
                            lblPartID.Text = $"{category}{int.Parse(maxPartID.ToString().Substring(1)) + 1:D5}";
                            return;
                        }
                    }
                }
                lblPartID.Text = $"{category}00001";
            }
        }
        //only allow user enter numeric character
        private void partPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // To allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cate.SelectedIndex == -1)
            {
                lblPartID.Text = "N\\A";
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT categoryID FROM `category` WHERE categoryName = '{cate.SelectedItem.ToString()}'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        updatePartID(reader[0].ToString());
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cate.SelectedIndex = -1;
            partName.Text = "";
            partPrice.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                MessageBox.Show("Every fields should be inputted", "Error");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Prepare the INSERT query
                string insertQuery = "INSERT INTO part VALUES (@partID, @categoryID, @parName, @price, 0, 'Out-of-stock')";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@partID", lblPartID.Text);
                    cmd.Parameters.AddWithValue("@categoryID", categoryIndex[cate.SelectedIndex]);
                    cmd.Parameters.AddWithValue("@parName", partName.Text);
                    cmd.Parameters.AddWithValue("@price", partPrice.Text);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Spare Part information added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, null);
            }
        }

        private bool checkInput()
        {
            if(cate.SelectedIndex != -1 && partName.Text != "" && partPrice.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
