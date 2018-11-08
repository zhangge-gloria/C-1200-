using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_094
{
    public partial class UCMain : UserControl
    {
        string[] array = new string[] { "明日科技", "C#编程词典", "C#范例大全", "C#范例宝典" };

        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length;i++ )
            {
                label1.Text += array[i] + "\n";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text!=string.Empty)
            {
                string[] temp = Array.FindAll(array, (s) => s.Contains(txtSearch.Text));
                if (temp.Length>0)
                {
                    txtShow.Clear();
                    foreach (string s in temp)
                    {
                        txtShow.Text += s + Environment.NewLine;
                    }
                }
                else
                {
                    txtShow.Clear();
                    txtShow.Text = "没有找到记录";
                }
            }
            else
            {
                txtShow.Clear();
            }
        }
    }
}
