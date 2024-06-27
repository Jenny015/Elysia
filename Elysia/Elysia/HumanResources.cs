using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class HumanResources : Form
    {
        public HumanResources()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            
            btnViewEmployee.Checked = true;
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

        private void btnNewEmployee_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new NewEmployee());
        }

        private void btnViewEmployee_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewEmployee());
        }

        private void btnLogout_CheckedChanged_1(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
