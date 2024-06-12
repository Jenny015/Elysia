using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Elysia
{
    public partial class InvoiceGenerate : UserControl
    {
        String connectionString = "server=localhost;database=elysia;uid=root;pwd=\"\";";
        private Filter filter; //filter
        private string orderID;
        public InvoiceGenerate()
        {
            InitializeComponent();
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.ReadOnly = true;
            LoadDataFromDatabase("");
            setDataGridView();
        }
        private void LoadDataFromDatabase(string query)
        {
            if (query == "")
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
            buttonColumn.Text = "Detail";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvOrder.Columns.Add(buttonColumn);

            //set background color
        }
        //filter
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("Order");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, EventArgs e)
        {
            LoadDataFromDatabase(filter.queryString);
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgvOrder.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }// hide the dgv and display the detailed of order
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
                    btnPDF.Visible = true;
                    btnBack.Visible = true;
                    InvPreview.Visible = true;
                    heading.Visible = true;
                    footer.Visible = true;
                    orderID = dgvOrder.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                    setInvoice(orderID);
                }
            }
        }
        //display dgv, hide detailed
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnFilter.Visible = true;
            dgvOrder.Visible = true;
            btnPDF.Visible = false;
            btnBack.Visible = false;
            InvPreview.Visible = false;
            heading.Visible = false;
            footer.Visible = false;
            LoadDataFromDatabase("");
        }
        //set components of detail page
        private void setInvoice(String orderID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT O.orderDate, D.dCompany, D.dName, D.dPhone, D.dComAdd, D.dDelivAdd FROM `order` O, `orderpart` OP, dealer D, part P WHERE O.orderID = OP.orderID AND O.dealerID = D.dealerID AND P.partID = OP.partID AND O.orderID = '{orderID}';";
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
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
        //generate invoice as pdf file
        private void btnPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string invoicePath = $"{documentsPath}\\Elysia\\invoice\\";
            Directory.CreateDirectory(invoicePath);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"{invoicePath}{orderID}.pdf", FileMode.Create));
            document.Open();

            Paragraph header = new Paragraph(compName.Text, FontFactory.GetFont("Times New Roman", 16, iTextSharp.text.Font.BOLD));
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            iTextSharp.text.Font boldFont = FontFactory.GetFont("Times-Roman", 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font normalFont = FontFactory.GetFont("Times-Roman", 12);

            string[] leftComponent = { "BOrderID", "lblOrderID", "BOrderDate", "lblOrderDate", "BDCom", "lblDCom", "BDName", "lblDName", "BDPhone", "lblDPhone", "BDAddr", "lblAddr" };
            string[] rightComponent = { "BAddr", "addr", "Btel", "tel", "Bemail", "email" };

            List<Control> leftComponentList = leftComponent.Select(controlName => InvPreview.Controls[controlName]).ToList();
            List<Control> rightComponentList = rightComponent.Select(controlName => InvPreview.Controls[controlName]).ToList();

            float columnWidth = document.PageSize.Width / 2;
            float columnHeight = document.PageSize.Height - 72;
            iTextSharp.text.Rectangle leftColumnRect = new iTextSharp.text.Rectangle(60, 60, columnWidth, columnHeight);
            iTextSharp.text.Rectangle rightColumnRect = new iTextSharp.text.Rectangle(columnWidth + 60, 60, document.PageSize.Width - 60, columnHeight);

            ColumnText left = new ColumnText(writer.DirectContent);
            left.SetSimpleColumn(leftColumnRect);
            for (int i = 0; i < leftComponentList.Count; i += 2)
            {
                Phrase p = new Phrase();
                p.Add(new Chunk(leftComponentList[i].Text, boldFont));
                p.Add(new Chunk(leftComponentList[i + 1].Text, normalFont));
                left.AddElement(p);
            }
            left.Go();

            ColumnText right = new ColumnText(writer.DirectContent);
            right.SetSimpleColumn(rightColumnRect);
            for (int i = 0; i < rightComponentList.Count; i += 2)
            {
                Phrase p = new Phrase();
                p.Add(new Chunk(rightComponentList[i].Text, boldFont));
                p.Add(new Chunk(rightComponentList[i + 1].Text, normalFont));
                right.AddElement(p);
            }
            right.Go();

            float yPos = Math.Min(left.YLine, right.YLine) - 10;

            PdfPTable table = new PdfPTable(dgv.ColumnCount);
            table.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            table.LockedWidth = true;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.Name, boldFont));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5;
                table.AddCell(cell);
            }
            for (int r = 0; r < dgv.RowCount; r++)
            {
                for (int c = 0; c < dgv.ColumnCount; c++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dgv.Rows[r].Cells[c].Value.ToString(), normalFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }
            }
            table.WriteSelectedRows(0, -1, document.LeftMargin, yPos, writer.DirectContent);
            float endPositionFirstTable = yPos - table.TotalHeight;
            if (yPos - table.TotalHeight < document.BottomMargin)
            {
                document.NewPage();
                yPos = document.PageSize.Height - document.TopMargin;
            }
            PdfPTable newTable = new PdfPTable(4);
            PdfPCell cell1 = new PdfPCell(new Phrase(BItems.Text, boldFont));
            PdfPCell cell2 = new PdfPCell(new Phrase(lblItems.Text, normalFont));
            PdfPCell cell3 = new PdfPCell(new Phrase(BPrice.Text, boldFont));
            PdfPCell cell4 = new PdfPCell(new Phrase(lblPrice.Text, normalFont));
            cell1.Border = PdfPCell.NO_BORDER;
            cell2.Border = PdfPCell.NO_BORDER;
            cell3.Border = PdfPCell.NO_BORDER;
            cell4.Border = PdfPCell.NO_BORDER;
            newTable.AddCell(cell1);
            newTable.AddCell(cell2);
            newTable.AddCell(cell3);
            newTable.AddCell(cell4);
            newTable.DefaultCell.Border = PdfPCell.NO_BORDER;
            newTable.TotalWidth = (float)((document.PageSize.Width - document.LeftMargin - document.RightMargin) / 1.5);
            newTable.LockedWidth = true;

            float startPositionNewTable = endPositionFirstTable - 20;
            if (startPositionNewTable < document.BottomMargin + 20)
            {
                document.NewPage();
                startPositionNewTable = document.PageSize.Height - document.TopMargin - 20;
            }

            newTable.WriteSelectedRows(0, -1, document.LeftMargin, startPositionNewTable, writer.DirectContent);
            float endPositionNewTable = startPositionNewTable - newTable.TotalHeight;
            if (endPositionNewTable < document.BottomMargin)
            {
                document.NewPage();
                endPositionNewTable = document.PageSize.Height - document.TopMargin;
            }

            ColumnText signColumn = new ColumnText(writer.DirectContent);
            signColumn.SetSimpleColumn(new Phrase(Bsign.Text + "___________________", boldFont), document.LeftMargin, endPositionNewTable - 20, document.PageSize.Width - document.RightMargin, 0, 15, Element.ALIGN_RIGHT);
            signColumn.Go();
            document.Close();
            MessageBox.Show("Invoice is generate successfully.", "Success");
            uploadPdfToSql();
        }
        //upload invoice to sql
        private void uploadPdfToSql()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = $"SELECT orderStatus FROM `order` WHERE orderID = '{orderID}'";
                if ((string)cmd.ExecuteScalar() == "Assembled")
                {
                    byte[] pdfBytes;
                    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string invoicePath = $"{documentsPath}\\Elysia\\invoice\\";
                    Directory.CreateDirectory(invoicePath);
                    using (FileStream fs = new FileStream($"{invoicePath}{orderID}.pdf", FileMode.Open, FileAccess.Read))
                    {
                        pdfBytes = new byte[fs.Length];
                        fs.Read(pdfBytes, 0, pdfBytes.Length);
                    }
                    // Upload pdf to MySql by bytes
                    cmd.CommandText = $"INSERT INTO invoice (orderID, invoice, invStatus) VALUES ('{orderID}', @pdfData, 'Wait'); ";
                    cmd.Parameters.AddWithValue("@pdfData", pdfBytes);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"Update `order` SET orderStatus = 'Despatched' WHERE orderID = '{orderID}';";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}