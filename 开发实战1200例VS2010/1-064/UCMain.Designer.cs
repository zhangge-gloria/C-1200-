namespace 开发实战1200例VS2010._1_064
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
            this.btnGetFirst = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.btnGetSec = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCalc = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFirst);
            this.groupBox1.Controls.Add(this.btnGetFirst);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一次获取时间";
            // 
            // btnGetFirst
            // 
            this.btnGetFirst.Location = new System.Drawing.Point(157, 54);
            this.btnGetFirst.Name = "btnGetFirst";
            this.btnGetFirst.Size = new System.Drawing.Size(206, 38);
            this.btnGetFirst.TabIndex = 0;
            this.btnGetFirst.Text = "第一次获取系统时间";
            this.btnGetFirst.UseVisualStyleBackColor = true;
            this.btnGetFirst.Click += new System.EventHandler(this.btnGetFirst_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(20, 131);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 27);
            this.lblFirst.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSec);
            this.groupBox2.Controls.Add(this.btnGetSec);
            this.groupBox2.Location = new System.Drawing.Point(31, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二次获取时间";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(20, 131);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(0, 27);
            this.lblSec.TabIndex = 1;
            // 
            // btnGetSec
            // 
            this.btnGetSec.Location = new System.Drawing.Point(157, 54);
            this.btnGetSec.Name = "btnGetSec";
            this.btnGetSec.Size = new System.Drawing.Size(206, 38);
            this.btnGetSec.TabIndex = 0;
            this.btnGetSec.Text = "第二次获取系统时间";
            this.btnGetSec.UseVisualStyleBackColor = true;
            this.btnGetSec.Click += new System.EventHandler(this.btnGetSec_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCalc);
            this.groupBox3.Controls.Add(this.btnCalc);
            this.groupBox3.Location = new System.Drawing.Point(31, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计算时间间隔";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(20, 131);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(0, 27);
            this.lblCalc.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(157, 54);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(206, 38);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "计算时间间隔";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // UCMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1312, 915);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Button btnGetFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button btnGetSec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Button btnCalc;
    }
}
