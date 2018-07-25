using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_068
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            lblShow.Text += Environment.NewLine;
            lblShow.Text += Environment.NewLine;
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("F"));
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("f"));
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("D"));
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("d"));
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("G"));
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("g"));
            lblShow.Text += Environment.NewLine;
            lblShow.Text += string.Format("{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
