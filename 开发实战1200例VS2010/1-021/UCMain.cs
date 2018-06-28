using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_021
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbYes.Checked == true)
            {
                MessageBox.Show("正常报销！");
            }
            else
            {
                MessageBox.Show("不符合规定报销！");
            }
        }
    }
}
