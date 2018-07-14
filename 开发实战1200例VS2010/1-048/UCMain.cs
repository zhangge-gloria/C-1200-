using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_048
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            cbxPoint.SelectedIndex = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (double.TryParse(txtNum1.Text,out num1)&&double.TryParse(txtNum2.Text,out num2))
            {
                lblResult.Text = "计算结果：" + Round(num1 + num2, cbxPoint.SelectedIndex + 1).ToString();
            }
            else
            {
                MessageBox.Show("输入数值不正确！", "提示！");
            }
        }

        private double Round(double value, int count)
        {
            double res = 0;
            string str = value.ToString();
            int pointCount = str.Length - str.IndexOf('.') - 1;
            if (pointCount<=count)
            {
                res = value;
            }
            else
            {
                for (int i = pointCount; i > count + 1; i--)
                {
                    int temp = (int)Math.Round(value * Math.Pow(10, i), 0);
                    if (temp % 10 >= 5)
                    {
                        value += Math.Pow(10, -(i - 1));
                    }
                }
                res = Math.Round(value, count);
            }
            return res;
        }
    }
}
