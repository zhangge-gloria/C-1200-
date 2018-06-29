using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_027
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rbtnSchool.Checked==true)
            {
                MessageBox.Show("向左走", "提示！");
            }
            else
            {
                MessageBox.Show("向右走", "提示！");
            }
        }
    }
}
