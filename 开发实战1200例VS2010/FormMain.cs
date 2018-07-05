﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace 开发实战1200例VS2010
{
    public partial class FormMain : Form
    {
        string path = Directory.GetCurrentDirectory();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void tvMenu_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode node = tvMenu.GetNodeAt(e.X, e.Y);
            if (node == null)
            {
                return;
            }

            string tag = string.Empty;
            if (node.Tag != null)
            {
                tag = node.Tag.ToString();
            }
            //查找是否已经打开
            foreach (TabPage tb in tcExample.TabPages)
            {
                if (tb.Text == node.Text)
                {
                    tcExample.SelectedTab = tb;
                    return;
                }
            }

            switch (tag)
            {
                case "1-16":
                    {
                        Button btn = new Button();
                        btn.Text = "输出字符串";
                        btn.Width = 100;
                        btn.Height = 40;
                        btn.Location = new Point(tcExample.Left + tcExample.Width / 2 - btn.Width / 2, tcExample.Top + tcExample.Height / 2 - btn.Height / 2);
                        btn.Click += new EventHandler(btn016_Click);
                        AddTab(btn, node);
                    }
                    break;
                case "1-17":
                    {
                        _1_017.UCMain ucMain = new _1_017.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-18":
                    {
                        _1_018.UCMain ucMain = new _1_018.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-19":
                    {
                        _1_019.UCMain ucMain = new _1_019.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-20":
                    {
                        _1_020.UCMain ucMain = new _1_020.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-21":
                    {
                        _1_021.UCMain ucMain = new _1_021.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-22":
                    {
                        _1_022.UCMain ucMain = new _1_022.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-23":
                    {
                        _1_023.UCMain ucMain = new _1_023.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-24":
                    {
                        _1_024.UCMain ucMain = new _1_024.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-25":
                    {
                        _1_025.UCMain ucMain = new _1_025.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-26":
                    {
                        _1_026.UCMain ucMain = new _1_026.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-27":
                    {
                        _1_027.UCMain ucMain = new _1_027.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-28":
                    {
                        _1_028.UCMain ucMain = new _1_028.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-29":
                    {
                        _1_029.UCMain ucMain = new _1_029.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-30":
                    {
                        _1_030.UCMain ucMain = new _1_030.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-31":
                    {
                        _1_031.UCMain ucMain = new _1_031.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-32":
                    {
                        _1_032.UCMain ucMain = new _1_032.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-33":
                    {
                        _1_033.UCMain ucMain = new _1_033.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-34":
                    {
                        _1_034.UCMain ucMain = new _1_034.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-35":
                    {
                        _1_035.UCMain ucMain = new _1_035.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                case "1-36":
                    {
                        _1_036.UCMain ucMain = new _1_036.UCMain();
                        AddTab(ucMain, node);
                    }
                    break;
                default:
                    break;
            }

        }

        private void btn016_Click(object sender, EventArgs e)
        {
            string str="\"";
            string strOne = "Hello,\"C#\";";
            string strTwo = "Hello," + '\u0022' + "C#" + '\u0022' + ";";
            string strThree = "Hello," + str + "C#" + str + ";";
            MessageBox.Show(strOne + "     " + strTwo + "      " + strThree);
        }

        private void AddTab(Control c, TreeNode node)
        {
            TabPage tab = new TabPage();
            tab.Text = node.Text;
            tab.Controls.Add(c);
            tcExample.TabPages.Add(tab);
            tcExample.SelectedTab = tab;
        }

    }
}
