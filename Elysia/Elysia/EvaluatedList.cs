using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Elysia
{
    public partial class EvaluatedList : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";

        public EvaluatedList()
        {
            InitializeComponent();
            reloadDataGridView("");
        }

        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT p.partID, p.partName, p.partQty, sp.purPrice, (partQty*purPrice) AS Subtotal FROM part p,  supplierpart sp  WHERE P.partID = sp.partID ORDER BY p.partID" : query;
            try
            {
                DataSet ds = new DataSet();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(ds);
                    }
                }

                dgvEv.DataSource = ds.Tables[0];
                dgvEv.Columns["partQty"].DefaultCellStyle.Format = "N0";
                dgvEv.Columns["Subtotal"].DefaultCellStyle.Format = "N2";

                double totalPrice = 0;
                foreach (DataGridViewRow row in dgvEv.Rows)
                {
                    totalPrice += Convert.ToDouble(row.Cells["Subtotal"].Value);
                }
                lblTotal.Text = totalPrice.ToString("N2");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            Directory.CreateDirectory("../../../evaluatedList");
            string fileName = "EvaluatedList_"+DateTime.Today.ToString("yyyyMMdd");
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"../../../evaluatedList/{fileName}.pdf", FileMode.Create));
            document.Open();

            iTextSharp.text.Font boldFont = FontFactory.GetFont("Times-Roman", 12, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font normalFont = FontFactory.GetFont("Times-Roman", 12);

            Paragraph header = new Paragraph("Legend Motor (LC) Limited Company", FontFactory.GetFont("Times New Roman", 16, iTextSharp.text.Font.BOLD));
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            document.Add(new Paragraph(" ", normalFont));

            PdfPTable table = new PdfPTable(dgvEv.ColumnCount);
            table.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            table.LockedWidth = true;
            foreach (DataGridViewColumn col in dgvEv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.Name, boldFont));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5;
                table.AddCell(cell);
            }

            for (int r = 0; r < dgvEv.RowCount; r++)
            {
                for (int c = 0; c < dgvEv.ColumnCount; c++)
                {
                    PdfPCell cell;
                    if (c == 2)
                    {
                        // Format the value with thousand separators
                        double value = Convert.ToDouble(dgvEv.Rows[r].Cells[c].Value);
                        string formattedValue = value.ToString("N0", CultureInfo.InvariantCulture);

                        cell = new PdfPCell(new Phrase(formattedValue, normalFont));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    }
                    else if (c > 2) 
                    {
                        double value = Convert.ToDouble(dgvEv.Rows[r].Cells[c].Value);
                        string formattedValue = value.ToString("N2", CultureInfo.InvariantCulture);

                        cell = new PdfPCell(new Phrase(formattedValue, normalFont));
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    }
                    else
                    {
                        // For other columns, add the value as is
                        cell = new PdfPCell(new Phrase(dgvEv.Rows[r].Cells[c].Value.ToString(), normalFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    }
                    cell.BackgroundColor = r % 2 == 0 ? new BaseColor(220, 220, 220): BaseColor.WHITE;
                    cell.Padding = 5;
                    table.AddCell(cell);
                }
            }
            document.Add(table);

            document.Add(new Paragraph(" ", normalFont));

            Paragraph total = new Paragraph(label1.Text + lblTotal.Text.ToString(), boldFont);
            total.Alignment = Element.ALIGN_RIGHT;
            document.Add(total);

            document.Add(new Paragraph(" ", normalFont));

            Paragraph date = new Paragraph("Printed at: "+ DateTime.Today.ToString("d"), normalFont);
            date.Alignment = Element.ALIGN_LEFT;
            document.Add(date);

            document.Close();
            MessageBox.Show($"Evaluated List: {fileName}.PDF is generate successfully.", "Success");
        }

        private void btnSaveAsCSV_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string[] columnNames = dgvEv.Columns.Cast<DataGridViewColumn>()
                .Select(column => $"\"{column.HeaderText}\"").ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataGridViewRow row in dgvEv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] fields = row.Cells.Cast<DataGridViewCell>()
                        .Select(cell => cell.Value.ToString()).ToArray();
                    sb.AppendLine(string.Join(",", fields));
                }
            }
            string fileName = "EvaluatedList_" + DateTime.Today.ToString("yyyyMMdd");
            string outputDirectory = "../../../evaluatedList";
            Directory.CreateDirectory(outputDirectory);
            string filePath = Path.Combine(outputDirectory, $"{fileName}.csv");
            File.WriteAllText(filePath, sb.ToString());
            MessageBox.Show($"Evaluated List: {fileName}.CSV is generate successfully.", "Success");
        }
    }
}


