using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
            lblDept.Text = StaticVariable.dept_full();
            btnViewLog.Checked = true;
            
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void btnViewLog_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new ViewLog());
        }

        private void btnEvaluatedList_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.displayContent(contentPanel, new EvaluatedList());
        }
    }
}
