namespace 开发实战1200例VS2010._1_029
{
    partial class UCMain
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.btnSeason = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择月份：";
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cbxMonth.Location = new System.Drawing.Point(216, 55);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(121, 49);
            this.cbxMonth.TabIndex = 1;
            // 
            // btnSeason
            // 
            this.btnSeason.Location = new System.Drawing.Point(118, 119);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(155, 62);
            this.btnSeason.TabIndex = 2;
            this.btnSeason.Text = "判断季节";
            this.btnSeason.UseVisualStyleBackColor = true;
            this.btnSeason.Click += new System.EventHandler(this.btnSeason_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSeason);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(880, 700);
            this.Load += new System.EventHandler(this.UCMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.Button btnSeason;
    }
}
