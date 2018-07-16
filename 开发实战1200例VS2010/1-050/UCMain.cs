using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace 开发实战1200例VS2010._1_050
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double money;
            if (double.TryParse(txtInput.Text,out money))
            {
                NumberFormatInfo numFormatInfo = new CultureInfo("zh-CN", false).NumberFormat;
                numFormatInfo.CurrencyDecimalDigits = Convert.ToInt32(cbxPointCnt.Text);
                lblOutput.Text = money.ToString("C", numFormatInfo);
            }
            else
            {
                MessageBox.Show("请输入正确的数值！", "提示！");
            }
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            cbxPointCnt.SelectedIndex = 0;
        }
    }
}
