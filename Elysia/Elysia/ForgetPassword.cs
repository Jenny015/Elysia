using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ForgetPassword : Form
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        string username;
        public ForgetPassword()
        {
            InitializeComponent();
        }
        private void btn_forget_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you forget your password?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            };
            username = tb_username.Text;

            using (MySqlConnection connection = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";"))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT empStatus FROM emp WHERE empID = @username", connection);
                command.Parameters.AddWithValue("@username", username);

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
                        MessageBox.Show("Invalid username.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void UpdatePassword()
        {
            username = tb_username.Text;
            try
            {
                // Update the database with the new dealer information
                string updateQuery = "UPDATE emp SET empPasswd = @username WHERE empID = @username";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Password updated successfully as your employee ID", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }

}

