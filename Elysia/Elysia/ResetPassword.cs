using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Elysia
{
    public partial class ResetPassword : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        string username;
        string password;
        string npassword;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Do you want to reset your password?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            };
            username = tb_username.Text;
            password = tb_password.Text;
            npassword = tb_npassword.Text;

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";"))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT deptID, empStatus FROM emp WHERE empID = @username AND empPasswd = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.GetString("empStatus") != "A")
                        {
                            MessageBox.Show("This account has been looked, please connect HR department for help.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        UpdatePassword();
                    }
                    else
                    {
                        // Login failed, display error message
                        MessageBox.Show("Invalid username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void UpdatePassword()
        {

            username = tb_username.Text;
            password = tb_password.Text;
            npassword = tb_npassword.Text;
            try
            {
                // Update the database with the new dealer information
                string updateQuery = "UPDATE emp SET empPasswd = @npassword WHERE empID = @empID";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@empID", username);
                        cmd.Parameters.AddWithValue("@npassword", npassword);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

    }
}
