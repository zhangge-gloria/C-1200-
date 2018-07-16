using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_049
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int money;
            if (int.TryParse(txtInput.Text, out money))
            {
                lblOutput.Text = new Upper().Num2Chinese(txtInput.Text);
            }
            else
            {
                MessageBox.Show("请输入正确整数数值！", "提示！");
            }
        }
    }

    public class Upper
    {
        char[] money = new char[9] { '壹', '贰', '叁', '肆', '伍', '陆', '柒', '捌', '玖' };
        char[] unit = new char[3] { '拾', '佰', '仟' };
        char[] unit1 = new char[2] { '万', '亿' };

        public string Num2Chinese(string lower)
        {
            StringBuilder sb = new StringBuilder(lower);
            int len=sb.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                int index = len - 1 - i;
                int num;
                int.TryParse(sb[i].ToString(), out num);
                sb[i] = money[num - 1];
                int temp = index % 4;
                if (temp==3)
                {
                    temp = index / 4;
                    if (temp%2==0)
                    {
                        sb.Insert(i, unit1[0]);
                    }
                    else
                    {
                        sb.Insert(i, unit1[1]);
                    }
                }
                else
                {
                    if (i!=0)
                    {
                        sb.Insert(i, unit[temp]);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
