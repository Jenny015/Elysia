using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Reorder : Form
    {
        public Reorder()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnReorder.Checked = true;
        }
        //initialize reorder form with specific partID and qty (passing from danger level)
        public Reorder(String partID, int reOrderQty)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnReorder.Checked = true;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnDangerLevel_CheckedChanged(object sender, EventArgs e)
        {
            DangerLevel dg = new DangerLevel();
            dg.Show();
            this.Close();
        }
    }
}
