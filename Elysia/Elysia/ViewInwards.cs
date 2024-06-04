using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewInwards : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        private Filter filter;
        string inwardsID;
        public ViewInwards()
        {
            InitializeComponent();
            reloadDataGridView("");
            setDataGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnViewGoodsInward.Checked = true;
            dgvGI.ReadOnly = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Detail";
            buttonColumn.Name = "btnDetail";
            buttonColumn.Text = "Detail";
            buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

            // Add the button column to the DataGridView
            dgvGI.Columns.Add(buttonColumn);
        }
        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `inwardsOrder` ORDER BY inwardsDate DESC" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvGI.DataSource = ds.Tables[0];
                }
            }
        }
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("inward");
            filter.Query += filter_Query;
            filter.Show();
        }
        private void filter_Query(object sender, EventArgs e)
        {
            string query = filter.queryString;
            reloadDataGridView(query);
            int columnIndex = dgvGI.Columns["btnDetail"].Index;
            int lastPosition = dgvGI.Columns.Count - 1;
            dgvGI.Columns[columnIndex].DisplayIndex = lastPosition;
        }

        private void btnGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            GoodsInward gi = new GoodsInward();
            gi.Show();
            this.Close();
        }
        private void dgvGI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dgvGI.Columns["btnDetail"].Index && e.RowIndex >= 0)
                {
                    btnFilter.Visible = false;
                    btnBack.Visible = true;
                    inwardsID = dgvGI.Rows[e.RowIndex].Cells["inwardsID"].Value.ToString();
                    reloadDataGridView($"SELECT `io`.inwardsID, `io`.supplierID, `io`.inwardsDate, `ip`.partID, `ip`.iwQty FROM inwardsorder `io`, inwardspart `ip` WHERE `io`.inwardsID = `ip`.inwardsID AND `io`.`inwardsID` = '{inwardsID}';");
                    dgvGI.Columns["btnDetail"].Visible = false;
                }
            }
        }
        //display dgv, hide detailed
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnFilter.Visible = true;
            btnBack.Visible = false;
            reloadDataGridView("");
            dgvGI.Columns["btnDetail"].Visible = true;
        }
    }
}
