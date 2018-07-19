using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_058
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetDays_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            bool isLeapYear = DateTime.IsLeapYear(dt.Year);
            if (isLeapYear)
            {
                MessageBox.Show("本年有366天", "提示！");
            }
            else
            {
                MessageBox.Show("本年有365天", "提示！");
            }
        }
    }
}
