using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_037
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChar.Text==string.Empty)
                {
                    return;
                }

                byte[] arrByte = Encoding.Default.GetBytes(txtChar.Text);
                txtNum.Text = (arrByte[0] - 160).ToString() + (arrByte[1] - 160).ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + "请输入正确的汉字", "出错！");
            }
        }
    }
}
