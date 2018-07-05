using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_036
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnChar2ASCII_Click(object sender, EventArgs e)
        {
            if (txtCharPre.Text != string.Empty&&char.IsLetter(txtCharPre.Text, 0))
            {
                byte[] b = Encoding.GetEncoding("unicode").GetBytes(txtCharPre.Text);
                txtASCIIAfter.Text = b[0].ToString();
            }
            else
            {
                MessageBox.Show("请输入字母！", "提示！");
            }
        }

        private void btnASCII2Char_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txtASCIIPre.Text,out num))
            {
                txtCharAfter.Text = ((char)num).ToString();
            }
            else
            {
                MessageBox.Show("请输入正确的ASCII码值！", "错误！");
            }
        }
    }
}
