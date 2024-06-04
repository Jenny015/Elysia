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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Elysia
{
    public partial class ViewLateDeleveryAlarm : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewLateDeleveryAlarm()
        {
            InitializeComponent();
            reloadDataGridView();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnLateDelivery.Checked = true;
            dgvLateDelivery.AllowUserToAddRows = false;
            dgvLateDelivery.ReadOnly = true;

            lblDept.Text = StaticVariable.dept_full();
            btnLateDelivery.Checked = true;
            if (StaticVariable.dept == "SD")
            {
                btnViewInvoice.Visible = true;
                btnInvGen.Visible = true;
            }
            else {
                btnDID.Visible = true;
                btnSparePart.Visible = true;
        }
    }
        private void reloadDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT orderID, dealerID, orderStatus, orderDate " +
                               "FROM `order` " +
                               "WHERE orderStatus <> 'Despatched' AND orderDate < CURDATE()";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvLateDelivery.DataSource = dataTable;
                        dgvLateDelivery.CellFormatting += dgvLateDelivery_CellFormatting;
                    }
                }
            }
        }
        private void dgvLateDelivery_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
{
            if (e.ColumnIndex == dgvLateDelivery.Columns["orderStatus"].Index)
            {
                string orderStatus = e.Value.ToString();

                // Set the background color based on the orderStatus value
                switch (orderStatus)
                {
                    case "Cancelled":
                        e.CellStyle.BackColor = Color.Red;
                        break;
                    case "Processing":
                        e.CellStyle.BackColor = Color.Orange;
                        break;
                    case "Assembled":
                        e.CellStyle.BackColor = Color.Yellow;
                        break;
                    case "Despatched":
                        e.CellStyle.BackColor = Color.LightGreen;
                        break;
                    case "OStanding":
                        e.CellStyle.BackColor = Color.Plum;
                        break;
                    default:
                        e.CellStyle.BackColor = dgvLateDelivery.DefaultCellStyle.BackColor;
                        break;
                }
            }
        }
    }
}
