using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elysia
{
    public partial class InvoiceGenerateAndDelivery : Form
    {
        String connectionString = "server=localhost;database=elysia;uid=root;pwd=\"\";";
        private Filter filter;
        public InvoiceGenerateAndDelivery()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnInvGen.Checked = true;
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.ReadOnly = true;
            LoadDataFromDatabase("");
            setDataGridView();
        }
        private void LoadDataFromDatabase(string query)
        {
            if(query == "")
            {
                query = "SELECT * FROM `order` WHERE orderStatus = 'Assembled' ORDER BY orderDate DESC";
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dgvOrder.DataSource = dt;
                    }
                }
            }
        }
        private void setDataGridView()
        {
            LoadDataFromDatabase("");
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Detail";
            buttonColumn.Name = "detailButton";
            buttonColumn.Text = "...";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvOrder.Columns.Add(buttonColumn);

            //set background color
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("Order");
            filter.Query += filter_Query;
            filter.Show();
        }

        private void filter_Query(object sender, EventArgs e)
        {
            string query = filter.queryString;
            LoadDataFromDatabase(query);
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex % 2 == 0)
            {
                dgvOrder.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dgvOrder.Columns["detailButton"].Index && e.RowIndex >= 0)
                {
                    btnFilter.Visible = false;
                    dgvOrder.Visible = false;
                    btnPrint.Visible = true;
                    btnBack.Visible = true;
                    InvPreview.Visible = true;
                    setInvoice(dgvOrder.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnFilter.Visible = true;
            dgvOrder.Visible = true;
            btnPrint.Visible = false;
            btnBack.Visible = false;
            InvPreview.Visible = false;
        }

        private void setInvoice(String orderID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT O.orderDate, D.dCompany, D.dName, D.dPhone, D.dComAdd, D.dDelivAdd FROM `order` O, `orderpart` OP, dealer D, part P WHERE O.orderID = OP.orderID AND O.dealerID = D.dealerID AND P.partID = OP.partID AND O.orderID = '{orderID}';";
                try
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblOrderDate.Text = reader.GetDateTime(0).ToString("d");
                            lblDCom.Text = reader.GetString(1);
                            lblDName.Text = reader.GetString(2);
                            lblDPhone.Text = reader.GetString(3);
                            lblAddr.Text = reader.GetString(5) != "" ? reader.GetString(5) : reader.GetString(4);
                        }
                    }

                    String query = $"SELECT OP.partID AS `Part ID`, P.partName AS `Part Name`, OP.orderQty AS `Order Quantity`, OP.OSQty AS `Previous Order Quantity`, OP.actDespQty AS `Despatch Quantity`, P.price AS `Price`, (P.price * OP.actDespQty) AS `Subtotal` FROM orderpart OP, part P WHERE OP.partID = P.partID AND OP.orderID = '{orderID}';";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgv.DataSource = ds.Tables[0];
                        dgv.Columns["Price"].DefaultCellStyle.Format = "N2";
                        dgv.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                    }

                    double totalPrice = 0;
                    int totalQty = 0;
                    foreach (DataGridViewRow row in dgv.Rows) 
                    { 
                        totalPrice += Double.Parse(row.Cells["Subtotal"].Value.ToString());
                        totalQty += int.Parse(row.Cells["Despatch Quantity"].Value.ToString());
                    }
                    lblPrice.Text = totalPrice.ToString("N2");
                    lblItems.Text = totalQty.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex.Message);
                }

            }
            lblOrderID.Text = orderID;
            lblToday.Text = DateTime.Today.ToString("d");

        }

        private int currentRowIndex = 0;
        private bool morePagesToPrint = false;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPrev.Document = printDoc;
            printPrev.ShowDialog();
        }
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                // Define the start and end points of the area you want to print
                Point startPoint = new Point(426, 105); // You need to determine the correct coordinates
                Point endPoint = new Point(1908, 975); // You need to determine the correct coordinates

                // Calculate the height of the content to be printed
                int contentHeight = endPoint.Y - startPoint.Y;

                // Check if the content fits on one page or needs to be split across multiple pages
                if (contentHeight <= e.MarginBounds.Height)
                {
                    // Content fits on one page, draw the content here...
                    // You can use e.Graphics.DrawString or e.Graphics.DrawImage as needed
                }
                else
                {
                    // Content spans multiple pages
                    // You need to implement logic to handle multiple pages
                    // This may involve drawing a portion of the content and setting e.HasMorePages to true
                }
            }
            /*try
            {
                int start = e.MarginBounds.Top;
                while (currentRowIndex < dgv.Rows.Count)
                {
                    DataGridViewRow row = dgv.Rows[currentRowIndex];
                    int rowHeight = row.Height;
                    // Check if the current row will fit on the page
                    if (startY + rowHeight >= e.MarginBounds.Bottom)
                    {
                        morePagesToPrint = true;
                        break;
                    }
                    // Draw the row here...
                    startY += rowHeight;
                    currentRowIndex++;
                }
                if (morePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }*/
            catch (Exception ex)
            {
                MessageBox.Show("Exception: "+ex.Message);
            }
        }

        private void printDoc_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentRowIndex = 0;
            morePagesToPrint = false;
        }
    }
}
