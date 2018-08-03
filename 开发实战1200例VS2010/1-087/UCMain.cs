using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_087
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool res = Regex.IsMatch(txtInfo.Text, @"^([A-Za-z]+)$");
            if (res == true)
            {
                MessageBox.Show("输入的是字母");
            }
            else
            {
                MessageBox.Show("输入的不是字母");
            }
        }
    }
}
