using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class GoodsInwardDepartment : Form
    {
        public GoodsInwardDepartment()
        {
            InitializeComponent();
            btnGoodsInward.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnUser_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }

        private void btnGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new NewGoodsInward());
        }

        private void btnViewGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewGoodsInward());
        }
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLogout.Checked)
            {
                StaticVariable.logout();
                this.Close();
            }

        }
    }
}
