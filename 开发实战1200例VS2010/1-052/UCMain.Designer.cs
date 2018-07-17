namespace 开发实战1200例VS2010._1_052
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "二进制：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt16);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进制转换";
            // 
            // txt16
            // 
            this.txt16.Location = new System.Drawing.Point(159, 226);
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(249, 34);
            this.txt16.TabIndex = 7;
            this.txt16.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "十六进制：";
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(159, 170);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(249, 34);
            this.txt10.TabIndex = 5;
            this.txt10.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "十进制：";
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(159, 114);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(249, 34);
            this.txt8.TabIndex = 3;
            this.txt8.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "八进制：";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(159, 58);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(249, 34);
            this.txt2.TabIndex = 1;
            this.txt2.TextChanged += new System.EventHandler(this.txt_TextChanged);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
    }
}
