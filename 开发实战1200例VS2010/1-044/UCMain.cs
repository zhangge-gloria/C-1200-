using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_044
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int count = 0;
            string str=txtInput.Text;
            Regex reg = new Regex("^[\u4e00-\u9fa5]$");
            for (int i = 0; i < str.Length;i++ )
            {
                if (reg.IsMatch(str[i].ToString()))
                {
                    count += 1;
                }
            }
            lblShow.Text = count.ToString() + "个汉字";
        }
    }
}
