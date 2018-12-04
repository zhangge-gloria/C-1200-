using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_096
{
    public partial class UCMain : UserControl
    {
        int[] oldArray;
        int[] insertArray;
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
            for (int i = 0; i < oldArray.Length;i++ )
            {
                oldArray[i] = rd.Next(0, 100);
                lblOldArray.Text += oldArray[i] + " ";
            }
        }

        private void btnInsertArray_Click(object sender, EventArgs e)
        {
            lblInserArray.Text = "";
            Random rd = new Random();
            int len = rd.Next(1, 10);
            insertArray = new int[len];
            for (int i = 0; i < insertArray.Length; i++)
            {
                insertArray[i] = rd.Next(0, 100);
                lblInserArray.Text += insertArray[i] + " ";
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblNewArray.Text = "";
            int insertIndex = 0;
            int.TryParse(txtInsertIndex.Text, out insertIndex);
            int[] newArray = new int[oldArray.Length + insertArray.Length];
            if (insertIndex < 0)
            {
                insertIndex = 0;
            }
            if (insertIndex > oldArray.Length)
            {
                insertIndex = oldArray.Length;
            }

            Array.Copy(oldArray, 0, newArray, 0, insertIndex);
            Array.Copy(insertArray, 0, newArray, insertIndex, insertArray.Length);
            Array.Copy(oldArray, insertIndex, newArray, insertIndex + insertArray.Length, newArray.Length - insertIndex - insertArray.Length);

            //显示
            for (int i = 0; i < newArray.Length;i++ )
            {
                lblNewArray.Text += newArray[i] + " ";
            }
        }
    }
}
