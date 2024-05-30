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
                        dataGridVieworder.DataSource = ds.Tables[0];
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
            string query = "SELECT * FROM emp";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridVieworder.DataSource = ds.Tables[0];
                        dataGridVieworder.Columns[0].ReadOnly = true;

                        if (!dataGridVieworder.Columns.Contains("buttonColumn"))
                        {
                            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                            buttonColumn.HeaderText = "Assemble";
                            buttonColumn.Name = "buttonColumn";
                            buttonColumn.Text = "Assemble";
                            buttonColumn.UseColumnTextForButtonValue = true;
                            dataGridVieworder.Columns.Add(buttonColumn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
