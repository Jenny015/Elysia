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

        }

        public void setComponent()
        {
            tb_username.AutoSize = false;
            tb_password.AutoSize = false;
            tb_username.Size = new System.Drawing.Size(250, 30);
            tb_password.Size = new System.Drawing.Size(250, 30);
        }
    }
}
