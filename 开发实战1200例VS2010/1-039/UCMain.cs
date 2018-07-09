using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_039
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnNewLine_Click(object sender, EventArgs e)
        {
            StringBuilder content = new StringBuilder(txtInput.Text);
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == ',')
                {
                    content.Insert(i+1, Environment.NewLine);//插入到逗号的后面
                }
            }
            lblShow.Text = content.ToString();
        }
    }
}
