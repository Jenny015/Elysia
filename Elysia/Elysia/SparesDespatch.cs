using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            btnInvGen.Checked = true;
            this.WindowState = FormWindowState.Maximized;
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