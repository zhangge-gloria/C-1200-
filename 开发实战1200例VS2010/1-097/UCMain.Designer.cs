namespace 开发实战1200例VS2010._1_097
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
            this.lblNewArray = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDeleteNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeleteIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOldArray = new System.Windows.Forms.Label();
            this.btnGenerateArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewArray
            // 
            this.lblNewArray.AutoSize = true;
            this.lblNewArray.Location = new System.Drawing.Point(47, 424);
            this.lblNewArray.Name = "lblNewArray";
            this.lblNewArray.Size = new System.Drawing.Size(0, 41);
            this.lblNewArray.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "新数组";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(643, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(157, 78);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDeleteNum
            // 
            this.txtDeleteNum.Location = new System.Drawing.Point(446, 247);
            this.txtDeleteNum.Name = "txtDeleteNum";
            this.txtDeleteNum.Size = new System.Drawing.Size(160, 50);
            this.txtDeleteNum.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "请输入要删除的元素个数：";
            // 
            // txtDeleteIndex
            // 
            this.txtDeleteIndex.Location = new System.Drawing.Point(446, 161);
            this.txtDeleteIndex.Name = "txtDeleteIndex";
            this.txtDeleteIndex.Size = new System.Drawing.Size(160, 50);
            this.txtDeleteIndex.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "请输入开始删除的索引：";
            // 
            // lblOldArray
            // 
            this.lblOldArray.AutoSize = true;
            this.lblOldArray.Location = new System.Drawing.Point(313, 63);
            this.lblOldArray.Name = "lblOldArray";
            this.lblOldArray.Size = new System.Drawing.Size(0, 41);
            this.lblOldArray.TabIndex = 10;
            // 
            // btnGenerateArray
            // 
            this.btnGenerateArray.Location = new System.Drawing.Point(47, 45);
            this.btnGenerateArray.Name = "btnGenerateArray";
            this.btnGenerateArray.Size = new System.Drawing.Size(230, 76);
            this.btnGenerateArray.TabIndex = 9;
            this.btnGenerateArray.Text = "随机生成数组";
            this.btnGenerateArray.UseVisualStyleBackColor = true;
            this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click);
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblNewArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDeleteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeleteIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOldArray);
            this.Controls.Add(this.btnGenerateArray);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDeleteNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeleteIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOldArray;
        private System.Windows.Forms.Button btnGenerateArray;
    }
}
