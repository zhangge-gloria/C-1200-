using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 开发实战1200例VS2010._1_055
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Int64 age = DateAndTime.DateDiff(DateInterval.Year, dtpBirthday.Value, DateTime.Now, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
            MessageBox.Show(string.Format("年龄为{0}岁。", age.ToString()), "提示！");
        }
    }
}
