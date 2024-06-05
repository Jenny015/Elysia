using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewInvoice : UserControl
    {
        private Filter filter;
        private string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewInvoice()
        {
            InitializeComponent();
            reloadDataGridView("");
            dgvInv.ReadOnly = true;
            setDataGridView();
        }

        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT orderID, invStatus FROM `invoice` ORDER BY invStatus DESC" : query;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvInv.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Download Invoice";
            buttonColumn.Name = "Download";
            buttonColumn.Text = "Download";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvInv.Columns.Add(buttonColumn);


            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.UseColumnTextForButtonValue = true;
            if (StaticVariable.dept == "IS")
            {
                buttonColumn2.HeaderText = "Upload";
                buttonColumn2.Name = "Upload";
                buttonColumn2.Text = "Upload";
            }
            else
            {
                buttonColumn2.HeaderText = "Send";
                buttonColumn2.Name = "Send";
                buttonColumn2.Text = "Send";
            }
            dgvInv.Columns.Add(buttonColumn2);
            reloadDataGridView("");

        }
        private void dgvInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderID = dgvInv.Rows[e.RowIndex].Cells["orderID"].Value.ToString();
            //Download invoice
            if (e.ColumnIndex == dgvInv.Columns["Download"].Index && e.RowIndex >= 0)
            {
                byte[] pdfData = null;
                string query = $"SELECT invoice, signedInvoice FROM invoice WHERE orderID = '{orderID}'";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            pdfData = reader.IsDBNull(reader.GetOrdinal("signedInvoice")) ? (byte[])reader["invoice"] : (byte[])reader["signedInvoice"];
                        }
                    }
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        string startupPath = Application.StartupPath;
                        string invoicePath = Path.GetFullPath(Path.Combine(startupPath, @"..\..\..\invoice\"));

                        Directory.CreateDirectory(invoicePath);
                        saveFileDialog.Filter = "PDF Files|*.pdf";
                        saveFileDialog.Title = "Save Invoice PDF";
                        saveFileDialog.InitialDirectory = invoicePath;
                        saveFileDialog.FileName = $"{orderID}.pdf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filename = saveFileDialog.FileName;
                            File.WriteAllBytes(filename, pdfData);
                            MessageBox.Show($"Invoice of {orderID} downloaded successfully.", "Success");
                        }
                    }
                }
            }
            else if (e.ColumnIndex == dgvInv.Columns["Upload"].Index && e.RowIndex >= 0) //Upload signed invoice
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "PDF Files|*.pdf";
                    openFileDialog.Title = $"Upload Signed Invoice of {orderID}";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        byte[] pdfData = File.ReadAllBytes(filePath);
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            string query = "UPDATE invoice SET signedInvoice = @pdfData, invStatus = 'Sign' WHERE orderID = @orderID";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@pdfData", pdfData);
                                cmd.Parameters.AddWithValue("@orderID", orderID);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        MessageBox.Show($"Invoice of {orderID} uploaded successfully!", "Success!");
                    }
                }
            }
            else if (e.ColumnIndex == dgvInv.Columns["Send"].Index && e.RowIndex >= 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE invoice SET invStatus = 'Send' WHERE orderID = @orderID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("invoice");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }
    }
}
