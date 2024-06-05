using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewDealer : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewDealer()
        {
            InitializeComponent();
            reloadDataGridView();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            this.WindowState = FormWindowState.Maximized;
            btnViewDealer.Checked = true;
            dgvViewDealer.AllowUserToAddRows = false;
            dgvViewDealer.ReadOnly = true;

        }

        private void reloadDataGridView()
        {
            string query = "SELECT * FROM dealer";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvViewDealer.DataSource = ds.Tables[0];


                }
            }
        }




        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
