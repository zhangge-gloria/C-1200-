using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace 开发实战1200例VS2010._1_023
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            Type type = typeof(Int32);
            foreach (MethodInfo method in type.GetMethods())
            {
                rtxtShow.AppendText("方法名称：" + method.Name + Environment.NewLine);
                foreach (ParameterInfo parameter in method.GetParameters())
                {
                    rtxtShow.AppendText("参数：" + parameter.Name + Environment.NewLine);
                }
            }
        }
    }
}
