using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";"))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT deptID FROM emp WHERE empID = @username AND empPasswd = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);



                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string deptID = reader.GetString("deptID");

                        // Store the employee ID in the StaticVariable class
                        StaticVariable.empID = username;

                        // Redirect to the appropriate department-specific UI
                        RedirectToDepartmentUI(deptID);
                    }
                    else
                    {
                        // Login failed, display error message
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

        private void RedirectToDepartmentUI(string deptID)
        {
            this.Hide();
            switch (deptID)
            {
                case "SO":
                    StaticVariable.dept = "SO";
                    SalesOffice SO = new SalesOffice();
                    SO.Show();
                    break;
                case "SP":
                    StaticVariable.dept = "SP";
                    Storemen SP = new Storemen();
                    SP.Show();
                    break;
                case "SD":
                    StaticVariable.dept = "SD";
                    SparesDespatch SD = new SparesDespatch();
                    SD.Show();
                    break;
                case "IS":
                    StaticVariable.dept = "IS";
                    InvoicingSection IS = new InvoicingSection();
                    IS.Show();
                    break;
                case "SR": 
                    StaticVariable.dept = "SR";
                    StoreRecordClerk SR = new StoreRecordClerk();
                    SR.Show();
                    break;
                case "PD":
                    StaticVariable.dept = "PD";
                    PurchasingDepartment PD = new PurchasingDepartment();
                    PD.Show();
                    break;
                case "GI":
                    StaticVariable.dept = "GI";
                    GoodsInwardDepartment GI = new GoodsInwardDepartment();
                    GI.Show();
                    break;
                case "HR":
                    StaticVariable.dept = "HR";
                    NewEmployee HR = new NewEmployee();
                    HR.Show();
                    break;
                case "AC":
                    StaticVariable.dept = "AC";
                    Accountant viewLog = new Accountant();
                    viewLog.Show();
                    break;
            }
        }
    }
}
