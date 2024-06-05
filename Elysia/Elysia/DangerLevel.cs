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
    public partial class DangerLevel : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public DangerLevel()
        {
            InitializeComponent();
            reloadDataGridView();
            dgvDangerLevel.AllowUserToAddRows = false;
            dgvDangerLevel.ReadOnly = true;
        }
        private void reloadDataGridView()
        {
            string query = "SELECT p.partID, categoryID, partName, purPrice, partQty, partStatus FROM part p, supplierPart sp WHERE p.partID = sp.partID AND partStatus != 'Normal' ORDER BY p.partID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvDangerLevel.DataSource = ds.Tables[0];

                    // Subscribe to the CellFormatting event
                    dgvDangerLevel.CellFormatting += dgvDangerLevel_CellFormatting;
                }
            }
        }

        private void dgvDangerLevel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvDangerLevel.Columns["partStatus"].Index)
            {
                string partStatus = dgvDangerLevel.Rows[e.RowIndex].Cells["partStatus"].Value.ToString();

                if (partStatus == "Out-of-stock")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (partStatus == "Danger")
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                else if (partStatus == "Reorder")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (partStatus == "Normal")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
            }
            dgvDangerLevel.Columns["purPrice"].DefaultCellStyle.Format = "N2";
            dgvDangerLevel.Columns["partQty"].DefaultCellStyle.Format = "N0";
        }
    }
}
