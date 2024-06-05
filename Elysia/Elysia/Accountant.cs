using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Elysia
{
    public partial class Accountant : Form
    {
        public Accountant()
        {
            InitializeComponent();
            lblDept.Text = StaticVariable.dept_full();
            btnViewLog.Checked = true;
            this.WindowState = FormWindowState.Maximized;
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
