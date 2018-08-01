using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 开发实战1200例VS2010._1_084
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MatchCollection matches = Regex.Matches(txtInfo.Text, @"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (matches.Count!=0)
            {
                foreach (Match match in matches)
                {
                    string word = match.Groups["word"].Value;
                    MessageBox.Show(word.ToString(), "英文单词");
                }
            }
            else
            {
                MessageBox.Show("没有重复的单词");
            }
        }
    }
}
