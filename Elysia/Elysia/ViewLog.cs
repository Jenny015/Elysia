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

namespace Elysia
{
    public partial class ViewLog : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        private Filter filter;
        public ViewLog()
        {
            InitializeComponent();
            reloadDataGridView("");
            dgvAcc.ReadOnly = true;
        }
        private void reloadDataGridView(string query)
        {
            query = query == "" ? "SELECT * FROM `log`" : query;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvAcc.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            /*reference InvoiceGenerate line 148-167
            double totalPrice = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                totalPrice += Double.Parse(row.Cells["Subtotal"].Value.ToString());
            }
            lblPrice.Text = totalPrice.ToString("N2");*/
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("log");
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
