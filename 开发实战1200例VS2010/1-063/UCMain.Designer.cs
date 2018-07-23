namespace 开发实战1200例VS2010._1_063
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAddMin = new System.Windows.Forms.Button();
            this.btnAddHour = new System.Windows.Forms.Button();
            this.btnAddDay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDay);
            this.groupBox1.Controls.Add(this.btnAddHour);
            this.groupBox1.Controls.Add(this.btnAddMin);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加时间间隔";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(107, 67);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 27);
            this.lblTime.TabIndex = 1;
            // 
            // btnAddMin
            // 
            this.btnAddMin.Location = new System.Drawing.Point(66, 136);
            this.btnAddMin.Name = "btnAddMin";
            this.btnAddMin.Size = new System.Drawing.Size(104, 37);
            this.btnAddMin.TabIndex = 2;
            this.btnAddMin.Text = "加1分钟";
            this.btnAddMin.UseVisualStyleBackColor = true;
            this.btnAddMin.Click += new System.EventHandler(this.btnAddMin_Click);
            // 
            // btnAddHour
            // 
            this.btnAddHour.Location = new System.Drawing.Point(174, 136);
            this.btnAddHour.Name = "btnAddHour";
            this.btnAddHour.Size = new System.Drawing.Size(104, 37);
            this.btnAddHour.TabIndex = 3;
            this.btnAddHour.Text = "加1小时";
            this.btnAddHour.UseVisualStyleBackColor = true;
            this.btnAddHour.Click += new System.EventHandler(this.btnAddHour_Click);
            // 
            // btnAddDay
            // 
            this.btnAddDay.Location = new System.Drawing.Point(282, 136);
            this.btnAddDay.Name = "btnAddDay";
            this.btnAddDay.Size = new System.Drawing.Size(104, 37);
            this.btnAddDay.TabIndex = 4;
            this.btnAddDay.Text = "加1天";
            this.btnAddDay.UseVisualStyleBackColor = true;
            this.btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.Load += new System.EventHandler(this.UCMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDay;
        private System.Windows.Forms.Button btnAddHour;
        private System.Windows.Forms.Button btnAddMin;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
    }
}
