using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_098
{
    public partial class UCMain : UserControl
    {
        int[] oldArray;

        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGenerateArray_Click(object sender, EventArgs e)
        {
            lblOldArray.Text = "";
            Random rd = new Random();
            int len = rd.Next(1, 10);
            oldArray = new int[len];
            for (int i = 0; i < oldArray.Length; i++)
            {
                oldArray[i] = rd.Next(0, 100);
                lblOldArray.Text += oldArray[i] + " ";
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int delIndex = 0;
            int delNum = 0;
            int.TryParse(txtDeleteIndex.Text, out delIndex);
            int.TryParse(txtDeleteNum.Text, out delNum);
            if (delIndex < 0)
            {
                return;
            }
            if (delIndex + delNum > oldArray.Length)
            {
                return;
            }
            int[] newArr = new int[oldArray.Length-delNum];
            Array.Copy(oldArray, 0, newArr, 0, delIndex);
            Array.Copy(oldArray, delIndex + delNum, newArr, delIndex, oldArray.Length - delIndex - delNum);

            //显示
            for (int i = 0; i < newArr.Length; i++)
            {
                lblNewArray.Text += newArr[i] + " ";
            }
        }
    }
}
