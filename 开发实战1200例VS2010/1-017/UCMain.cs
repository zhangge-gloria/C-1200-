using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_017
{
    public partial class UCMain : UserControl
    {
        bool isOperation = false;//是否按下操作键
        int addNum = 0;//加数

        public UCMain()
        {
            InitializeComponent();
        }

        #region 按下数字键
        private void Num(int num)
        {
            if (isOperation == true)
            {
                txtShow.Text = num.ToString();
                if (lblExpression.Text.IndexOf('=') > -1)
                {
                    lblExpression.Text = string.Empty;
                }
            }
            else if (num == 0 && txtShow.Text == "0")
            {
            }
            else if (txtShow.Text == "0")
            {
                txtShow.Text = num.ToString();
            }
            else
            {
                txtShow.Text += num.ToString();
            }
            isOperation = false;
        }
        #endregion

        #region 事件
        private void btn0_Click(object sender, EventArgs e)
        {
            Num(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Num(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Num(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Num(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Num(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Num(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Num(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Num(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Num(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Num(9);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
            lblExpression.Text = string.Empty;
            addNum = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isOperation == true)
            {
                if (lblExpression.Text.IndexOf('=') > -1)
                {
                    btnClear_Click(sender, e);
                }
            }
            else
            {
                if (lblExpression.Text == string.Empty)
                {
                    lblExpression.Text = txtShow.Text;
                }
                else
                {
                    lblExpression.Text += "+" + txtShow.Text;
                }
                int temp = 0;
                int.TryParse(txtShow.Text, out temp);
                addNum += temp;
                txtShow.Text = addNum.ToString();
            }
            isOperation = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (isOperation == true)
            {
                if (lblExpression.Text.IndexOf('=') < 0)
                {
                    lblExpression.Text += "=" + txtShow.Text;
                }
            }
            else
            {
                int temp = 0;
                int.TryParse(txtShow.Text, out temp);
                addNum += temp;
                txtShow.Text = addNum.ToString();
                if (lblExpression.Text != string.Empty)
                {
                    lblExpression.Text += "+";
                }
                lblExpression.Text += temp.ToString() + "=" + txtShow.Text;
            }
            addNum = 0;
            isOperation = true;
        }
        #endregion
    }
}
