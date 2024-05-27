using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            setComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public void setComponent()
        {
            tb_username.AutoSize = false;
            tb_password.AutoSize = false;
            tb_username.Size = new System.Drawing.Size(250, 30);
            tb_password.Size = new System.Drawing.Size(250, 30);
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
                    NewDealer NewDealer = new NewDealer();
                    NewDealer.Show();
                    break;
                case "SP":
                    ViewDID viewDID = new ViewDID();
                    viewDID.Show();
                    break;
                case "SD":
                    InvoiceGenerateAndDelivery invoiceGenerateAndDelivery = new InvoiceGenerateAndDelivery();
                    invoiceGenerateAndDelivery.Show();
                    break;
                case "IS":
                    ViewInvoice viewInvoice = new ViewInvoice();
                    viewInvoice.Show();
                    break;
                case "SR":
                    ScrapItem scrapItem = new ScrapItem();
                    scrapItem.Show();
                    break;
                case "PD":
                    Reorder reorder = new Reorder();
                    reorder.Show();
                    break;
                case "GI":
                    GoodsInward goodsInward = new GoodsInward();
                    goodsInward.Show();
                    break;
                case "HR":
                    NewEmployee newEmployee = new NewEmployee();
                    newEmployee.Show();
                    break;
                case "AC":
                    ViewLog viewLog = new ViewLog();
                    viewLog.Show();
                    break;
                case "AD":
                    Admin admin = new Admin();
                    admin.Show();
                    break;
                default:
                    MessageBox.Show("Invalid department ID.");
                    break;
            }
        }
    }
}
