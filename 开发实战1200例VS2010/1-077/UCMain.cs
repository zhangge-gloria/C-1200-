using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_077
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool res = Regex.IsMatch(txtInfo.Text, @"^(0?[1-9]|((1|2)[0-9])|2[0-1])$");
            if (res==true)
            {
                MessageBox.Show("输入天数正确");
            }
            else
            {
                MessageBox.Show("输入天数不正确");
            }
        }
    }
}
