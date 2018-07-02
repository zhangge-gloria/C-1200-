using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 开发实战1200例VS2010._1_031
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            for (; ; )
            {
                txtShow.Text = "当前的系统时间是：" + DateTime.Now.ToString("dd日 hh:mm:sss");
                Thread.Sleep(1000);
                Application.DoEvents();
            }
        }
    }
}
