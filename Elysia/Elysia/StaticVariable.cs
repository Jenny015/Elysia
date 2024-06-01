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
    }
}
