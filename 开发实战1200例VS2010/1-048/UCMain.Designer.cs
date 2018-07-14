namespace 开发实战1200例VS2010._1_048
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cbxPoint = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(45, 29);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(172, 34);
            this.txtNum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(256, 29);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(172, 34);
            this.txtNum2.TabIndex = 2;
            // 
            // cbxPoint
            // 
            this.cbxPoint.FormattingEnabled = true;
            this.cbxPoint.Items.AddRange(new object[] {
            "保留1位小数",
            "保留2位小数",
            "保留3位小数",
            "保留4位小数",
            "保留5位小数",
            "保留6位小数",
            "保留7位小数",
            "保留8位小数",
            "保留9位小数"});
            this.cbxPoint.Location = new System.Drawing.Point(45, 98);
            this.cbxPoint.Name = "cbxPoint";
            this.cbxPoint.Size = new System.Drawing.Size(232, 35);
            this.cbxPoint.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(314, 98);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(114, 35);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(45, 168);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 27);
            this.lblResult.TabIndex = 5;
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbxPoint);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.Load += new System.EventHandler(this.UCMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cbxPoint;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
    }
}
