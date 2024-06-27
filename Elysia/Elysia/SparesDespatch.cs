using System;
using System.Windows.Forms;


namespace Elysia
{
    public partial class SparesDespatch : Form
    {
        public SparesDespatch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnLateDelivery.Checked = true;
            
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

        private void btnUser_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }

        private void btnViewInvoice_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewInvoice());
        }

        private void btnInvGen_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new InvoiceGenerate());
        }

        private void btnLateDelivery_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewLateDeliveryAlarm());
        }
    }
}