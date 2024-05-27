using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elysia
{
    public partial class Filter : Form
    {
        public Filter(String type)
        {
            InitializeComponent();
            setComponent(type);
        }

        public void setComponent(String type)
        {
            if (type == "DID") {

            }
        }
    }
}
