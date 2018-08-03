namespace 开发实战1200例VS2010._1_086
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
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(237, 187);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(159, 50);
            this.btnSplit.TabIndex = 9;
            this.btnSplit.Text = "拆分字符";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(237, 101);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(383, 50);
            this.txtAfter.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "拆分后字符串：";
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(237, 30);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(383, 50);
            this.txtPre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "拆分前字符串：";
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label label1;
    }
}
