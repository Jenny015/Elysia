using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Elysia
{
    public partial class DangerLevel : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public DangerLevel()
        {
            InitializeComponent();
            setDataGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnDangerLevel.Checked = true;
            dgvDangerLevel.AllowUserToAddRows = false;
            dgvDangerLevel.ReadOnly = true;

        }

        private void setDataGridView()
        {
            reloadDataGridView();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Reorder";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Reorder";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvDangerLevel.Columns.Add(buttonColumn);

            dgvDangerLevel.Columns["purPrice"].DefaultCellStyle.Format = "N2";
            dgvDangerLevel.Columns["partQty"].DefaultCellStyle.Format = "N0";
        }

        private void reloadDataGridView()
        {
            string query = "SELECT p.partID, categoryID, partName, purPrice, partQty, partStatus FROM part p, supplierPart sp WHERE p.partID = sp.partID ORDER BY p.partID";

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
        }
        private void dgvDangerLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDangerLevel.Columns["buttonColumn"].Index)
            {
                // Navigate to the Reorder form
                Reorder reorder = new Reorder(dgvDangerLevel.Rows[e.RowIndex].Cells["partID"].Value.ToString(), StaticVariable.reOrder - (int)dgvDangerLevel.Rows[e.RowIndex].Cells["partQty"].Value);
                reorder.Show();
                this.Close();
            }
        }



    }
}
