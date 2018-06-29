namespace 开发实战1200例VS2010
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("第1章 C#开发环境的使用");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("016 使用引号运算符进行赋值");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("017 使用算术运算符开发简单计算器");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("018 使用\"^\"运算符对数字进行加密");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("019 巧用位移运算符获取汉字编码值");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("020 使用条件运算符判断指定年份是不是闰年");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("021 使用流程控制语句报销业务花销");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2.2 运算符的使用", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("022 使用checked关键字处理\"溢出\"错误");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("023 使用typeof关键字获取类的内部结构");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("024 使用using关键字有效回收资源");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("025 使用is关键字检查对象是否与给定类型兼容");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("026 使用as关键字将对象转换为指定类型");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("2.3 关键字的使用", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("027 小明去学校和医院分别要走哪条路");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("028 利用条件语句判断用户登录身份");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("029 判断指定月份属于哪个季节");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("2.4 流程控制语句的使用", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("第2章 C#语言基础应用", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode14,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("第1篇 C#编程基础篇", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("第1卷", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.tcExample = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcExample);
            this.splitContainer1.Size = new System.Drawing.Size(1274, 729);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvMenu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(386, 729);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目录";
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvMenu.Location = new System.Drawing.Point(5, 48);
            this.tvMenu.Margin = new System.Windows.Forms.Padding(5);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Name = "节点8";
            treeNode1.Text = "第1章 C#开发环境的使用";
            treeNode2.Name = "节点11";
            treeNode2.Tag = "1-16";
            treeNode2.Text = "016 使用引号运算符进行赋值";
            treeNode3.Name = "节点0";
            treeNode3.Tag = "1-17";
            treeNode3.Text = "017 使用算术运算符开发简单计算器";
            treeNode4.Name = "节点0";
            treeNode4.Tag = "1-18";
            treeNode4.Text = "018 使用\"^\"运算符对数字进行加密";
            treeNode5.Name = "节点0";
            treeNode5.Tag = "1-19";
            treeNode5.Text = "019 巧用位移运算符获取汉字编码值";
            treeNode6.Name = "节点0";
            treeNode6.Tag = "1-20";
            treeNode6.Text = "020 使用条件运算符判断指定年份是不是闰年";
            treeNode7.Name = "节点1";
            treeNode7.Tag = "1-21";
            treeNode7.Text = "021 使用流程控制语句报销业务花销";
            treeNode8.Name = "节点10";
            treeNode8.Tag = "";
            treeNode8.Text = "2.2 运算符的使用";
            treeNode9.Name = "节点3";
            treeNode9.Tag = "1-22";
            treeNode9.Text = "022 使用checked关键字处理\"溢出\"错误";
            treeNode10.Name = "节点0";
            treeNode10.Tag = "1-23";
            treeNode10.Text = "023 使用typeof关键字获取类的内部结构";
            treeNode11.Name = "节点0";
            treeNode11.Tag = "1-24";
            treeNode11.Text = "024 使用using关键字有效回收资源";
            treeNode12.Name = "节点1";
            treeNode12.Tag = "1-25";
            treeNode12.Text = "025 使用is关键字检查对象是否与给定类型兼容";
            treeNode13.Name = "节点0";
            treeNode13.Tag = "1-26";
            treeNode13.Text = "026 使用as关键字将对象转换为指定类型";
            treeNode14.Name = "节点2";
            treeNode14.Text = "2.3 关键字的使用";
            treeNode15.Name = "节点1";
            treeNode15.Tag = "1-27";
            treeNode15.Text = "027 小明去学校和医院分别要走哪条路";
            treeNode16.Name = "节点2";
            treeNode16.Tag = "1-28";
            treeNode16.Text = "028 利用条件语句判断用户登录身份";
            treeNode17.Name = "节点3";
            treeNode17.Tag = "1-29";
            treeNode17.Text = "029 判断指定月份属于哪个季节";
            treeNode18.Name = "节点0";
            treeNode18.Text = "2.4 流程控制语句的使用";
            treeNode19.Name = "节点9";
            treeNode19.Text = "第2章 C#语言基础应用";
            treeNode20.Name = "节点7";
            treeNode20.Text = "第1篇 C#编程基础篇";
            treeNode21.Name = "节点6";
            treeNode21.Tag = "";
            treeNode21.Text = "第1卷";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.tvMenu.Size = new System.Drawing.Size(376, 676);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvMenu_MouseClick);
            // 
            // tcExample
            // 
            this.tcExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcExample.Location = new System.Drawing.Point(0, 0);
            this.tcExample.Name = "tcExample";
            this.tcExample.SelectedIndex = 0;
            this.tcExample.Size = new System.Drawing.Size(882, 729);
            this.tcExample.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 729);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#开发实战1200例";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.TabControl tcExample;
    }
}

