using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ViewDealer : UserControl
    {
        string connectionString = "server=localhost;database=elysia;user=root;password=\"\"";
        public ViewDealer()
        {
            InitializeComponent();
        }
    }
}
