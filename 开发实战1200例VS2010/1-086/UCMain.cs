using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_086
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string[] str = Regex.Split(txtPre.Text, "[0-9]");
            for (int i = 0; i < str.Length; i++)
            {
                txtAfter.Text += str[i];
            }
        }

    }
}
