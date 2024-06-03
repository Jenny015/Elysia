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

                string deptID = (string)command.ExecuteScalar();

                if (deptID != null)
                {
                    // Login successful, redirect to appropriate department-specific UI
                    RedirectToDepartmentUI(deptID);
                }
                else
                {
                    // Login failed, display error message
                    MessageBox.Show("Invalid username or password.");
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
                    ViewOrder viewOrder = new ViewOrder();
                    viewOrder.Show();
                    break;
                case "SP":
                    StaticVariable.dept = "SP";
                    ViewDID viewDID = new ViewDID();
                    viewDID.Show();
                    break;
                case "SD":
                    StaticVariable.dept = "SD";
                    InvoiceGenerate invoiceGenerateAndDelivery = new InvoiceGenerate();
                    invoiceGenerateAndDelivery.Show();
                    break;
                case "IS":
                    StaticVariable.dept = "IS";
                    ViewInvoice viewInvoice = new ViewInvoice();
                    viewInvoice.Show();
                    break;
                case "SR":
                    StaticVariable.dept = "SR";
                    ScrapItem scrapItem = new ScrapItem();
                    scrapItem.Show();
                    break;
                case "PD":
                    StaticVariable.dept = "PD";
                    DangerLevel dangerLevel = new DangerLevel();
                    dangerLevel.Show();
                    break;
                case "GI":
                    StaticVariable.dept = "GI";
                    ViewInwards vi = new ViewInwards();
                    vi.Show();
                    break;
                case "HR":
                    StaticVariable.dept = "HR";
                    NewEmployee newEmployee = new NewEmployee();
                    newEmployee.Show();
                    break;
                case "AC":
                    StaticVariable.dept = "AC";
                    ViewLog viewLog = new ViewLog();
                    viewLog.Show();
                    break;
                default:
                    MessageBox.Show("Invalid department ID.");
                    break;
            }
        }
    }
}
