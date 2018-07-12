using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_043
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog pfd = new OpenFileDialog();
            if (pfd.ShowDialog()==DialogResult.OK)
            {
                string file = pfd.FileName;
                int index = file.LastIndexOf("\\");
                string path = file.Substring(0, index);
                int indexPoint=file.LastIndexOf(".");
                string name = file.Substring(index + 1, indexPoint - index - 1);
                string extension = file.Substring(indexPoint + 1, file.Length - indexPoint - 1);
                lblShow.Text = "文件路径：" + path + Environment.NewLine + "文件名称：" + name + Environment.NewLine + "文件扩展名：" + extension;
            }
        }
    }
}
