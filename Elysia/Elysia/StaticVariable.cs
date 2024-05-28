using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysia
{
    //To store global variable that every form could access to
    public static class StaticVariable
    {
        //Store the user's department in short form
        public static string department {  get; set; }
        //Return the full name of department
        public static string dept_full()
        {
            switch (department) {
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
    }
}
