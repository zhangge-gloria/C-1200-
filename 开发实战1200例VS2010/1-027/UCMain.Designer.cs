namespace 开发实战1200例VS2010._1_027
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
            this.rbtnSchool = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnSchool
            // 
            this.rbtnSchool.AutoSize = true;
            this.rbtnSchool.Checked = true;
            this.rbtnSchool.Location = new System.Drawing.Point(48, 102);
            this.rbtnSchool.Name = "rbtnSchool";
            this.rbtnSchool.Size = new System.Drawing.Size(145, 45);
            this.rbtnSchool.TabIndex = 0;
            this.rbtnSchool.TabStop = true;
            this.rbtnSchool.Text = "去学校";
            this.rbtnSchool.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(199, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 45);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "去医院";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(105, 153);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(111, 51);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "出发";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbtnSchool);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(880, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnSchool;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnGo;
    }
}
