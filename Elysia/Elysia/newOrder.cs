using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;


//TODO: search and combine previous 
namespace Elysia
{
    public partial class NewOrder : Form
    {
        public static MySqlConnection cnn = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";");
        //dicationary to store order item partID and qty
        private Dictionary<String, int> orderParts = new Dictionary<string, int>();
        //store new orderID
        String newOrderID;
        public NewOrder()
        {
            InitializeComponent();
            LoadInformation();
            btnNewOrder.Checked = true;
        }

        public static void ConnectToSql()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to connect MySQL\n"+ex.Message);
            }
        }

        public void LoadInformation()
        {
            ConnectToSql();
            MySqlCommand cmd = cnn.CreateCommand();

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

            cnn.Close();

            //display date of the order
            lblDate.Text = DateTime.Today.ToString("d");

        }


        //get the larger orderID to calculate new orderID
        private void updateOrderID()
        {
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT MAX(OrderID) FROM `order` WHERE orderID LIKE 'N%';";
            using (MySqlDataReader reader = cmd.ExecuteReader())
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
            cnn.Close();
        }
        //get the new orderID, type == 'N' or 'O'
        public static String getOrderID(char type)
        {
            ConnectToSql();
            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = $"SELECT MAX(OrderID) FROM `order` WHERE orderID LIKE '{type}%'";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    var maxOrderID = reader[0];
                    if (maxOrderID != null && maxOrderID != DBNull.Value)
                    {
                        return $"{type}{int.Parse(maxOrderID.ToString().Substring(1)) + 1:D9}";
                    }
                }
                return "O000000001";
            }
        }

        //add item to list and dictionary
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(cbPartID.SelectedItem != null && nQty.Value > 0)
            {
                String addPart = (String)cbPartID.SelectedItem;
                int qty = Decimal.ToInt32(nQty.Value);
                bool exist = false;
                foreach (var parts in orderParts)
                {
                    // if partID already in list, add qty to existing item
                    if(parts.Key == addPart)
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
            if(cbDealerID.SelectedItem == null)
            {
                lblDealerName.Text = "N\\A";
                lblDealerCompany.Text = "N\\A";
                return;
            }
            ConnectToSql();
            MySqlCommand cmd = cnn.CreateCommand();

            //load dealer info
            String dealerID = cbDealerID.SelectedItem.ToString();
            cmd.CommandText = $"SELECT dName, dCompany FROM dealer WHERE dealerID = \"{dealerID}\"";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lblDealerName.Text = reader.GetString(0);
                    lblDealerCompany.Text = reader.GetString(1);
                }
            }
            cnn.Close();
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
            if (!checkInput()) 
            { 
                return;
            };
            ConnectToSql();
            MySqlCommand cmd = cnn.CreateCommand();
            Dictionary<String, int> osParts = new Dictionary<string, int>();

            //insert a new order into order DB
            cmd.CommandText = $"INSERT INTO `order` (orderID, dealerID) VALUES (\"{newOrderID}\", \"{cbDealerID.SelectedItem.ToString()}\")";
            try
            {
                // Execute the SQl statement
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // if error occurs, show fail message
                MessageBox.Show("Failed to insert order\n" + ex.Message, "Failed");
            }

            //search all outstanding DID of the dealer and store partID and outstanding qty in dictionary
            cmd.CommandText = $"SELECT partID, orderQty, actDespQty FROM orderpart OP, `order` O WHERE O.`orderID` = OP.orderID AND opStatus = 'OStanding' AND O.dealerID = '{cbDealerID.SelectedItem.ToString()}'";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    osParts.Add(reader.GetString(0), reader.GetInt32(1)- reader.GetInt32(2));
                }
            }

            //loop through orderPart dictionary
            foreach (KeyValuePair<String, int> part in orderParts)
            {
                int stockQty = 0;
                cmd.CommandText = $"SELECT partQty FROM part WHERE partID = \"{part.Key}\"";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stockQty = reader.GetInt32(0);
                    }
                }
                //check if outstanding order part currently order
                /* TODO */
                int osQty;
                if(osParts.TryGetValue(part.Key, out osQty))
                {
                    cmd.CommandText = $"";
                }

                //Generate DID
                try
                {
                    // Execute the SQl statement
                    cmd.CommandText = $"INSERT INTO orderpart VALUES ('{newOrderID}', '{part.Key}', {part.Value}, null, 'Processing')";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // if error occurs, show fail message
                    MessageBox.Show("Failed to insert DID\n" + ex.Message, "Failed");
                }
            }

            updateOrderID();
            cnn.Close();
            MessageBox.Show("New Order has been inserted successfully.", "Success");
            btnClear_Click(null, null);
        }

        //check if every necessary data has been input
        private bool checkInput()
        {
            String msg = "";
            if(cbDealerID.SelectedItem == null)
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
            ConnectToSql();
            MySqlCommand cmd = cnn.CreateCommand();

            //load dealer info
            String partID = cbPartID.SelectedItem.ToString();
            cmd.CommandText = $"SELECT partName, partQty FROM part WHERE partID = \"{partID}\"";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lblpartName.Text = reader.GetString(0);
                    lblStock.Text = reader.GetInt32(1).ToString();
                }
            }
            cnn.Close();
        }

        //logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            StaticVariable.logout();
        }
    }
}
