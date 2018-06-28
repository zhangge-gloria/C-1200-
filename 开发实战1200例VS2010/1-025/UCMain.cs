using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 开发实战1200例VS2010._1_025
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object obj = rbtnClass1.Checked ? (object)"C#" : new FileInfo("d:\\");
            if (rbtnString.Checked)
            {
                if (obj is string)
                {
                    MessageBox.Show("对象与指定内容兼容", "提示");
                }
                else
                {
                    MessageBox.Show("对象与指定内容不兼容", "提示");
                }
            }
            else
            {
                if (obj is FileInfo)
                {
                    MessageBox.Show("对象与指定内容兼容", "提示");
                }
                else
                {
                    MessageBox.Show("对象与指定内容不兼容", "提示");
                }
            }

        }

    }
}
