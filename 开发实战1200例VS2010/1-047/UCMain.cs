using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_047
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txtMoney.Text,out value))
            {
                MessageBox.Show("输入的数值正确！");
            }
            else
            {
                MessageBox.Show("输入的数值有误，请重新输入！", "提示！");
            }
        }
    }
}
