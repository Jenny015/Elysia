using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Elysia
{
    public partial class StoreRecordClerk : Form
    {
        public StoreRecordClerk()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            this.WindowState = FormWindowState.Maximized;
            btnScrapItem.Checked = true;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnScrapItem_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ScrapItem());
        }
    }
}
