namespace 开发实战1200例VS2010._1_025
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
            this.rbtnClass1 = new System.Windows.Forms.RadioButton();
            this.rbtnClass2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnFileInfo = new System.Windows.Forms.RadioButton();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnClass2);
            this.groupBox1.Controls.Add(this.rbtnClass1);
            this.groupBox1.Location = new System.Drawing.Point(48, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对象";
            // 
            // rbtnClass1
            // 
            this.rbtnClass1.AutoSize = true;
            this.rbtnClass1.Checked = true;
            this.rbtnClass1.Location = new System.Drawing.Point(18, 60);
            this.rbtnClass1.Name = "rbtnClass1";
            this.rbtnClass1.Size = new System.Drawing.Size(209, 45);
            this.rbtnClass1.TabIndex = 0;
            this.rbtnClass1.TabStop = true;
            this.rbtnClass1.Text = "字符串对象";
            this.rbtnClass1.UseVisualStyleBackColor = true;
            // 
            // rbtnClass2
            // 
            this.rbtnClass2.AutoSize = true;
            this.rbtnClass2.Location = new System.Drawing.Point(18, 111);
            this.rbtnClass2.Name = "rbtnClass2";
            this.rbtnClass2.Size = new System.Drawing.Size(177, 45);
            this.rbtnClass2.TabIndex = 1;
            this.rbtnClass2.TabStop = true;
            this.rbtnClass2.Text = "文件对象";
            this.rbtnClass2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnFileInfo);
            this.groupBox2.Controls.Add(this.rbtnString);
            this.groupBox2.Location = new System.Drawing.Point(299, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "类型";
            // 
            // rbtnFileInfo
            // 
            this.rbtnFileInfo.AutoSize = true;
            this.rbtnFileInfo.Location = new System.Drawing.Point(18, 111);
            this.rbtnFileInfo.Name = "rbtnFileInfo";
            this.rbtnFileInfo.Size = new System.Drawing.Size(226, 45);
            this.rbtnFileInfo.TabIndex = 1;
            this.rbtnFileInfo.TabStop = true;
            this.rbtnFileInfo.Text = "FileInfo类型";
            this.rbtnFileInfo.UseVisualStyleBackColor = true;
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Checked = true;
            this.rbtnString.Location = new System.Drawing.Point(18, 60);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(201, 45);
            this.rbtnString.TabIndex = 0;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "string类型";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "查看是否兼容";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(880, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnClass2;
        private System.Windows.Forms.RadioButton rbtnClass1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnFileInfo;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.Button button1;
    }
}
