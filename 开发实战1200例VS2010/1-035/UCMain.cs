using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_035
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rbtnUpper.Checked==true)
            {
                txtAfter.Text = txtPre.Text.ToUpper();
            }
            else
            {
                txtAfter.Text = txtPre.Text.ToLower();
            }
        }
    }
}
