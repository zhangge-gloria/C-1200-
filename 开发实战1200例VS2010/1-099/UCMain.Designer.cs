namespace 开发实战1200例VS2010._1_099
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
            this.lblArray = new System.Windows.Forms.Label();
            this.btnGenerateArray = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(299, 53);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 41);
            this.lblArray.TabIndex = 21;
            // 
            // btnGenerateArray
            // 
            this.btnGenerateArray.Location = new System.Drawing.Point(33, 35);
            this.btnGenerateArray.Name = "btnGenerateArray";
            this.btnGenerateArray.Size = new System.Drawing.Size(230, 76);
            this.btnGenerateArray.TabIndex = 20;
            this.btnGenerateArray.Text = "随机生成数组";
            this.btnGenerateArray.UseVisualStyleBackColor = true;
            this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(299, 181);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(0, 41);
            this.lblSort.TabIndex = 23;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(33, 163);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(230, 76);
            this.btnSort.TabIndex = 22;
            this.btnSort.Text = "选择排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnGenerateArray);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnGenerateArray;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSort;
    }
}
