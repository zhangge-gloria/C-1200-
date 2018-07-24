using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_064
{
    public partial class UCMain : UserControl
    {
        DateTime dtFirst, dtSec;
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetFirst_Click(object sender, EventArgs e)
        {
            dtFirst = DateTime.Now;
            lblFirst.Text = "系统时间：" + dtFirst.ToString("yyyy年MM月dd日  HH时mm分ss秒  fff毫秒");
        }

        private void btnGetSec_Click(object sender, EventArgs e)
        {
            dtSec = DateTime.Now;
            lblSec.Text = "系统时间：" + dtSec.ToString("yyyy年MM月dd日  HH时mm分ss秒  fff毫秒");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            TimeSpan ts = (dtFirst > dtSec) ? (dtFirst - dtSec) : (dtSec - dtFirst);
            lblCalc.Text = string.Format("{0}天{1}时{2}分{3}秒  {4}毫秒", ts.Days, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }
    }
}
