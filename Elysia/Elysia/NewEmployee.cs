using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Elysia
{
    public partial class NewEmployee : UserControl
    {
        public static string connectionString = "server=localhost;database=elysia;user=root;password=''";

        public NewEmployee()
        {
            InitializeComponent();
        }
        public void LoadInformation()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load deptIDs
                cmd.CommandText = "SELECT * FROM dept";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    deptn.Items.Clear();

                    while (reader.Read())
                    {
                        deptn.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        public void updateEmpID(string category)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT MAX(empID) FROM `emp`";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        var maxEmpID = reader2[0];
                        if (maxEmpID != null && maxEmpID != DBNull.Value)
                        {
                            lblEmpID.Text = $"E{int.Parse(maxEmpID.ToString().Substring(1)) + 1:D5}";
                            return;
                        }
                    }
                }
            }
        }
        private void phoneValidate(object sender, EventArgs e)
        {
            int result;
            bool isNumeric = int.TryParse(tbPhoneNumber.Text, out result);
            if (!isNumeric || tbPhoneNumber.Text.Length != 8)
            {
                MessageBox.Show("The phone number is invalid.", "Error");
                tbPhoneNumber.Text = "";
            }
        }
        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            if (Regex.IsMatch(tbEmail.Text, emailPattern))
            {
                // Email is valid
            }
            else
            {
                // Email is not valid
                MessageBox.Show("Please enter a valid email address.");
                e.Cancel = true;
            }
        }


    }
}
