using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 开发实战1200例VS2010._1_053
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            Thread thTime = new Thread(ShowTime);
            thTime.IsBackground = true;
            thTime.Start();
        }

        private void ShowTime()
        {
            while (true)
            {
                DateTime dt = DateTime.Now;
                string str = dt.ToString();
                Action<string> tb2dele = (x) => { lblShow.Text = str; };
                lblShow.Invoke(tb2dele, str);
                Thread.Sleep(1000);
            }
        }

    }
}
