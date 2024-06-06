using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class EvaluatedList : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        private Filter filter;


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
    }
}


