using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elysia
{
    public partial class DataGridViewExample : Form
    {
        public DataGridViewExample()
        {
            InitializeComponent();
            setDataGridView();
        }
        private void setDataGridView()
        {
            string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
            string query = "SELECT * FROM emp";

            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using(MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
