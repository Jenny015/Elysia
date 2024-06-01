using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class ScrapItem : Form
    {
        public ScrapItem()
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
