using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 开发实战1200例VS2010._1_065
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(
                () =>
                {
                    while (true)
                    {
                        Invoke(
                            (MethodInvoker)(() =>
                            {
                                lblShow.Text = DateTime.Now.ToString("F");
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
