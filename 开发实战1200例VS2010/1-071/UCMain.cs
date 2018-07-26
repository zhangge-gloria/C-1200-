using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_071
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (IsPassword(txtPassword.Text)==true)
            {
                MessageBox.Show("密码格式正确");
            }
            else
            {
                MessageBox.Show("密码格式不正确");
            }
        }

        private bool IsPassword(string strPassword)
        {
            return Regex.IsMatch(strPassword, @"[A-Za-z]+[0-9]");
        }
    }
}
