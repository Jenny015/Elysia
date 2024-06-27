using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class PurchasingDepartment : Form
    {
        public PurchasingDepartment()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            btnDangerLevel.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new User());
        }

        private void btnNewSupplier_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new NewSupplier());
        }

        private void btnDangerLevel_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new DangerLevel());
        }

        private void btnViewGoodsInward_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewGoodsInward());
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

        private void btnViewSupplier_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewSupplier());
        }
    }
}
