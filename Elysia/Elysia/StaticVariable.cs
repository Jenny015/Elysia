using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    //To store global variable that every form could access to
    public static class StaticVariable
    {
        public static string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public static readonly int reOrder = 50000;
        public static readonly int danger = 30000;
        public static readonly int outOfStock = 0;
        //Store the user's department in short form
        public static string dept { get; set; }
        //Return the full name of department
        public static string empID { get; set; }
        public static string dept_full()
        {
            switch (dept)
            {
                case "SO":
                    return "Sales Office";
                case "SP":
                    return "Spare Parts Store";
                case "SD":
                    return "Spares Despatch Department";
                case "IS":
                    return "Invoicing Section";
                case "SR":
                    return "Stock Record Clerk";
                case "PD":
                    return "Purchasing Department";
                case "GI":
                    return "Goods Inward Department";
                case "HR":
                    return "Human Resources";
                case "AC":
                    return "Accountant";
                case "AD":
                    return "Admin";
                default:
                    return "";
            }
        }

        public static void logout()
        {
            Login login = new Login();
            login.Show();
        }
        public static void displayContent(Control control, UserControl userControl)
        {
            control.Controls.Clear();
            control.Controls.Add(userControl);
            control.Refresh();
        }

        public static void updatePartStatus(String partID)
        {
            string status = "Normal";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT partQty FROM part WHERE partID = '{partID}'";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        int partQty = Convert.ToInt32(reader2[0]);
                        if (partQty == outOfStock)
                        {
                            status = "Out-of-stock";
                        }
                        else if (partQty < reOrder)
                        {
                            status = "Reorder";
                        }
                        else if (partQty < danger)
                        {
                            status = "Danger";
                        }
                    }
                    reader2.Close();
                    cmd.CommandText = $"UPDATE part SET partStatus = '{status}' WHERE partID = '{partID}'";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateAllOutstandingOrders()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to select all orders with 'OStanding' status
                    string selectOrdersQuery = @"SELECT orderID FROM `order` WHERE orderStatus = 'OStanding'";

                    // SQL query to check if all orderpart records for the order do not have 'OStanding' status
                    string checkStatusQuery = @"SELECT COUNT(*) FROM orderpart WHERE orderID = @OrderId AND opStatus = 'OStanding'";

                    // SQL query to update the order status to 'Done'
                    string updateStatusQuery = @"UPDATE `order` SET orderStatus = 'Done' WHERE orderID = @OrderId";

                    // Select all orders with 'OStanding' status
                    using (MySqlCommand selectCmd = new MySqlCommand(selectOrdersQuery, conn))
                    {
                        List<string> orderIds = new List<string>();
                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orderIds.Add(reader.GetString("orderID"));
                            }
                        }

                        foreach (string orderId in orderIds)
                        {
                            // Check if any 'orderpart' records have 'OStanding' status
                            using (MySqlCommand checkCmd = new MySqlCommand(checkStatusQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@OrderId", orderId);
                                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                                // If count is 0, no 'orderpart' records have 'OStanding' status
                                if (count == 0)
                                {
                                    // Update the order status to 'Done'
                                    using (MySqlCommand updateCmd = new MySqlCommand(updateStatusQuery, conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@OrderId", orderId);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                                checkCmd.Parameters.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the database operations
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}