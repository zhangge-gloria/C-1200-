using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_028
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxUser.SelectedItem == null)
            {
                return;
            }
            if (cbxUser.SelectedItem.ToString() == "admin")
            {
                MessageBox.Show("管理员登录", "提示！");
            }
            else
            {
                MessageBox.Show("普通用户登录", "提示！");
            }
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            cbxUser.SelectedIndex = 0;
        }
    }
}
