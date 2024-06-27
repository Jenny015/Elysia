using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Storemen : Form
    {
        public Storemen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            
            btnLateDelivery.Checked = true;
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

        private void btnDID_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new AssembleDID());
        }

        private void btnSparePart_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewSparePart());
        }

        private void btnLateDelivery_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewLateDeliveryAlarm());
        }
        private void btnNewSparePart_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new NewSparePart());
        }
    }
}
