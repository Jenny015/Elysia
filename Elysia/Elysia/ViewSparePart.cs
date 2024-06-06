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
    public partial class ViewSparePart : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewSparePart()
        {
            InitializeComponent();
            reloadDataGridView("");
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
            string query = "SELECT p.* FROM `part` p, `category` c WHERE p.categoryID = c.categoryID " + filter.queryString;
            reloadDataGridView(query);
        }
    }
}
