using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_070
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (IsTelephone(txtNum.Text)==true)
            {
                MessageBox.Show("电话号码格式正确");
            }
            else
            {
                MessageBox.Show("电话号码格式不正确");
            }
        }

        private bool IsTelephone(string strTelephone)
        {
            return Regex.IsMatch(strTelephone, @"^(\d{3,4}-)?\d{6,8}$");
        }
    }
}
