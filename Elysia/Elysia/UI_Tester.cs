using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class UI_Tester : Form
    {
        public UI_Tester()
        {
            InitializeComponent();
        }

        private void lblDept_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
