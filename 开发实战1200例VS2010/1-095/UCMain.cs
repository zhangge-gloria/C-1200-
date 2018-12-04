using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_095
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
            lblNewArray.Text = "";
            int insertValue = 0;
            int insertIndex = 0;
            int.TryParse(txtInsertValue.Text, out insertValue);
            int.TryParse(txtInsertIndex.Text, out insertIndex);
            int[] newArray = new int[oldArray.Length + 1];
            if (insertIndex<0)
            {
                insertIndex = 0;
            }
            if (insertIndex > oldArray.Length)
            {
                insertIndex = oldArray.Length;
            }
            //插入点的前面直接拷贝
            Array.Copy(oldArray, 0, newArray, 0, insertIndex);
            newArray[insertIndex] = insertValue;
            Array.Copy(oldArray, insertIndex, newArray, insertIndex + 1, oldArray.Length - insertIndex);

            //显示
            for (int i = 0; i < newArray.Length;i++ )
            {
                lblNewArray.Text += newArray[i] + " ";
            }
        }
    }
}
