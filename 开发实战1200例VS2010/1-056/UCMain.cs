using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace 开发实战1200例VS2010._1_056
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            ChineseLunisolarCalendar chineseCalendar = new ChineseLunisolarCalendar();
            int year = chineseCalendar.GetSexagenaryYear(DateTime.Now);
            char[] treeYear = new char[12] { '鼠', '牛', '虎', '兔', '龙', '蛇', '马', '羊', '猴', '鸡', '狗', '猪' };
            int tree = chineseCalendar.GetTerrestrialBranch(year);
            MessageBox.Show(string.Format("今年是十二生肖{0}年。", treeYear[tree - 1].ToString()), "判断十二生肖");
        }

    }
}
