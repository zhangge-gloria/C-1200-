namespace 开发实战1200例VS2010._1_096
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
            this.txtInsertIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldArray = new System.Windows.Forms.Label();
            this.btnGenerateArray = new System.Windows.Forms.Button();
            this.lblInserArray = new System.Windows.Forms.Label();
            this.btnInsertArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewArray
            // 
            this.lblNewArray.AutoSize = true;
            this.lblNewArray.Location = new System.Drawing.Point(31, 400);
            this.lblNewArray.Name = "lblNewArray";
            this.lblNewArray.Size = new System.Drawing.Size(0, 41);
            this.lblNewArray.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "新数组";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(575, 206);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(157, 78);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtInsertIndex
            // 
            this.txtInsertIndex.Location = new System.Drawing.Point(368, 234);
            this.txtInsertIndex.Name = "txtInsertIndex";
            this.txtInsertIndex.Size = new System.Drawing.Size(160, 50);
            this.txtInsertIndex.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "请输入要插入的位置：";
            // 
            // lblOldArray
            // 
            this.lblOldArray.AutoSize = true;
            this.lblOldArray.Location = new System.Drawing.Point(297, 39);
            this.lblOldArray.Name = "lblOldArray";
            this.lblOldArray.Size = new System.Drawing.Size(0, 41);
            this.lblOldArray.TabIndex = 10;
            // 
            // btnGenerateArray
            // 
            this.btnGenerateArray.Location = new System.Drawing.Point(31, 21);
            this.btnGenerateArray.Name = "btnGenerateArray";
            this.btnGenerateArray.Size = new System.Drawing.Size(230, 76);
            this.btnGenerateArray.TabIndex = 9;
            this.btnGenerateArray.Text = "随机生成数组";
            this.btnGenerateArray.UseVisualStyleBackColor = true;
            this.btnGenerateArray.Click += new System.EventHandler(this.btnGenerateArray_Click);
            // 
            // lblInserArray
            // 
            this.lblInserArray.AutoSize = true;
            this.lblInserArray.Location = new System.Drawing.Point(297, 148);
            this.lblInserArray.Name = "lblInserArray";
            this.lblInserArray.Size = new System.Drawing.Size(0, 41);
            this.lblInserArray.TabIndex = 19;
            // 
            // btnInsertArray
            // 
            this.btnInsertArray.Location = new System.Drawing.Point(31, 130);
            this.btnInsertArray.Name = "btnInsertArray";
            this.btnInsertArray.Size = new System.Drawing.Size(230, 76);
            this.btnInsertArray.TabIndex = 18;
            this.btnInsertArray.Text = "生成插入数组";
            this.btnInsertArray.UseVisualStyleBackColor = true;
            this.btnInsertArray.Click += new System.EventHandler(this.btnInsertArray_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblInserArray);
            this.Controls.Add(this.btnInsertArray);
            this.Controls.Add(this.lblNewArray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInsertIndex);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox txtInsertIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldArray;
        private System.Windows.Forms.Button btnGenerateArray;
        private System.Windows.Forms.Label lblInserArray;
        private System.Windows.Forms.Button btnInsertArray;
    }
}
