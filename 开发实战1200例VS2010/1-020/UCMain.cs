using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_020
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int year = 0;
                if (int.TryParse(txtYear.Text, out year))
                {
                    MessageBox.Show((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) ? "输入的是闰年" : "输入的不是闰年", "提示");
                }
                else
                {
                    MessageBox.Show("输入错误", "出现错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出现错误");
            }
        }
    }
}
