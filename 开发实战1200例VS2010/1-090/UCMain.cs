using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_090
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool res = Regex.IsMatch(txtInfo.Text, @"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$");//(([\w\.]+)@(([[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|((\w+\.?)+)@([a-zA-Z]{2,4}|[0-9]{1,3})(\.[a-zA-Z]{2,4}))
            if (res == true)
            {
                MessageBox.Show("E-mail格式正确！");
            }
            else
            {
                MessageBox.Show("E-mail格式错误！");
            }

        }
    }
}
