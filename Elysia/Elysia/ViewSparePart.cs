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
            dgvPart.Columns[0].ReadOnly = true;
            dgvPart.Columns[1].ReadOnly = true;
            dgvPart.Columns[5].ReadOnly = true;
        }

        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `part` ORDER BY partID" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet(); 
                    ds.Clear();
                    adapter.Fill(ds);
                    dgvPart.DataSource = ds.Tables[0];
                }
                dgvPart.Columns["partQty"].DefaultCellStyle.Format = "N0";
                dgvPart.Columns["price"].DefaultCellStyle.Format = "N2";
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

        private void dgvPart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = dgvPart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            string primaryKey = dgvPart.Rows[e.RowIndex].Cells["partID"].Value.ToString();
            string updateCommand = $"UPDATE part SET {dgvPart.Columns[e.ColumnIndex].Name} = {newValue} WHERE partID = '{primaryKey}'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateCommand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            if (e.ColumnIndex == 4) {
                StaticVariable.updatePartStatus(primaryKey);
             }
            reloadDataGridView("");
        }
    }
}
