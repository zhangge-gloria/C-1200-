using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_018
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            txtNum.TextChanged+=new EventHandler(txt_TextChanged);
            txtKey.TextChanged+=new EventHandler(txt_TextChanged);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int num = 0;
            int numKey = 0;
            if (int.TryParse(txtNum.Text, out num) && int.TryParse(txtKey.Text, out numKey))
            {
                lblEncrypt.Text = (num ^ numKey).ToString();
            }
            else
            {
                MessageBox.Show("输入的数值不正确", "出现错误");
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            int numKey = 0;
            int numEncrypt = 0;
            if (int.TryParse(txtKey.Text, out numKey) && int.TryParse(lblEncrypt.Text,out numEncrypt))
            {
                lblRevert.Text = (numKey ^ numEncrypt).ToString();
            }
            else
            {
                MessageBox.Show("输入的数值不正确", "出现错误");
            }

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            lblEncrypt.Text = string.Empty;
            lblRevert.Text = string.Empty;
        }

    }
}
