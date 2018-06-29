using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_030
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxColor.SelectedIndex)
            {
                case 0:
                    {
                        this.BackColor = Color.Red;
                    }
                    break;
                case 1:
                    {
                        this.BackColor = Color.Green;
                    }
                    break;
                case 2:
                    {
                        this.BackColor = Color.Blue;
                    }
                    break;
                default:
                    break;
            }
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            if (cbxColor.SelectedIndex==2)
            {
                cbxColor.SelectedIndex = 0;
            }
            else
            {
                cbxColor.SelectedIndex++;
            }
            cbxColor_SelectedIndexChanged(sender, e);
        }
    }
}
