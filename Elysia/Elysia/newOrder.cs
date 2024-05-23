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

namespace Elysia
{
    public partial class newOrder : Form
    {
        private MySqlConnection cnn;
        private Dictionary<String, int> orderParts = new Dictionary<string, int>();
        String newOrderID;
        public newOrder()
        {
            InitializeComponent();
            cnn = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";");
            LoadInformation();
        }

        public void ConnectToSql()
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

            cmd.CommandText = "SELECT MAX(OrderID) FROM `order`";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    var maxOrderID = reader[0];
                    if (maxOrderID != null && maxOrderID != DBNull.Value)
                    {
                        var numberPart = int.Parse(maxOrderID.ToString().Substring(1));
                        var newNumber = numberPart + 1;
                        newOrderID = $"N{newNumber:D9}";
                        lblOrderID.Text = newOrderID;
                    }
                }
                
            }

            cnn.Close();

            //display date of the order
            lblDate.Text = DateTime.Today.ToString("d");

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(cbPartID.SelectedItem != null && nQty.Value > 0)
            {
                String addPart = (String)cbPartID.SelectedItem;
                int qty = Decimal.ToInt32(nQty.Value);
                bool exist = false;
                foreach (var parts in orderParts)
                {
                    if(parts.Key == addPart)
                    {
                        lbItems.Items.Remove(addPart + " (" + parts.Value + ")");
                        orderParts[addPart] += qty;
                        lbItems.Items.Add(addPart + " (" + orderParts[addPart] + ")");
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    orderParts.Add(addPart, qty);
                    lbItems.Items.Add(addPart + " (" + qty + ")");
                }

                cbPartID.SelectedItem = null;
                nQty.Value = 1;
                cbPartID.Focus();

            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            String removeItem = lbItems.SelectedItem.ToString().Split(' ')[0];
            orderParts.Remove(removeItem).ToString();
            lbItems.Items.Remove(lbItems.SelectedItem);
        }

        private void cbDealerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDealerID.SelectedItem == null)
            {
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbDealerID.SelectedItem = null;
            lbItems.Items.Clear();
            cbPartID.SelectedItem = null;
            nQty.Value = 1;
            orderParts = new Dictionary<string, int>();
            lblDealerName.Text = "";
            lblDealerCompany.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //If stock qty > order qty -> Generate DID, status == processing, order status == processing


            //else DID status == OStanding, order (outstanding == true) 
        }
    }
}
