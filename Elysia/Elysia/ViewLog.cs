using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Elysia
{
    public partial class ViewLog : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        private Filter filter;
        public ViewLog()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvAcc.ReadOnly = true;
            reloadDataGridView("");
            this.WindowState = FormWindowState.Maximized;

            lblDept.Text = StaticVariable.dept_full();
            btnViewLog.Checked = true;
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
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
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
