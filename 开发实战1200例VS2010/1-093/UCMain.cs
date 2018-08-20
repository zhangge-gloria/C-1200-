using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_093
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetArray_Click(object sender, EventArgs e)
        {
            Random rd=new Random();
            int[,] arr = new int[rd.Next(2, 10), rd.Next(2, 10)];
            lblMsg.Text = string.Format("生成了{0}行{1}列的数组", arr.GetUpperBound(0) + 1, arr.GetUpperBound(1) + 1);
            ShowArray(arr);
        }

        private void ShowArray(int[,] arr)
        {
            lblShow.Text = string.Empty;
            for (int i = 0; i < arr.GetUpperBound(0) + 1;i++ )
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1;j++ )
                {
                    lblShow.Text += i.ToString() + "," + j.ToString() + "      ";
                }
                lblShow.Text += Environment.NewLine;
            }
        }
    }
}
