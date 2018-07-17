using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 开发实战1200例VS2010._1_054
{
    public partial class UCMain : UserControl
    {
        [DllImport("Kernel32.dll")]
        public static extern bool SetLocalTime(ref SystemTime st);
        [DllImport("Kernel32.dll")]
        public static extern void GetLocalTime(ref SystemTime st);

        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            SystemTime st = new SystemTime();
            GetLocalTime(ref st);
            lblShowTime.Text = st.wYear.ToString() + "年" + st.wMonth.ToString() + "月" + st.wDay.ToString() + "日 " + st.wHour.ToString() + ":" + st.wMinute.ToString() + ":" + st.wSecond.ToString();
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要设置时间？", "提醒", MessageBoxButtons.YesNo);
            if (dr==DialogResult.No)
            {
                return;
            }
            SystemTime st = new SystemTime();
            st.wYear = (UInt16)dtpDate.Value.Year;
            st.wMonth = (UInt16)dtpDate.Value.Month;
            st.wDay = (UInt16)dtpDate.Value.Day;
            st.wHour = (UInt16)dtpTime.Value.Hour;
            st.wMinute = (UInt16)dtpTime.Value.Minute;
            st.wSecond = (UInt16)dtpTime.Value.Second;
            bool res = SetLocalTime(ref st);
            if (res==false)
            {
                MessageBox.Show("设置日期时间失败。");
            }
            btnGetTime_Click(null, null);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SystemTime
    {
        public UInt16 wYear;
        public UInt16 wMonth;
        public UInt16 wDayOfWeek;
        public UInt16 wDay;
        public UInt16 wHour;
        public UInt16 wMinute;
        public UInt16 wSecond;
        public UInt16 wMiliseconds;
    }
}
