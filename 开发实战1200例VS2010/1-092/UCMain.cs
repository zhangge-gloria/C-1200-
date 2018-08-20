using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_092
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool result = Regex.IsMatch(txtInfo.Text, @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$");
            if (result==true)
            {
                MessageBox.Show("网址格式正确");
            }
            else
            {
                MessageBox.Show("网址格式错误");
            }
        }
    }
}
