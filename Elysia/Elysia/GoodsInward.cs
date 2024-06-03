using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class GoodsInward : Form
    {
        public GoodsInward()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            this.WindowState = FormWindowState.Maximized;
            btnGoodsInward.Checked = true;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnViewGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            ViewInwards vi = new ViewInwards();
            vi.Show();
            this.Close();
        }
    }
}
