using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewSupplier : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewSupplier()
        {
            InitializeComponent();
            reloadDataGridView("");
            setDataGridView();
            dgvSupplier.Columns[0].ReadOnly = true;


        }
        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT supplierID, sComName  FROM `supplier` ORDER BY supplierID" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvSupplier.DataSource = ds.Tables[0];

                }
            }
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Detail";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Detail";
            buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

            // Add the button column to the DataGridView
            dgvSupplier.Columns.Add(buttonColumn);
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("Sup");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, EventArgs e)
        {
            reloadDataGridView(filter.queryString);
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                // Check if the click is on the button column
                if (e.ColumnIndex == dgvSupplier.Columns["buttonColumn"].Index && e.RowIndex >= 0)
                {
                    String supplierID = dgvSupplier.Rows[e.RowIndex].Cells["supplierID"].Value.ToString();
                    ViewSupplierPart spp = new ViewSupplierPart(supplierID);
                    this.Controls.Clear();
                    this.Controls.Add(spp);
                    this.Refresh();
                }
            }
        }
    }
}
