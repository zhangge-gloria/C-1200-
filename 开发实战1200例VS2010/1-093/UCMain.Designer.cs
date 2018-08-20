namespace 开发实战1200例VS2010._1_093
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
            this.btnGetArray = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetArray
            // 
            this.btnGetArray.Location = new System.Drawing.Point(44, 35);
            this.btnGetArray.Name = "btnGetArray";
            this.btnGetArray.Size = new System.Drawing.Size(122, 31);
            this.btnGetArray.TabIndex = 0;
            this.btnGetArray.Text = "生成随机数列";
            this.btnGetArray.UseVisualStyleBackColor = true;
            this.btnGetArray.Click += new System.EventHandler(this.btnGetArray_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(184, 40);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 21);
            this.lblMsg.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(40, 99);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 21);
            this.lblShow.TabIndex = 2;
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnGetArray);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetArray;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblShow;
    }
}
