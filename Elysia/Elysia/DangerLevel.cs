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
            dgvDangerLevel.Columns[3].ReadOnly = false;

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
        }

        private void reloadDataGridView()
        {
            string query = "SELECT partID, categoryID, partName, price, partQty, partStatus FROM part";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvDangerLevel.DataSource = ds.Tables[0];

                    // Add the "dangerLevelColumn" to the DataTable
                    ds.Tables[0].Columns.Add("dangerLevel", typeof(int));
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int partQty = (int)row["partQty"];
                        int dangerLevel = 0;
                        if (partQty <= 30000)
                        {
                            dangerLevel = 30000 - partQty;
                        }
                        else if (partQty <= 50000)
                        {
                            dangerLevel = 50000 - partQty;
                        }
                        row["dangerLevel"] = dangerLevel;
                    }

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
                int dangerLevel = (int)dgvDangerLevel.Rows[e.RowIndex].Cells["dangerLevel"].Value;

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
                Reorder reorder = new Reorder();
                reorder.Show();
                this.Close();
            }
        }



    }
}
