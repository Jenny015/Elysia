using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Elysia
{
    public partial class GoodsInward : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        private Dictionary<String, int> inwardsParts = new Dictionary<string, int>();  //dicationary to store order item partID and qty
        String newInwardsID;  //store new inwardsID
        String supplierID; //store current supplierID

        public GoodsInward()
        {
            InitializeComponent();
            LoadInformation();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            this.WindowState = FormWindowState.Maximized;
            btnGoodsInward.Checked = true;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnViewGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            ViewInwards vi = new ViewInwards();
            vi.Show();
            this.Close();
        }

        private void LoadInformation()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load dealerIDs
                cmd.CommandText = "SELECT supplierID FROM supplier";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cbSupplierID.Items.Clear();

                    while (reader.Read())
                    {
                        cbSupplierID.Items.Add(reader.GetString(0));
                    }
                }
                updateInwardsID();
            }
            //display date of the order
            lblDate.Text = DateTime.Today.ToString("d");
        }
        //get the larger inwardsID to calculate new inwardsID
        private void updateInwardsID()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT MAX(inwardsID) FROM `inwardsOrder`";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var maxInwardsID = reader[0];
                        if (maxInwardsID != null && maxInwardsID != DBNull.Value)
                        {
                            newInwardsID = $"R{int.Parse(maxInwardsID.ToString().Substring(1)) + 1:D9}";
                        }
                    }
                }
            }
            lblInwardsID.Text = newInwardsID;
        }
        //load partID list when selected index changed
        private void cbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSupplierID.SelectedItem == null)
            {
                supplierID = "";
                cbPartID.Items.Clear();
                return;
            }
            supplierID = (string)cbSupplierID.SelectedItem;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT partID FROM supplierpart WHERE supplierID = '{supplierID}'";

                cbPartID.Items.Clear();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbPartID.Items.Add(reader.GetString(0));
                    }
                }

                cmd.CommandText = $"SELECT sComName FROM supplier WHERE supplierID = '{supplierID}'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lblSComp.Text = reader.GetString(0);
                    }
                }
            }
            cbSupplierID.Enabled = false;
        }
        //Update product information after partID changed
        private void cbPartID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPartID.SelectedItem == null)
            {
                lblpartName.Text = "N\\A";
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT partName FROM part WHERE partID = '{cbPartID.SelectedItem.ToString()}'";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lblpartName.Text = reader.GetString(0);
                    }
                }
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
                foreach (var parts in inwardsParts)
                {
                    // if partID already in list, add qty to existing item
                    if (parts.Key == addPart)
                    {
                        lbItems.Items.Remove(addPart + " (" + parts.Value + ")");
                        inwardsParts[addPart] += qty;
                        lbItems.Items.Add(addPart + " (" + inwardsParts[addPart] + ")");
                        exist = true;
                        break;
                    }
                }
                // if partID not exist, add to dictionary and list
                if (!exist)
                {
                    inwardsParts.Add(addPart, qty);
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
            inwardsParts.Remove(removeItem).ToString();
            lbItems.Items.Remove(lbItems.SelectedItem);
        }
        //clear form components
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbSupplierID.Enabled = true;
            cbSupplierID.SelectedItem = null;
            lbItems.Items.Clear();
            cbPartID.SelectedItem = null;
            nQty.Value = 1;
            inwardsParts = new Dictionary<string, int>();
        }
        //check if every necessary data has been input
        private bool checkInput()
        {
            String msg = "";
            if (cbSupplierID.SelectedItem == null)
            {
                msg += "Please select a  supplier\n";
            }
            if (inwardsParts.Count == 0)
            {
                msg += "Please enter at least one partID and quantity\n";
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
        //submit form, create new order
        private void submitForm(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            };
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                //insert a new order into order DB
                cmd.CommandText = $"INSERT INTO `inwardsOrder` (inwardsID, supplierID) VALUES ('{newInwardsID}', '{supplierID}')";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to insert goods inward order\n" + ex.Message, "Failed");
                }

                //loop through orderPart dictionary
                foreach (KeyValuePair<String, int> part in inwardsParts)
                {
                    var remaining = part.Value; // store the remaing qty after - a outstanding order
                    // check if the part has outstanding order
                    cmd.CommandText = $"SELECT o.dealerID, op.partID, op.orderQty, o.fromOrder, o.orderID FROM `order` o, orderpart op WHERE o.orderID = op.orderID AND op.partID = '{part.Key}' AND opStatus='OStanding' ORDER BY o.orderDate;";
                    Object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // inwards qty - OSpart qty by orderDate asc > 0
                                if (remaining - reader.GetInt32(2) > 0)
                                {
                                    remaining -= reader.GetInt32(2);
                                    // New R order with origin orderID, inwardsDate generate, Update DID to inwards item
                                    string newOrderID = NewOrder.getOrderID('R');
                                    cmd.CommandText = $"INSERT INTO `order` (orderID, dealerID, fromOrder) VALUES ('{newOrderID}', '{reader.GetString(0)}', '{reader.GetString(3)}');" +
                                        $"UPDATE orderpart SET orderID = '{newOrderID}', opStatus = 'Processing' WHERE orderID = '{reader.GetString(4)}' AND partID = '{part.Key}';";
                                }
                            }
                        }
                    }
                    cmd.CommandText += $"INSERT INTO inwardsPart VALUES ('{newInwardsID}', '{part.Key}', {part.Value})";
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to insert goods inward parts\n" + ex.Message, "Failed");
                    }
                }
            }
            updateInwardsID();
            MessageBox.Show("New Goods Inward has been inserted successfully.", "Success");
            btnClear_Click(null, null);
        }
    }
}
