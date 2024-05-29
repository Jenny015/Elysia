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
    public partial class InvoiceGenerateAndDelivery : Form
    {
        private MySqlConnection cnn = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";");
        private Filter filter;
        public InvoiceGenerateAndDelivery()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnInvGen.Checked = true;
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.ReadOnly = true;
            LoadDataFromDatabase("");
            setDataGridView();
        }
        private void LoadDataFromDatabase(string query)
        {
            if(query == "")
            {
                query = "SELECT * FROM `order`";
            }
            using (MySqlCommand cmd = new MySqlCommand(query, cnn))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dgvOrder.DataSource = dt;
                }
            }
        }
        private void setDataGridView()
        {
            LoadDataFromDatabase("");
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Detail";
            buttonColumn.Name = "detailButton";
            buttonColumn.Text = "...";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvOrder.Columns.Add(buttonColumn);

            //set background color
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("Order");
            filter.Query += filter_Query;
            filter.Show();
        }

        private void filter_Query(object sender, EventArgs e)
        {
            string query = filter.queryString;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex % 2 == 0)
            {
                dgvOrder.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }
    }
}
