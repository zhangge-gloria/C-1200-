using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_040
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text=="admin")
            {
                MessageBox.Show("登录成功！", "提示！");
            }
            else
            {
                MessageBox.Show("用户名错误！", "错误！");
            }
        }
    }
}
