using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 开发实战1200例VS2010._1_052
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                if (txt.Text==string.Empty)
                {
                    txt2.Text = string.Empty;
                    txt8.Text = string.Empty;
                    txt10.Text = string.Empty;
                    txt16.Text = string.Empty;
                    return;
                }
                switch (txt.Name)
                {
                    case "txt2":
                        {
                            Int64 num10 = Convert.ToInt64(txt.Text, 2);
                            txt8.Text = Convert.ToString(num10, 8);
                            txt10.Text = num10.ToString();
                            txt16.Text = Convert.ToString(num10, 16);
                        }
                        break;
                    case "txt8":
                        {
                            Int64 num10 = Convert.ToInt64(txt.Text, 8);
                            txt2.Text = Convert.ToString(num10, 2);
                            txt10.Text = num10.ToString();
                            txt16.Text = Convert.ToString(num10, 16);
                        }
                        break;
                    case "txt10":
                        {
                            Int64 num10 = Int64.Parse(txt.Text);
                            txt2.Text = Convert.ToString(num10, 2);
                            txt8.Text = Convert.ToString(num10, 8);
                            txt16.Text = Convert.ToString(num10, 16);
                        }
                        break;
                    case "txt16":
                        {
                            Int64 num10 = Convert.ToInt64(txt.Text, 16);
                            txt2.Text = Convert.ToString(num10, 2);
                            txt8.Text = Convert.ToString(num10, 8);
                            txt10.Text = num10.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
