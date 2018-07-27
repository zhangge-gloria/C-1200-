namespace 开发实战1200例VS2010._1_074
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(95, 73);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(142, 39);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "验证身份证号";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(138, 22);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(215, 34);
            this.txtNum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "身份证号：";
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
    }
}
