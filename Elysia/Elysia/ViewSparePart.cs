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
    public partial class ViewSparePart : Form
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewSparePart()
        {
            InitializeComponent();
            reloadDataGridView("");
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnViewOrder.Checked = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `part` ORDER BY partID" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvPart.DataSource = ds.Tables[0];

                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("part");
            filter.Query += filter_Query;
            filter.Show();
        }

        private void filter_Query(object sender, EventArgs e)
        {
            string query = filter.queryString;
            reloadDataGridView(query);
        }
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnDID_CheckedChanged(object sender, EventArgs e)
        {
            ViewDID did = new ViewDID();
            did.Show();
            this.Close();
        }
    }
}
