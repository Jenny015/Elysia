using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Elysia
{
    public partial class NewOrder : UserControl
    {
        public static string connectionString = "server=localhost;database=elysia;user=root;password=''";
        //dicationary to store order item partID and qty
        private Dictionary<String, int> orderParts = new Dictionary<string, int>();
        //store new orderID
        String newOrderID;
        public NewOrder()
        {
            InitializeComponent();
            LoadInformation();
        }

        public void LoadInformation()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load dealerIDs
                cmd.CommandText = "SELECT dealerID FROM dealer";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cbDealerID.Items.Clear();

                    while (reader.Read())
                    {
                        cbDealerID.Items.Add(reader.GetString(0));
                    }
                }
                //load partIDs
                cmd.CommandText = "SELECT partID FROM part";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cbPartID.Items.Clear();

                    while (reader.Read())
                    {
                        cbPartID.Items.Add(reader.GetString(0));
                    }
                }

                updateOrderID();

            }

            //display date of the order
            lblDate.Text = DateTime.Today.ToString("d");

        }


        //get the larger orderID to calculate new orderID
        private void updateOrderID()
        {
            var maxOrderID = getOrderID('N');
            if (maxOrderID != null)
            {
                lblOrderID.Text = maxOrderID;
                newOrderID = maxOrderID;
            }
            else
            {
                lblOrderID.Text = "N\\A";
            }
        }
        //get the new orderID, type == 'N' or 'O'
        public static String getOrderID(char type)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT MAX(OrderID) FROM `order` WHERE orderID LIKE '{type}%'";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        var maxOrderID = reader2[0];
                        if (maxOrderID != null && maxOrderID != DBNull.Value)
                        {
                            return $"{type}{int.Parse(maxOrderID.ToString().Substring(1)) + 1:D9}";
                        }
                    }
                }
                return $"{type}000000001";
            }
        }

        //add item to list and dictionary
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cbPartID.SelectedItem != null && nQty.Value > 0)
            {
                String addPart = (String)cbPartID.SelectedItem;
                int qty = Decimal.ToInt32(nQty.Value);
                bool exist = false;
                foreach (var parts in orderParts)
                {
                    // if partID already in list, add qty to existing item
                    if (parts.Key == addPart)
                    {
                        lbItems.Items.Remove(addPart + " (" + parts.Value + ")");
                        orderParts[addPart] += qty;
                        lbItems.Items.Add(addPart + " (" + orderParts[addPart] + ")");
                        exist = true;
                        break;
                    }
                }
                // if partID not exist, add to dictionary and list
                if (!exist)
                {
                    orderParts.Add(addPart, qty);
                    lbItems.Items.Add(addPart + " (" + qty + ")");
                }

                // reset input elements and focus to partID input after added
                cbPartID.SelectedItem = null;
                nQty.Value = 1;
                cbPartID.Focus();

            }
        }

        //delete item from list and dictionary
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            String removeItem = lbItems.SelectedItem.ToString().Split(' ')[0];
            orderParts.Remove(removeItem).ToString();
            lbItems.Items.Remove(lbItems.SelectedItem);
        }

        //Update dealer information after dealerID changed
        private void cbDealerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDealerID.SelectedItem == null)
            {
                lblDealerName.Text = "N\\A";
                lblDealerCompany.Text = "N\\A";
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load dealer info
                String dealerID = cbDealerID.SelectedItem.ToString();
                cmd.CommandText = $"SELECT dName, dCompany FROM dealer WHERE dealerID = '{dealerID}'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lblDealerName.Text = reader.GetString(0);
                        lblDealerCompany.Text = reader.GetString(1);
                    }
                }
            }
        }
        //clear form components
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDealerID.SelectedItem = null;
            lbItems.Items.Clear();
            cbPartID.SelectedItem = null;
            nQty.Value = 1;
            orderParts = new Dictionary<string, int>();
        }
        //submit form, create new order
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Do you want to submit the new order?", "Please confirm the new order", MessageBoxButtons.YesNo);
            if (!checkInput() || confirm == DialogResult.No)
            {
                return;
            };

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                Dictionary<String, int> osParts = new Dictionary<string, int>();

                //add all the outstanding DID (partID, quantity) of the dealer to osParts Dictionary
                cmd.CommandText = $"SELECT partID, orderQty FROM `orderpart` OP, `order` O  WHERE O.dealerID = '{cbDealerID.SelectedItem.ToString()}' AND O.orderID LIKE 'O%' AND O.orderID = OP.orderID AND OP.opStatus = 'OStanding'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        osParts.Add(reader.GetString(0), reader.GetInt32(1));
                    }
                }

                //Create a new order to Order database
                cmd.CommandText = $"INSERT INTO `order` (orderID, dealerID) VALUES ('{newOrderID}', '{cbDealerID.SelectedItem.ToString()}')";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to insert order\n" + ex.Message, "Failed");
                }

                //loop through orderPart dictionary
                foreach (KeyValuePair<String, int> part in orderParts)
                {
                    int orderQty;
                    if (osParts.TryGetValue(part.Key, out orderQty))
                    {
                        //if current order partID contain OSorder partID, add OSorderpart orderQty to OSQty, update OSorderpart: addToOrder, status = Added
                        cmd.CommandText = $"INSERT INTO orderpart VALUES ('{newOrderID}', '{part.Key}', {part.Value}, {osParts[part.Key]}, null, 'Processing', null);" +
                            $"UPDATE orderpart JOIN `order` ON `order`.`orderID` = `orderpart`.`orderID` SET `orderpart`.`opStatus` = 'Added', `orderpart`.`addToOrder` = '{newOrderID}' WHERE `orderpart`.opStatus = 'OStanding' AND `orderpart`.partID = '{part.Key}' AND `order`.`dealerID` = '{cbDealerID.SelectedItem.ToString()}';";
                    }
                    else
                    {
                        //No outstanding DID
                        cmd.CommandText = $"INSERT INTO orderpart VALUES ('{newOrderID}', '{part.Key}', {part.Value}, 0, null, 'Processing', null)";
                    }

                    //Generate DID
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to insert DID\n" + ex.Message, "Failed");
                    }
                }
            }
            StaticVariable.UpdateAllOutstandingOrders();
            updateOrderID();
            MessageBox.Show("New Order has been inserted successfully.", "Success");
            btnClear_Click(null, null);
        }

        //check if every necessary data has been input
        private bool checkInput()
        {
            String msg = "";
            if (cbDealerID.SelectedItem == null)
            {
                msg += "Please enter DealerID\n";
            }
            if (orderParts.Count == 0)
            {
                msg += "Please enter partID and quantity\n";
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Missing information");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Update product information after partID changed
        private void cbPartID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPartID.SelectedItem == null)
            {
                lblpartName.Text = "N\\A";
                lblStock.Text = "N\\A";
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load dealer info
                String partID = cbPartID.SelectedItem.ToString();
                cmd.CommandText = $"SELECT partName, partQty FROM part WHERE partID = '{partID}'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lblpartName.Text = reader.GetString(0);
                        lblStock.Text = reader.GetInt32(1).ToString();
                    }
                }
            }
        }
    }
}
