using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_042
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            char[] arr = txtInput.Text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length;i++ )
            {
                if (arr[i] != ' ')
                {
                    sb.Append(arr[i]);
                }
            }
            txtOutput.Text = sb.ToString();
        }
    }
}
