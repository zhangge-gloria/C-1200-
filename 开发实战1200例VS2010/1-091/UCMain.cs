using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_091
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string num = @"(25[0-5]|2[0-4]\d|[0-1]\d{2}|[1-9]?\d)";
            bool result = Regex.IsMatch(txtInfo.Text, "^" + num + "\\." + num + "\\." + num + "\\." + num + "$");
            if (result==true)
            {
                MessageBox.Show("输入的IP正确");
            }
            else
            {
                MessageBox.Show("输入的IP不正确");
            }
        }
    }
}
