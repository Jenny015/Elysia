using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;

namespace Elysia
{
    //To store global variable that every form could access to
    public static class StaticVariable
    {
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
                case "ST":
                    return "Spare Parts Store";
                case "SD":
                    return "Spares Dispatch Department";
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
        public static void updatePartStatus()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=elysia;user=root;password=\"\""))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT partID, partQty FROM part";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    string query = "UPDATE part SET partStatus = @status WHERE partID = @partID;";
                    while (reader.Read())
                    {
                        string partID = reader["partID"].ToString();
                        int partQty = Convert.ToInt32(reader["partQty"]);

                        using (MySqlCommand cmd2 = new MySqlCommand(query, conn))
                        {
                            if (partQty < reOrder)
                            {
                                cmd2.Parameters.AddWithValue("@status", "Reorder");
                            }
                            else if (partQty < danger)
                            {
                                cmd2.Parameters.AddWithValue("@status", "Danger");
                            }
                            else if (partQty == 0)
                            {
                                cmd2.Parameters.AddWithValue("@status", "Out-of-stock");
                            }

                            cmd2.Parameters.AddWithValue("@partID", partID);
                            cmd2.ExecuteNonQuery();
                            cmd2.Parameters.Clear();
                        }
                    }
                    conn.Close();
                }
            }
        }
    }
}
