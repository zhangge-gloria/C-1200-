using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_073
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool res = Regex.IsMatch(txtNum.Text, @"^[1][3-5]\d{9}$");
            if (res==true)
            {
                MessageBox.Show("手机号正确");
            }
            else
            {
                MessageBox.Show("手机号不正确");
            }
        }
    }
}
