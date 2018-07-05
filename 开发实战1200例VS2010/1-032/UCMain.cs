using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_032
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txtNum.Text, out num))
            {
                lblRes.Text = "计算结果为：" + Calc(num).ToString();
            }
            else
            {
                MessageBox.Show("输入的数值不正确，请重新输入！", "提示！");
            }
        }

        private int Calc(int num)
        {
            int res = 0;
            if (num == 0)
            {
                res = 0;
            }
            else if (num == 1)
            {
                res = 1;
            }
            else
            {
                res = Calc(num - 1) + Calc(num - 2);
            }
            return res;
        }
    }
}
