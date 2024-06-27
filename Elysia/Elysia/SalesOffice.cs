using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class SalesOffice : Form
    {
        public SalesOffice()
        {
            InitializeComponent();
            btnViewOrder.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();

        }
        private void btnViewOrder_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewOrder());
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
        private void btnNewOrder_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new NewOrder());
        }

        private void btnNewDealer_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new NewDealer());
        }

        private void btnViewDealer_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewDealer());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }
    }
}
