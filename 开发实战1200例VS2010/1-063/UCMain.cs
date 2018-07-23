using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 开发实战1200例VS2010._1_063
{
    public partial class UCMain : UserControl
    {
        DateTime dt;

        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            lblTime.Text = dt.ToString("yyyy年MM月dd日 HH时mm分ss秒");
        }

        private void btnAddMin_Click(object sender, EventArgs e)
        {
            dt = DateAndTime.DateAdd(DateInterval.Minute, 1, dt);
            lblTime.Text = dt.ToString("yyyy年MM月dd日 HH时mm分ss秒");
        }

        private void btnAddHour_Click(object sender, EventArgs e)
        {
            dt = DateAndTime.DateAdd(DateInterval.Hour, 1, dt);
            lblTime.Text = dt.ToString("yyyy年MM月dd日 HH时mm分ss秒");
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            dt = DateAndTime.DateAdd(DateInterval.Day, 1, dt);
            lblTime.Text = dt.ToString("yyyy年MM月dd日 HH时mm分ss秒");

        }
    }
}
