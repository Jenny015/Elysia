using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class InvoicingSection : Form
    {
        public InvoicingSection()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnViewInvoice.Checked = true;

        }
        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }

        private void btnViewInvoice_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewInvoice());
        }

        private void btnUser_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }

        private void btnLogout_CheckedChanged_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }
            StaticVariable.logout();
            this.Close();
        }
    }
}
