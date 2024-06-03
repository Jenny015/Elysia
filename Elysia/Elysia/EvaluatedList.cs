﻿using System;
using System.Windows.Forms;

namespace Elysia
{
    public partial class EvaluatedList : Form
    {
        public EvaluatedList()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblDept.Text = StaticVariable.dept_full();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogout_CheckedChanged(object sender, EventArgs e)
        {
            StaticVariable.logout();
            this.Close();
        }
    }
}
