using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_022
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
            txtNum1.TextChanged+=new EventHandler(txtNum_TextChanged);
            txtNum2.TextChanged+=new EventHandler(txtNum_TextChanged);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            byte num1, num2;
            if (byte.TryParse(txtNum1.Text, out num1) && byte.TryParse(txtNum2.Text, out num2))
            {
                try
                {
                    checked
                    {
                        num1 += num2;
                    }
                    lblResult.Text = num1.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "出现错误");
                }
            }
            else
            {
                MessageBox.Show("请输入255以内的数字！");
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }

    }
}
