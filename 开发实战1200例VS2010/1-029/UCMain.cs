using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_029
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            if (cbxMonth.SelectedItem == null)
            {
                return;
            }
            switch (cbxMonth.SelectedIndex + 1)
            {
                case 3:
                case 4:
                case 5:
                    {
                        MessageBox.Show("春季", "提示！");
                    }
                    break;
                case 6:
                case 7:
                case 8:
                    {
                        MessageBox.Show("夏季", "提示！");
                    }
                    break;
                case 9:
                case 10:
                case 11:
                    {
                        MessageBox.Show("秋季", "提示！");
                    }
                    break;
                case 12:
                case 1:
                case 2:
                    {
                        MessageBox.Show("冬季", "提示！");
                    }
                    break;
                default:
                    break;
            }
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            cbxMonth.SelectedIndex = 0;
        }
    }
}
