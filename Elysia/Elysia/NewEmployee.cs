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
            LoadInformation();
            updateEmpID();
        }
        public void LoadInformation()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                //load deptIDs
                cmd.CommandText = "SELECT deptName FROM dept";
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

        public void updateEmpID()
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
        private void Gander_choosed(object sender, EventArgs e)
        {


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
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEmpName.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbPosition.Text = "";
            tbPassword.Text = "";

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                MessageBox.Show("Every fields should be inputted", "Error");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                var dept;
                switch (deptn.SelectedItem.ToString())
                {
                    case "Sales Office":
                        dept = "SO";
                        break;
                    case "Spare Parts Store":
                        dept = "SP";
                        break;
                    case "Spares Despatch Department":
                        dept = "SD";
                        break;
                    case "Invoicing Section":
                        dept = "IS";
                        break;
                    case "Stock Record Clerk":
                        dept = "SR";
                        break;
                    case "Purchasing Department":
                        dept = "PD";
                        break;
                    case "Goods Inward Department":
                        dept = "GI";
                        break;
                    case "Human Resources":
                        dept = "HR";
                        break;
                    case "Accountant":
                        dept = "AC";
                        break;
                }
                conn.Open();

                var gender = f.Checked ? "F" : "M";

                // Prepare the INSERT query
                string insertQuery = "INSERT INTO part VALUES (@empID, @empName, @empGander, @empPhone, @empEmail, @deptID, @empPosition, @empPasswd, @empStatus)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@empID", lblEmpID.Text);
                    cmd.Parameters.AddWithValue("@empName", tbEmpName.Text);
                    cmd.Parameters.AddWithValue("@empGander", gender);
                    cmd.Parameters.AddWithValue("@empPhone", tbPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@empEmail", tbEmail.Text);
                    cmd.Parameters.AddWithValue("@deptID", dept);
                    cmd.Parameters.AddWithValue("@empPosition", tbPosition.Text);
                    cmd.Parameters.AddWithValue("@empPasswd", tbPassword.Text);



                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Spare Part information added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, null);
            }
        }
        private bool checkInput()
        {
            if (tbEmpName.Text != "" && tbPhoneNumber.Text != "" && tbEmail.Text != "" && tbPosition.Text != "" && tbPassword.Text != "")
            {
                return true;
            }
            return false;
        }

    }
}
