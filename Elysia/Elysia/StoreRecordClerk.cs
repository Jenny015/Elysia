using System;
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
            
            btnScrapItem.Checked = true;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }
            StaticVariable.logout();
            this.Close();
        }

        private void btnScrapItem_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ScrapItem());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewLog("ScrapItem"));
        }
    }
}
