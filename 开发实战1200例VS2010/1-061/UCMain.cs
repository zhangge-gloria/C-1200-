using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_061
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            lblShow.Text =
                DateTime.Now.ToString("d") + "\n" +
                DateTime.Now.ToString("D") + "\n" +
                DateTime.Now.ToString("f") + "\n" +
                DateTime.Now.ToString("F") + "\n" +
                DateTime.Now.ToString("g") + "\n" +
                DateTime.Now.ToString("G") + "\n" +
                DateTime.Now.ToString("R") + "\n" +
                DateTime.Now.ToString("y") + "\n" +
                "当前系统时间为：" + DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒");
        }
    }
}
