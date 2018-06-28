using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_024
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (new test())
            {
            }
        }
    }

    class test : IDisposable
    {
        public void Dispose()
        {
            MessageBox.Show("已经执行test对象的Dispose方法", "提示");
        }
    }
}
