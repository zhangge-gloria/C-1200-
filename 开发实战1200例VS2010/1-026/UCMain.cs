using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 开发实战1200例VS2010._1_026
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rbtnObj.Checked == true)
            {
                using (FileStream fileStream = new FileStream(@"d:\log.txt", FileMode.Create))
                {
                    object obj = fileStream as object;
                    if (obj == null)
                    {
                        MessageBox.Show("转换Object失败！", "提示！");
                    }
                    else
                    {
                        MessageBox.Show("转换Object成功！", "提示！");
                    }
                }
                return;
            }
            if (rbtnStream.Checked == true)
            {
                using (FileStream fileStream = new FileStream(@"d:\log.txt", FileMode.Create))
                {
                    Stream stream = fileStream as Stream;
                    if (stream == null)
                    {
                        MessageBox.Show("转换Stream失败！", "提示！");
                    }
                    else
                    {
                        MessageBox.Show("转换Stream成功！", "提示！");
                    }
                }
                return;
            }
            if (rbtnString.Checked == true)
            {
                //FileStream转换String失败，所以直接会报错
                //using (FileStream fileStream = new FileStream(@"d:\log.txt", FileMode.Create))
                //{
                //    String str = fileStream as String;
                //    if (str == null)
                //    {
                //        MessageBox.Show("转换String失败！", "提示！");
                //    }
                //    else
                //    {
                //        MessageBox.Show("转换String成功！", "提示！");
                //    }
                //}
                //return;
            }
        }
    }
}
