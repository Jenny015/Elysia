using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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
                    setComponent_DID();
                    break;
                case "Order":
                    setComponent_Order();
                    break;
                case "invoice":
                    setComponent_invoice();
                    break;
            }
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "DID":
                    search_DID();
                    break;
                case "Order":
                    search_order();
                    break;
                case "invoice":
                    search_invoice();
                    break;
            }
            Query?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        
        private void loadDataFromDatabase(String col, String table, ComboBox cb)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"SELECT {col} FROM `{table}`";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cb.Items.Clear();

                    while (reader.Read())
                    {
                        cb.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void setComponent_DID()
        {
            DID.Location = new System.Drawing.Point(9, 9);
            DID.Visible = true;
            btnSearch.Location = new System.Drawing.Point(158, 305);
            loadDataFromDatabase("orderID", "order", didOrderID);
            loadDataFromDatabase("partID", "part", didPartID);

        }
        private void setComponent_Order()
        {
            Order.Location = new System.Drawing.Point(9, 9);
            Order.Visible = true;
            btnSearch.Location = new System.Drawing.Point(162, 475);
            loadDataFromDatabase("orderID", "order", cbOrderID);
            loadDataFromDatabase("dealerID", "dealer", cbDealerID);
        }
        private void setComponent_invoice()
        {
            invoice.Location = new System.Drawing.Point(9, 9);
            invoice.Visible = true;
            btnSearch.Location = new System.Drawing.Point(105, 180);
            loadDataFromDatabase("orderID", "order", invOrderID);
        }
        private void search_DID()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM `orderpart` WHERE 1=1");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            queryString = queryBuilder.ToString();
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
            if (!rbOStatusAll.Checked)
            {
                if (rbOStatusA.Checked)
                {
                    queryBuilder.Append(" OR orderStatus = 'Assembled'");
                }
                if (rbOStatusC.Checked)
                {
                    queryBuilder.Append(" OR orderStatus = 'Cancelled'");
                }
                if (rbOStatusD.Checked)
                {
                    queryBuilder.Append(" OR orderStatus = 'Despatched'");
                }
                if (rbOStatusP.Checked)
                {
                    queryBuilder.Append(" OR orderStatus = 'Processing'");
                }
                if (rbOStatusO.Checked)
                {
                    queryBuilder.Append(" OR orderStatus = 'OStanding'");
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
        private void search_invoice()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT i.orderID, i.invStatus FROM invoice i, `order` o WHERE o.orderID = i.orderID");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (invOrderID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND i.orderID = '{invOrderID.SelectedItem}'");
            } 
            if (!invAll.Checked)
            {
                if (invW.Checked)
                {
                    queryBuilder.Append(" OR invStatus = 'Wait'");
                }
                if (invSend.Checked)
                {
                    queryBuilder.Append(" OR invStatus = 'Send'");
                }
                if (invSign.Checked)
                {
                    queryBuilder.Append(" OR invStatus = 'Sign'");
                }
            }
            queryBuilder.Append(" ORDER BY o.`orderDate` DESC");
            queryString = queryBuilder.ToString();
        }
    }
}