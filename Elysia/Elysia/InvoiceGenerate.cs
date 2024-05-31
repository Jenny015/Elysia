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
using Microsoft.Office.Interop.Word;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Elysia
{
    public partial class InvoiceGenerate : Form
    {
        String connectionString = "server=localhost;database=elysia;uid=root;pwd=\"\";";
        private Filter filter;
        private string orderID;
        public InvoiceGenerate()
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
                        System.Data.DataTable dt = new System.Data.DataTable();
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
                    heading.Visible = true;
                    footer.Visible = true;
                    orderID = dgvOrder.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                    setInvoice(orderID);
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
            heading.Visible = false;
            footer.Visible = false;
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
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            _Application wordApp = new Microsoft.Office.Interop.Word.Application();
            try
            {
                wordApp.Visible = true;
                Document doc = wordApp.Documents.Add();
                doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //print heading
                var heading = doc.Shapes.AddTextbox(
                            Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal,
                            compName.Location.X * 72 / 96 + 55, compName.Location.Y * 72 / 96 + 20, 414, 30);
                heading.TextFrame.TextRange.Text = compName.Text;
                heading.TextFrame.TextRange.Font.Name = "Georgia";
                heading.TextFrame.TextRange.Font.Size = 18;
                heading.TextFrame.TextRange.Font.Bold = 1;
                heading.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;

                float maxY = 0;
                float x = 0;
                // Add textbox to the document
                foreach (Control ctrl in InvPreview.Controls)
                {
                    if (ctrl is Label)
                    {
                        
                        System.Drawing.Point loc = ctrl.Location;
                        string text = ctrl.Text;

                        // Convert pixels to points
                        float wordX = loc.X * 72 / 96 + 30;
                        float wordY = loc.Y * 72 / 96 + 90;
                        maxY = wordY > maxY ? wordY : maxY;
                        x = wordX;
                        var textbox = doc.Shapes.AddTextbox(
                            Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal,
                            wordX, wordY, ctrl.Size.Width*72/96+10, ctrl.Size.Height * 72 / 96+10);
                        textbox.TextFrame.TextRange.Text = text;
                        textbox.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                        textbox.TextFrame.TextRange.Font.Name = "Times New Roman";
                        textbox.TextFrame.TextRange.Font.Size = 10;
                        textbox.TextFrame.TextRange.ParagraphFormat.LineSpacing = 10;
                        if (ctrl.Name.Contains("B"))
                        {
                            textbox.TextFrame.TextRange.Font.Bold = 1;
                        }
                    }
                }
                object endOfDoc = "\\endofdoc"; // Predefined bookmark
                Range wordRange = doc.Bookmarks.get_Item(ref endOfDoc).Range;
                wordRange.InsertBreak(WdBreakType.wdPageBreak);

                // Add the table after the page break
                Range tableRange = null;
                try
                {
                    tableRange = wordRange.Next(Microsoft.Office.Interop.Word.WdUnits.wdParagraph, 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while setting the table range: " + ex.Message);
                    return; // Exit the method if the range cannot be set
                }
                //Microsoft.Office.Interop.Word.Range tableRange = doc.Range(dgv.Location.X*72/96, dgv.Location.Y * 72 / 96);
                Table table = doc.Tables.Add(tableRange, dgv.Rows.Count, dgv.Columns.Count);

                // Add data to the table from DataGridView
                foreach(DataGridViewColumn col in dgv.Columns) {
                    string text = col.Name;
                    table.Cell(0, col.Index+1).Range.Text = text;
                }
                for (int r = 1; r <= dgv.Rows.Count; r++)
                {
                    for (int c = 0; c < dgv.Columns.Count; c++)
                    {
                        string text = dgv.Rows[r].Cells[c].Value.ToString();
                        table.Cell(r + 1, c + 1).Range.Text = text;
                        table.Cell(r + 1, c + 1).Range.Bold = 1;
                    }
                }
                table.Borders.Enable = 1;

                // Add footer to the document
                foreach (Control ctrl in footer.Controls)
                {
                    if (ctrl is Label)
                    {

                        System.Drawing.Point loc = ctrl.Location;
                        string text = ctrl.Text;

                        // Convert pixels to points
                        float wordX = loc.X * 72 / 96 -20;
                        float wordY = loc.Y * 72 / 96 + 50;
                        var textbox = doc.Shapes.AddTextbox(
                            Microsoft.Office.Core.MsoTextOrientation.msoTextOrientationHorizontal,
                            wordX, wordY, ctrl.Size.Width * 72 / 96 + 10, ctrl.Size.Height * 72 / 96 + 10);
                        textbox.TextFrame.TextRange.Text = text;
                        textbox.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;
                        textbox.TextFrame.TextRange.Font.Name = "Times New Roman";
                        textbox.TextFrame.TextRange.Font.Size = 10;
                        textbox.TextFrame.TextRange.ParagraphFormat.LineSpacing = 10;
                        if (ctrl.Name.Contains("B"))
                        {
                            textbox.TextFrame.TextRange.Font.Bold = 1;
                        }
                    }
                }

                doc.BuiltInDocumentProperties["Title"] = orderID;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                wordApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            }
        }

        private void btnViewInvoice_CheckedChanged(object sender, EventArgs e)
        {
            ViewInvoice vi = new ViewInvoice();
            vi.Show();
            this.Close();
        }

        private void btnLogout_CheckedChanged_1(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
