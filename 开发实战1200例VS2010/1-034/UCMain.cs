using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_034
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string bookName = txtBook.Text;

            int i = 0;
        labelGoto:
            string str = lbBooks.Items[i].ToString();
            if (str.Contains(bookName))
            {
                lbBooks.SelectedIndex = i;
                MessageBox.Show(bookName + "已经找到！", "提示！");
                return;
            }
            i++;
            if (i<lbBooks.Items.Count)
            {
                goto labelGoto;
            }
            MessageBox.Show(bookName + "没有找到！", "提示！");
        }
    }
}
