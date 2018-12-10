using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_099
{
    public partial class UCMain : UserControl
    {
        int[] arr;
        
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGenerateArray_Click(object sender, EventArgs e)
        {
            lblArray.Text = "";
            Random rd = new Random();
            int len = rd.Next(1, 10);
            arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(0, 100);
                lblArray.Text += arr[i] + " ";
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lblSort.Text = "";
            if (arr != null)
            {
                int minIndex = 0;
                for (int i = 0; i < arr.Length - 1;i++ )
                {
                    minIndex = i;
                    for (int j = i; j < arr.Length;j++ )
                    {
                        if (arr[minIndex]>arr[j])
                        {
                            minIndex = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }

                //显示
                for (int i = 0; i < arr.Length;i++ )
                {
                    lblSort.Text += arr[i] + " ";
                }
            }
            else
            {
                MessageBox.Show("请先生成数组，再进行排序。");
            }
        }
    }
}
