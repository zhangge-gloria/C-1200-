using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 开发实战1200例VS2010._1_062
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Int64 interval = DateAndTime.DateDiff(DateInterval.Day, dtpStart.Value, dtpEnd.Value, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
            MessageBox.Show("间隔" + interval.ToString() + "天", "间隔时间");
        }
    }
}
