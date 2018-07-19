using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_060
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetYesterday_Click(object sender, EventArgs e)
        {
            MessageBox.Show("昨天是：" + DateTime.Now.AddDays(-1).ToString("yyyy年M月d日"),"提示！");
        }
    }
}
