namespace 开发实战1200例VS2010._1_035
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
            this.txtPre = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbtnUpper = new System.Windows.Forms.RadioButton();
            this.rbtnLower = new System.Windows.Forms.RadioButton();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAfter);
            this.groupBox1.Controls.Add(this.rbtnLower);
            this.groupBox1.Controls.Add(this.rbtnUpper);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.txtPre);
            this.groupBox1.Location = new System.Drawing.Point(46, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大小写转换";
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(26, 47);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(388, 34);
            this.txtPre.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(26, 103);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(115, 38);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "转换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rbtnUpper
            // 
            this.rbtnUpper.AutoSize = true;
            this.rbtnUpper.Checked = true;
            this.rbtnUpper.Location = new System.Drawing.Point(234, 107);
            this.rbtnUpper.Name = "rbtnUpper";
            this.rbtnUpper.Size = new System.Drawing.Size(73, 31);
            this.rbtnUpper.TabIndex = 2;
            this.rbtnUpper.TabStop = true;
            this.rbtnUpper.Text = "大写";
            this.rbtnUpper.UseVisualStyleBackColor = true;
            // 
            // rbtnLower
            // 
            this.rbtnLower.AutoSize = true;
            this.rbtnLower.Location = new System.Drawing.Point(341, 107);
            this.rbtnLower.Name = "rbtnLower";
            this.rbtnLower.Size = new System.Drawing.Size(73, 31);
            this.rbtnLower.TabIndex = 3;
            this.rbtnLower.Text = "小写";
            this.rbtnLower.UseVisualStyleBackColor = true;
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(26, 163);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(388, 34);
            this.txtAfter.TabIndex = 4;
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
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.RadioButton rbtnLower;
        private System.Windows.Forms.RadioButton rbtnUpper;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtPre;
    }
}
