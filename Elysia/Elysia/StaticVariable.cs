using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public static void displayContent(Control control ,UserControl userControl)
        {
            control.Controls.Clear();
            control.Controls.Add(userControl);
            control.Refresh();
        }

        public static void updatePartStatus(String partID)
        {
            string status = "Normal";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=elysia;user=root;password=\"\""))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT partQty FROM part WHERE partID = '{partID}'";
                using (MySqlDataReader reader2 = cmd.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        int partQty = Convert.ToInt32(reader2[0]);
                        if (partQty < reOrder)
                        {
                            status = "Reorder";
                        }
                        else if (partQty < danger)
                        {
                            status = "Danger";
                        }
                        else if (partQty == 0)
                        {
                            status = "Out-of-stock";
                        }
                    }
                    reader2.Close();
                    cmd.CommandText = $"UPDATE part SET partStatus = '{status}' WHERE partID = '{partID}'";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}