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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elysia
{
    public partial class Filter : Form
    {
        public string queryString { get; private set; }
        public event EventHandler Query;
        private String type;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public Filter(String t)
        {
            type = t;
            InitializeComponent();
            setComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void setComponent()
        {
            switch (type)
            {
                case "DID":
                    DID.Visible = true;
                    break;
                case "Order":
                    setComponent_Order();
                    break;
            }
        }


        public void btnSearch_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "DID":
                    break;
                case "Order":
                    search_order();
                    break;
            }
            Query?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        public void setComponent_Order()
        {
            Order.Visible = true;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load orderIDs
                cmd.CommandText = "SELECT orderID FROM `order`";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cbOrderID.Items.Clear();

                    while (reader.Read())
                    {
                        cbOrderID.Items.Add(reader.GetString(0));
                    }
                }

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
            }
        }
        private void search_order()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM `order` WHERE 1=1");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (cbOrderID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND orderID = '{cbOrderID.SelectedItem}'");
            }
            if (cbDealerID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND dealerID = '{cbDealerID.SelectedItem}'");
            }
            if (!rbOStatusAll.Checked) {
                if (rbOStatusA.Checked)
                {
                    queryBuilder.Append(" AND orderStatus = 'Assembled'");
                }
                if (rbOStatusC.Checked)
                {
                    queryBuilder.Append(" AND orderStatus = 'Cancelled'");
                }
                if (rbOStatusD.Checked)
                {
                    queryBuilder.Append(" AND orderStatus = 'Despatched'");
                }
                if (rbOStatusP.Checked)
                {
                    queryBuilder.Append(" AND orderStatus = 'Processing'");
                }
                if (rbOStatusO.Checked)
                {
                    queryBuilder.Append(" AND orderStatus = 'OStanding'");
                }
            }
            if (cbDate.Checked && oDateTo.Value.Date >= oDateFrom.Value.Date)
            {
                
                queryBuilder.Append($" AND orderDate BETWEEN '{oDateFrom.Value.ToString("yyyy-MM-dd")}' AND '{oDateTo.Value.ToString("yyyy-MM-dd")}'");
            }
            queryBuilder.Append(" ORDER BY orderDate DESC");
            queryString = queryBuilder.ToString();
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            orderDateContainer.Visible = cbDate.Checked;
            orderDateContainer.Enabled = cbDate.Checked;
        }

        private void DID_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPartID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDIDOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbOStatusAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOStatusA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOStatusP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOStatusO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOStatusC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOStatusD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Order_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderDateContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void oDateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void oDateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbDealerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
