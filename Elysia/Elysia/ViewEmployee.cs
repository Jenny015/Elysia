using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewEmployee : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewEmployee()
        {
            InitializeComponent();
            reloadDataGridView("");
            dgvEmp.Columns[0].ReadOnly = true;
            dgvEmp.Columns[1].ReadOnly = true;
            
        }

        private void reloadDataGridView(string query)
        {
            query = query == "" ? "SELECT empID, empName, empGander, empPhone, empEmail, deptID, empPostion, empStatus FROM emp" : query;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvEmp.DataSource = ds.Tables[0];
                }
            }
        }

        private void dgvEmp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = dgvEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            string primaryKey = dgvEmp.Rows[e.RowIndex].Cells["empID"].Value.ToString();
            string updateCommand = $"UPDATE part SET {dgvEmp.Columns[e.ColumnIndex].Name} = {newValue} WHERE empID = '{primaryKey}'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(updateCommand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

            private void btnFilter_Click(object sender, System.EventArgs e )
        {
            filter = new Filter("emp");
            filter.Query += filter_Query;
            filter.Show();
        }
        //filter
        private void filter_Query(object sender, System.EventArgs e )
        {
            reloadDataGridView(filter.queryString);
        }
    }
}
