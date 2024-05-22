using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elysia
{
    public partial class newOrder : Form
    {
        MySqlConnection cnn;
        public newOrder()
        {
            InitializeComponent();
            cnn = new MySqlConnection("server=localhost;database=elysia;uid=root;pwd=\"\";");
            loadInformation();
        }

        public void ConnectToSql()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to connect MySQL\n"+ex.Message);
            }
        }

        public void loadInformation()
        {
            ConnectToSql();
            MySqlCommand cmd = cnn.CreateCommand();

            //load dealerID
            cmd.CommandText = "SELECT dealerID FROM dealer";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                cbDealerID.Items.Clear();

                while (reader.Read())
                {
                    cbDealerID.Items.Add(reader.GetString(0));
                }
            }

                

            cmd.CommandText = "SELECT partID FROM part";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                cbPartID.Items.Clear();

                while (reader.Read())
                {
                    cbPartID.Items.Add(reader.GetString(0));
                }
            }

            cnn.Close();
        }

    }
}
