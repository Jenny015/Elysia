using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class User : UserControl
    {
        String connectionString = "server=localhost;database=elysia;uid=root;pwd=\"\";";
        public User()
        {
            InitializeComponent();
            setLabels();
        }

        private void setLabels()
        {
            lblEmpID.Text = StaticVariable.empID;
            lblDept.Text = StaticVariable.dept_full();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT empName, empGander, empPhone, empEmail, empPostion FROM emp WHERE empID = '{StaticVariable.empID}' ;";
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblName.Text = reader.GetString(0);
                            lblGender.Text = reader.GetChar(1).ToString();
                            lblPhone.Text = reader.GetString(2);
                            lblEmail.Text = reader.GetString(3);
                            lblPos.Text = reader.GetString(4);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failed");
                }

            }
        }
    }
}
