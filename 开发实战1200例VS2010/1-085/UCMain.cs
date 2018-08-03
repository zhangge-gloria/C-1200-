using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_085
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string strRes = Regex.Replace(txtInput.Text, @"[A-Za-z]", txtReplace.Text);
            MessageBox.Show("替换前字符：\n" + txtInput.Text + "\n替换后字符：\n" + strRes, "替换");
        }
    }
}
