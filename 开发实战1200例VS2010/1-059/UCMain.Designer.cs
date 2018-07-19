namespace 开发实战1200例VS2010._1_059
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
            this.btnGetDays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetDays
            // 
            this.btnGetDays.Location = new System.Drawing.Point(50, 44);
            this.btnGetDays.Name = "btnGetDays";
            this.btnGetDays.Size = new System.Drawing.Size(185, 58);
            this.btnGetDays.TabIndex = 0;
            this.btnGetDays.Text = "获取当前月的天数";
            this.btnGetDays.UseVisualStyleBackColor = true;
            this.btnGetDays.Click += new System.EventHandler(this.btnGetDays_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnGetDays);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetDays;
    }
}
