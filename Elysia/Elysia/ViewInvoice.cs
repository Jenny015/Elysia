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

namespace Elysia
{
    public partial class ViewInvoice : Form
    {
        private string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewInvoice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            reloadDataGridView("");
            setDataGridView();
            lblDept.Text = StaticVariable.dept_full();
            btnViewInvoice.Checked = true;
            if (StaticVariable.dept == "SD")
            {
                btnIG.Visible = true;
                btnLD.Visible = true;
                btnVO.Visible = true;
            }
        }

        private void reloadDataGridView(String query)
        {
            query = query == "" ? "SELECT * FROM `invoice` ORDER BY invStatus DESC" : query;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvInv.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "View";
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "View";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dgvInv.Columns.Add(buttonColumn);

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.UseColumnTextForButtonValue = true;
            if (StaticVariable.dept == "IS")
            {
                buttonColumn2.HeaderText = "Sign";
                buttonColumn2.Name = "Sign";
                buttonColumn2.Text = "Sign";
            } else if (StaticVariable.dept == "SD")
            {
                buttonColumn2.HeaderText = "Send";
                buttonColumn2.Name = "Send";
                buttonColumn2.Text = "Send";
            }
            dgvInv.Columns.Add(buttonColumn2);
            reloadDataGridView("");

        }
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
