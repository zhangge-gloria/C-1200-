using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_069
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string str = string.Format("{0}/{1}/{2}", txtYear.Text, txtMonth.Text, txtDay.Text);
                DateTime dt = Convert.ToDateTime(str);
                MessageBox.Show(dt.ToLongDateString(), "提示！");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
