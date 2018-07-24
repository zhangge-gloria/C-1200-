using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 开发实战1200例VS2010._1_066
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            DateTime dtStart = DateTime.Now;
            Thread th = new Thread(
                () =>
                {
                    while (true)
                    {
                        TimeSpan ts = DateTime.Now - dtStart;
                        Invoke(
                            (MethodInvoker)(() =>
                            {
                                lblShow.Text = string.Format("系统已运行：{0}天{1}时{2}分{3}秒", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);
                            }
                            ));
                        Thread.Sleep(1000);
                    }
                }
    );
            th.IsBackground = true;
            th.Start();

        }
    }
}
