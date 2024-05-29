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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
