using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_019
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            try
            {
                char chr = txtChar.Text[0];
                byte[] gb2312=Encoding.GetEncoding("gb2312").GetBytes(new char[]{chr});
                int n=(int)gb2312[0]<<8;
                n+=(int)gb2312[1];
                lblCode.Text=n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("请输入汉字字符", "出现错误");
            }
        }

        private void txtChar_TextChanged(object sender, EventArgs e)
        {
            lblCode.Text = string.Empty;
        }
    }
}
