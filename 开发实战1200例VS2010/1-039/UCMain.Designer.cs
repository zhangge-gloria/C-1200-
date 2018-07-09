namespace 开发实战1200例VS2010._1_039
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "在下面文本框中输入字符串，并使用（，）号分隔。点击分行显示按钮，根据（，）号对字符串进行分行。";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(42, 118);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(572, 169);
            this.txtInput.TabIndex = 1;
            // 
            // btnNewLine
            // 
            this.btnNewLine.Location = new System.Drawing.Point(248, 308);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(114, 37);
            this.btnNewLine.TabIndex = 2;
            this.btnNewLine.Text = "分行";
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // lblShow
            // 
            this.lblShow.Location = new System.Drawing.Point(37, 366);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(577, 277);
            this.lblShow.TabIndex = 3;
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnNewLine);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.Label lblShow;
    }
}
