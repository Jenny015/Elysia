using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Filter : Form
    {
        public string queryString { get; private set; }
        public event EventHandler Query;
        private String type;
        private String supplierID;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public Filter(String t)
        {
            type = t;
            InitializeComponent();
            setComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Filter(String t, String supplier)
        {
            type = t;
            supplierID = supplier;
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
                case "inward":
                    setComponent_inward();
                    break;
                case "part":
                    setComponent_part();
                    break;
                case "Sup":
                    setComponent_Sup();
                    break;
                case "dealer":
                    setComponent_dealer();
                    break;
                case "emp":
                    setComponent_emp();
                    break;
                case "log":
                    setComponent_log();
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
                case "inward":
                    search_inward();
                    break;
                case "part":
                    search_part();
                    break;
                case "Sup":
                    search_sup();
                    break;
                case "dealer":
                    search_dealer();
                    break;
                case "emp":
                    search_emp();
                    break;
                case "log":
                    search_log();
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

                cmd.CommandText = $"SELECT DISTINCT {col} FROM `{table}`";
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
            btnSearch.Location = new System.Drawing.Point(125, 258);
            loadDataFromDatabase("orderID", "order", didOrderID);
            loadDataFromDatabase("partID", "part", didPartID);
            loadDataFromDatabase("opStatus", "orderpart", didStatus);
        }
        private void setComponent_Order()
        {
            Order.Location = new System.Drawing.Point(9, 9);
            Order.Visible = true;
            btnSearch.Location = new System.Drawing.Point(182, 446);
            loadDataFromDatabase("orderID", "order", cbOrderID);
            loadDataFromDatabase("dealerID", "dealer", cbDealerID);
            loadDataFromDatabase("orderStatus", "order", orderStatus);
        }
        private void setComponent_invoice()
        {
            invoice.Location = new System.Drawing.Point(9, 9);
            invoice.Visible = true;
            btnSearch.Location = new System.Drawing.Point(134, 203);
            loadDataFromDatabase("orderID", "order", invOrderID);
            loadDataFromDatabase("invStatus", "invoice", invStatus);
        }
        private void setComponent_inward()
        {
            inward.Location = new System.Drawing.Point(9, 9);
            inward.Visible = true;
            btnSearch.Location = new System.Drawing.Point(110, 361);
            loadDataFromDatabase("inwardsID", "inwardsOrder", iwID);
            loadDataFromDatabase("supplierID", "inwardsOrder", iwSupplierID);
            loadDataFromDatabase("partID", "inwardspart", iwPartID);
        }
        private void setComponent_part()
        {
            part.Location = new System.Drawing.Point(9, 9);
            part.Visible = true;
            btnSearch.Location = new System.Drawing.Point(125, 317);
            loadDataFromDatabase("partID", "part", partPartID);
            loadDataFromDatabase("partStatus", "part", partStatus);
            loadDataFromDatabase("categoryName", "category", partCategory);
        }
        private void setComponent_Sup()
        {
            Sup.Location = new System.Drawing.Point(9, 9);
            Sup.Visible = true;
            btnSearch.Location = new System.Drawing.Point(125, 270);
            loadDataFromDatabase("supplierID", "supplierpart", supID);
            loadDataFromDatabase("partID", "supplierpart", supPartID);
        }
        private void setComponent_dealer()
        {
            dealer.Location = new System.Drawing.Point(9, 9);
            dealer.Visible = true;
            btnSearch.Location = new System.Drawing.Point(125, 258);
            loadDataFromDatabase("dealerID", "dealer", deaID);
        }
        private void setComponent_emp()
        {
            emp.Location = new System.Drawing.Point(9, 9);
            emp.Visible = true;
            btnSearch.Location = new System.Drawing.Point(125, 258);
            loadDataFromDatabase("empID", "emp", empID);
            loadDataFromDatabase("deptName", "dept", empDept);
        }
        private void setComponent_log()
        {
            log.Location = new System.Drawing.Point(9, 9);
            log.Visible = true;
            btnSearch.Location = new System.Drawing.Point(125, 258);
            loadDataFromDatabase("logID", "log", logPartID);
            loadDataFromDatabase("logDes", "log", logDes);

        }
        private void search_DID()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT OP.orderID, OP.partID, (OP.orderQty+OP.OSQty) AS TotalQty, actDespQty, opStatus FROM `orderpart` OP, `order` O WHERE OP.orderID = O.orderID");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (didOrderID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND OP.orderID = '{didOrderID.SelectedItem}'");
            }
            if (didPartID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND partID = '{didPartID.SelectedItem}'");
            }
            if (didStatus.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND opStatus = '{didStatus.SelectedItem.ToString()}'");
            }
            queryBuilder.Append(" ORDER BY O.orderDate DESC");
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
            if (orderStatus.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND orderStatus = '{orderStatus.SelectedItem.ToString()}'");
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
            if (invStatus.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND invStatus = '{invStatus.SelectedItem.ToString()}'");
            }
            queryBuilder.Append(" ORDER BY o.`orderDate` DESC");
            queryString = queryBuilder.ToString();
        }
        private void search_inward()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT DISTINCT `io`.inwardsID, `io`.supplierID, `io`.inwardsDate FROM inwardsorder `io`, inwardspart `ip` WHERE `io`.inwardsID = `ip`.inwardsID");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (iwID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND `io`.inwardsID = '{iwID.SelectedItem}'");
            }
            if (iwSupplierID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND `io`.supplierID = '{iwSupplierID.SelectedItem}'");
            }
            if (iwPartID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND `ip`.partID = '{iwPartID.SelectedItem}'");
            }
            if (iwDate.Checked && iwTo.Value.Date >= iwFrom.Value.Date)
            {
                queryBuilder.Append($" AND inwardsDate BETWEEN '{iwFrom.Value.ToString("yyyy-MM-dd")}' AND '{iwTo.Value.ToString("yyyy-MM-dd")}'");
            }
            queryBuilder.Append(" ORDER BY `io`.inwardsDate DESC");
            queryString = queryBuilder.ToString();
        }
        private void iwDate_CheckedChanged(object sender, EventArgs e)
        {
            iwDatePanel.Visible = iwDate.Checked;
            iwDatePanel.Enabled = iwDate.Checked;
        }
        private void search_part()
        {
            StringBuilder queryBuilder = new StringBuilder("");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (partPartID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND p.partID = '{partPartID.SelectedItem}'");
            }
            if (partCategory.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND c.categoryName = '{partCategory.SelectedItem}'");
            }
            if (partStatus.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND p.partStatus = '{partStatus.SelectedItem}'");
            }
            if (partPartName.Text.Length == 0)
            {
                queryBuilder.Append($" AND p.partName LIKE '%{partPartName.Text}%'");
            }
            queryBuilder.Append(" ORDER BY p.partID");
            queryString = queryBuilder.ToString();
        }
        private void search_sup()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT s.* FROM supplier s, supplierPart sp WHERE s.supplierID = sp.supplierID");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (supID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND sp.supplierID = '{supID.SelectedItem}'");
            }
            if (supPartID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND sp.partID = '{supPartID.SelectedItem}'");
            }
            queryBuilder.Append(" ORDER BY sp.supplierID");
            queryString = queryBuilder.ToString();
        }
        private void search_dealer()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM dealer WHERE 1=1");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (deaID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND dealerID = '{deaID.SelectedItem}'");
            }
            if (deaName.Text.Length == 0)
            {
                queryBuilder.Append($" AND dName LIKE '%{deaName.Text}%'");
            }
            if (deaCompany.Text.Length == 0)
            {
                queryBuilder.Append($" AND dCompany LIKE '%{deaCompany.Text}%'");
            }
            queryBuilder.Append(" ORDER BY dealerID");
            queryString = queryBuilder.ToString();
        }
        private void search_emp()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT e.empID, e.empName, e.empGander, e.empPhone, e.empEmail, d.deptName, e.empPostion, CASE e.empStatus WHEN 'A' THEN 'Active' WHEN 'L' THEN 'LOCK' END AS Status FROM emp e, dept d WHERE e.deptID = d.deptID");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (empID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND e.empID = '{empID.SelectedItem}'");
            }
            if (empDept.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND d.deptName = '{empDept.SelectedItem}'");
            }
            queryBuilder.Append(" ORDER BY empID");
            queryString = queryBuilder.ToString();
        }
        private void search_log()
        {
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM log WHERE 1=1");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            if (logPartID.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND partID = '{logPartID.SelectedItem}'");
            }
            if (logChanges.SelectedIndex == 0)
            {
                queryBuilder.Append($" AND logChanges > 0");
            }
            else if (logChanges.SelectedIndex == 1)
            {
                queryBuilder.Append($" AND logChanges < 0");
            }
            if (logDes.SelectedIndex != -1)
            {
                queryBuilder.Append($" AND logDes = '{logDes.SelectedItem}'");
            }
            queryBuilder.Append(" ORDER BY logID DESC");
            queryString = queryBuilder.ToString();
        }
    }
}