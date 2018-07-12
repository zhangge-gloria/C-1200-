using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_045
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text.Replace(txtFind.Text, txtReplace.Text);
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            txtShow.Text = "C#范例宝典\r\nC#编程宝典\r\nC#视频学\r\nC#项目开发全程实录\r\nC#项目开发实例自学手册\r\nC#编程词典\r\nC#实战宝典\r\nC#经验技巧宝典\r\nC#入门模式";
        }
    }
}
