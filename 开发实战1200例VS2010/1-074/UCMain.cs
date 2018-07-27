using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_074
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool res = Regex.IsMatch(txtNum.Text, @"(^\d{18}$)|(^\d{15})$");
            if (res==true)
            {
                MessageBox.Show("身份证号正确");
            }
            else
            {
                MessageBox.Show("身份证号不正确");
            }
        }
    }
}
