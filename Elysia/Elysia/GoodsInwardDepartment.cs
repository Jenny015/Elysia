using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Elysia
{
    public partial class GoodsInwardDepartment : Form
    {
        public GoodsInwardDepartment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnViewGoodsInward.Checked = true;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnUser_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }

        private void btnGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new GoodsInward());
        }

        private void btnViewGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewGoodsInward());
        }
    }
}
