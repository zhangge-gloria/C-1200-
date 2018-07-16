using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace 开发实战1200例VS2010._1_051
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double money;
            if (double.TryParse(txtInput.Text, out money))
            {
                NumberFormatInfo numFormatInfo = new CultureInfo("zh-CN", false).NumberFormat;
                numFormatInfo.CurrencyGroupSeparator = ",";
                txtOutput.Text = money.ToString("C", numFormatInfo);
            }
            else
            {
                MessageBox.Show("请输入正确的货币值！", "提示！");
            }
        }
    }
}
