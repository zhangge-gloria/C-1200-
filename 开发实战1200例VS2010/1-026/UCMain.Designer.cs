namespace 开发实战1200例VS2010._1_026
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
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.rbtnStream = new System.Windows.Forms.RadioButton();
            this.rbtnObj = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnString);
            this.groupBox1.Controls.Add(this.rbtnStream);
            this.groupBox1.Controls.Add(this.rbtnObj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(408, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型转换";
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Location = new System.Drawing.Point(24, 194);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(190, 31);
            this.rbtnString.TabIndex = 3;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "转换为String类型";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // rbtnStream
            // 
            this.rbtnStream.AutoSize = true;
            this.rbtnStream.Location = new System.Drawing.Point(24, 144);
            this.rbtnStream.Name = "rbtnStream";
            this.rbtnStream.Size = new System.Drawing.Size(201, 31);
            this.rbtnStream.TabIndex = 2;
            this.rbtnStream.TabStop = true;
            this.rbtnStream.Text = "转换为Stream类型";
            this.rbtnStream.UseVisualStyleBackColor = true;
            // 
            // rbtnObj
            // 
            this.rbtnObj.AutoSize = true;
            this.rbtnObj.Location = new System.Drawing.Point(24, 94);
            this.rbtnObj.Name = "rbtnObj";
            this.rbtnObj.Size = new System.Drawing.Size(195, 31);
            this.rbtnObj.TabIndex = 1;
            this.rbtnObj.TabStop = true;
            this.rbtnObj.Text = "转换为Object类型";
            this.rbtnObj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "将FileStream类型转换为：";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(133, 295);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(167, 48);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "类型转换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.RadioButton rbtnStream;
        private System.Windows.Forms.RadioButton rbtnObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
    }
}
