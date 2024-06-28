using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewSupplierPart : UserControl
    {
        private Filter filter;
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        String supplierID = "";
        public ViewSupplierPart(String supplier)
        {
            InitializeComponent();
            supplierID = supplier;
            dgvSupplierPart.ReadOnly = true;
            reloadDataGridView();
            setDataGridView();
        }
        private void reloadDataGridView()
        {
            String query = $"SELECT sp.partID,p.partName,sp.purprice FROM `supplierPart` sp,part p WHERE sp.partID = p.partID AND sp.supplierID = '{supplierID}'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvSupplierPart.DataSource = ds.Tables[0];

                }
            }
        }
        private void setDataGridView()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `supplier` WHERE supplierID = '{supplierID}';";
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sppID.Text = reader.GetString(0);
                            spptCompany.Text = reader.GetString(1);
                            spptAddress.Text = reader.GetString(2);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            sppID.Text = supplierID;
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter = new Filter("spp", supplierID);
            filter.Query += filter_Query;
            filter.Show();
        }
        private void filter_Query(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the INSERT query
                    string query = filter.queryString;

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Supplier Part information added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier part information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewSupplier supplier = new ViewSupplier();
            this.Controls.Clear();
            this.Controls.Add(supplier);
            this.Refresh();
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            filter = new Filter("spp", supplierID);
            filter.Query += filter_Query;
            filter.Show();
        }
    }
}
