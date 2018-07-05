namespace 开发实战1200例VS2010._1_036
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
            this.txtCharPre = new System.Windows.Forms.TextBox();
            this.btnChar2ASCII = new System.Windows.Forms.Button();
            this.txtASCIIAfter = new System.Windows.Forms.TextBox();
            this.txtCharAfter = new System.Windows.Forms.TextBox();
            this.btnASCII2Char = new System.Windows.Forms.Button();
            this.txtASCIIPre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCharAfter);
            this.groupBox1.Controls.Add(this.btnASCII2Char);
            this.groupBox1.Controls.Add(this.txtASCIIPre);
            this.groupBox1.Controls.Add(this.txtASCIIAfter);
            this.groupBox1.Controls.Add(this.btnChar2ASCII);
            this.groupBox1.Controls.Add(this.txtCharPre);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字母与ASCII相互转换";
            // 
            // txtCharPre
            // 
            this.txtCharPre.Location = new System.Drawing.Point(30, 67);
            this.txtCharPre.Name = "txtCharPre";
            this.txtCharPre.Size = new System.Drawing.Size(119, 34);
            this.txtCharPre.TabIndex = 0;
            // 
            // btnChar2ASCII
            // 
            this.btnChar2ASCII.Location = new System.Drawing.Point(162, 67);
            this.btnChar2ASCII.Name = "btnChar2ASCII";
            this.btnChar2ASCII.Size = new System.Drawing.Size(186, 34);
            this.btnChar2ASCII.TabIndex = 1;
            this.btnChar2ASCII.Text = "转换为ASCII码";
            this.btnChar2ASCII.UseVisualStyleBackColor = true;
            this.btnChar2ASCII.Click += new System.EventHandler(this.btnChar2ASCII_Click);
            // 
            // txtASCIIAfter
            // 
            this.txtASCIIAfter.Location = new System.Drawing.Point(361, 68);
            this.txtASCIIAfter.Name = "txtASCIIAfter";
            this.txtASCIIAfter.Size = new System.Drawing.Size(119, 34);
            this.txtASCIIAfter.TabIndex = 2;
            // 
            // txtCharAfter
            // 
            this.txtCharAfter.Location = new System.Drawing.Point(361, 130);
            this.txtCharAfter.Name = "txtCharAfter";
            this.txtCharAfter.Size = new System.Drawing.Size(119, 34);
            this.txtCharAfter.TabIndex = 5;
            // 
            // btnASCII2Char
            // 
            this.btnASCII2Char.Location = new System.Drawing.Point(162, 129);
            this.btnASCII2Char.Name = "btnASCII2Char";
            this.btnASCII2Char.Size = new System.Drawing.Size(186, 34);
            this.btnASCII2Char.TabIndex = 4;
            this.btnASCII2Char.Text = "转换为字母";
            this.btnASCII2Char.UseVisualStyleBackColor = true;
            this.btnASCII2Char.Click += new System.EventHandler(this.btnASCII2Char_Click);
            // 
            // txtASCIIPre
            // 
            this.txtASCIIPre.Location = new System.Drawing.Point(30, 129);
            this.txtASCIIPre.Name = "txtASCIIPre";
            this.txtASCIIPre.Size = new System.Drawing.Size(119, 34);
            this.txtASCIIPre.TabIndex = 3;
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCharAfter;
        private System.Windows.Forms.Button btnASCII2Char;
        private System.Windows.Forms.TextBox txtASCIIPre;
        private System.Windows.Forms.TextBox txtASCIIAfter;
        private System.Windows.Forms.Button btnChar2ASCII;
        private System.Windows.Forms.TextBox txtCharPre;
    }
}
