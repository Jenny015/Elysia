using System;
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
    public partial class viewDID : Form
    {
        public viewDID()
        {
            InitializeComponent();
            setDataGridView();
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

        }
        private void setDataGridView()
        {
            string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
            string query = "SELECT * FROM orderpart WHERE opStatus = 'Processing'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;


                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "Assemble";
                    buttonColumn.Name = "buttonColumn";
                    buttonColumn.Text = "Assemble";
                    buttonColumn.UseColumnTextForButtonValue = true; // This will set the button text to "Click Me"

                    // Add the button column to the DataGridView
                    dataGridView1.Columns.Add(buttonColumn);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the button column
            if (e.ColumnIndex == dataGridView1.Columns["buttonColumn"].Index && e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                String actDespQtyData = row.Cells["actDespQty"].Value.ToString();

                // Check if the 'actDespQty' data is not null
                if (actDespQtyData == "")
                {
                    // Perform the action you want to take when the button is clicked
                    MessageBox.Show("The 'actDespQty' value is NULL.");

                }
            }
        }
    }
}
