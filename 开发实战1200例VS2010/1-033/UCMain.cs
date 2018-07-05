using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace 开发实战1200例VS2010._1_033
{
    public partial class UCMain : UserControl
    {
        int res = 0;
        int count = 0;
        Thread thTime = null;
        int time = 0;

        public UCMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            this.panel1.Controls.Clear();
            count = 0;
            time = 0;
            lblTime.Text = string.Empty;

            //随机生成一个数
            Random rd = new Random();
            res = rd.Next(1, 101);

            for (int i = 0; i < 100;i++ )
            {
                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 60;
                int row = i / 10;
                int col = i % 10;
                btn.Left = col * (btn.Width + 10);
                btn.Top = row * (btn.Height + 10);
                btn.Text = (i + 1).ToString();
                btn.Click += new EventHandler(btn_Click);
                this.panel1.Controls.Add(btn);
            }

            //启动计时器
            thTime = new Thread(CalcTime);
            thTime.IsBackground = true;
            thTime.Start();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            count++;
            Button btn=sender as Button;
            int num = 0;
            bool isConvert = int.TryParse(btn.Text, out num);
            if (isConvert == false)
            {
                return;
            }
            if (num > res)
            {
                btn.Text = "大";
                btn.BackColor = Color.Red;
            }
            else if (num < res)
            {
                btn.Text = "小";
                btn.BackColor = Color.Red;
            }
            else
            {
                thTime.Abort();
                string message = "恭喜你猜对了！共猜了" + count.ToString() + "次，用时" + lblTime.Text + "秒";
                MessageBox.Show(message,"恭喜！");
                btnStart.Enabled = true;
            }
        }

        private void CalcTime()
        {
            while (true)
            {
                string str = time.ToString();
                Action<string> time2dele = (x) => { lblTime.Text = str; };
                lblTime.Invoke(time2dele, str);
                time++;
                Thread.Sleep(1000);
            }
        }
    }
}
