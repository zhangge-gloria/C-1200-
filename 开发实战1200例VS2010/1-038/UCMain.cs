using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_038
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[\u4e00-\u9fa5]$");
            char[] arr = txtChinese.Text.ToCharArray();
            for (int i = 0; i < arr.Length;i++ )
            {
                bool isMatch = reg.IsMatch(arr[i].ToString());
                if (isMatch == false)
                {
                    MessageBox.Show("输入的字符串不全是汉字");
                    return;
                }
            }
            MessageBox.Show("输入的字符串全是汉字");
        }
    }
}
