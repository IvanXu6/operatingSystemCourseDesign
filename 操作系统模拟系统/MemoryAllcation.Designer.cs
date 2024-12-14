namespace 操作系统模拟系统
{
    partial class MemoryAllcation
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.内存分配复选框 = new System.Windows.Forms.ComboBox();
            this.回收内存 = new System.Windows.Forms.Button();
            this.申请内存 = new System.Windows.Forms.Button();
            this.内存分配演示表格 = new System.Windows.Forms.DataGridView();
            this.起始地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内存块大小 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内存块状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内存分配日志区 = new System.Windows.Forms.TextBox();
            this.内存区域 = new System.Windows.Forms.Label();
            this.分配算法选择 = new System.Windows.Forms.ComboBox();
            this.分配算法 = new System.Windows.Forms.Label();
            this.所需内存 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.内存区域大小输入框 = new System.Windows.Forms.TextBox();
            this.内存区域大小 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.初始化内存分配 = new System.Windows.Forms.Button();
            this.清空日志 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.内存分配演示表格)).BeginInit();
            this.SuspendLayout();
            // 
            // 内存分配复选框
            // 
            this.内存分配复选框.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.内存分配复选框.FormattingEnabled = true;
            this.内存分配复选框.Items.AddRange(new object[] {
            "作业1",
            "作业2",
            "作业3",
            "作业4",
            "作业5",
            "作业6",
            "作业7"});
            this.内存分配复选框.Location = new System.Drawing.Point(432, 229);
            this.内存分配复选框.Name = "内存分配复选框";
            this.内存分配复选框.Size = new System.Drawing.Size(147, 32);
            this.内存分配复选框.TabIndex = 3;
            this.内存分配复选框.Text = "作业1";
            // 
            // 回收内存
            // 
            this.回收内存.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.回收内存.Location = new System.Drawing.Point(812, 310);
            this.回收内存.Name = "回收内存";
            this.回收内存.Size = new System.Drawing.Size(161, 56);
            this.回收内存.TabIndex = 4;
            this.回收内存.Text = "回收内存";
            this.回收内存.UseVisualStyleBackColor = true;
            this.回收内存.Click += new System.EventHandler(this.回收内存_Click);
            // 
            // 申请内存
            // 
            this.申请内存.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.申请内存.Location = new System.Drawing.Point(811, 223);
            this.申请内存.Name = "申请内存";
            this.申请内存.Size = new System.Drawing.Size(161, 56);
            this.申请内存.TabIndex = 5;
            this.申请内存.Text = "申请内存";
            this.申请内存.UseVisualStyleBackColor = true;
            this.申请内存.Click += new System.EventHandler(this.申请内存_Click);
            // 
            // 内存分配演示表格
            // 
            this.内存分配演示表格.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.内存分配演示表格.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.起始地址,
            this.结束地址,
            this.内存块大小,
            this.内存块状态,
            this.作业号});
            this.内存分配演示表格.Location = new System.Drawing.Point(562, 441);
            this.内存分配演示表格.Name = "内存分配演示表格";
            this.内存分配演示表格.RowHeadersWidth = 62;
            this.内存分配演示表格.RowTemplate.Height = 30;
            this.内存分配演示表格.Size = new System.Drawing.Size(972, 379);
            this.内存分配演示表格.TabIndex = 6;
            // 
            // 起始地址
            // 
            this.起始地址.HeaderText = "起始地址";
            this.起始地址.MinimumWidth = 8;
            this.起始地址.Name = "起始地址";
            this.起始地址.Width = 200;
            // 
            // 结束地址
            // 
            this.结束地址.HeaderText = "结束地址";
            this.结束地址.MinimumWidth = 8;
            this.结束地址.Name = "结束地址";
            this.结束地址.Width = 200;
            // 
            // 内存块大小
            // 
            this.内存块大小.HeaderText = "内存块大小";
            this.内存块大小.MinimumWidth = 8;
            this.内存块大小.Name = "内存块大小";
            this.内存块大小.Width = 200;
            // 
            // 内存块状态
            // 
            this.内存块状态.HeaderText = "内存块状态";
            this.内存块状态.MinimumWidth = 8;
            this.内存块状态.Name = "内存块状态";
            this.内存块状态.Width = 150;
            // 
            // 作业号
            // 
            this.作业号.HeaderText = "作业号";
            this.作业号.MinimumWidth = 8;
            this.作业号.Name = "作业号";
            this.作业号.Width = 150;
            // 
            // 内存分配日志区
            // 
            this.内存分配日志区.Location = new System.Drawing.Point(1247, 131);
            this.内存分配日志区.Multiline = true;
            this.内存分配日志区.Name = "内存分配日志区";
            this.内存分配日志区.Size = new System.Drawing.Size(455, 222);
            this.内存分配日志区.TabIndex = 7;
            this.内存分配日志区.Text = "请初始化！";
            // 
            // 内存区域
            // 
            this.内存区域.AutoSize = true;
            this.内存区域.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.内存区域.Location = new System.Drawing.Point(978, 404);
            this.内存区域.Name = "内存区域";
            this.内存区域.Size = new System.Drawing.Size(106, 24);
            this.内存区域.TabIndex = 8;
            this.内存区域.Text = "内存区域";
            // 
            // 分配算法选择
            // 
            this.分配算法选择.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.分配算法选择.FormattingEnabled = true;
            this.分配算法选择.Items.AddRange(new object[] {
            "首次适应算法",
            "快速适应算法"});
            this.分配算法选择.Location = new System.Drawing.Point(429, 131);
            this.分配算法选择.Name = "分配算法选择";
            this.分配算法选择.Size = new System.Drawing.Size(233, 32);
            this.分配算法选择.TabIndex = 9;
            this.分配算法选择.Text = "首次适应算法";
            // 
            // 分配算法
            // 
            this.分配算法.AutoSize = true;
            this.分配算法.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.分配算法.Location = new System.Drawing.Point(290, 134);
            this.分配算法.Name = "分配算法";
            this.分配算法.Size = new System.Drawing.Size(106, 24);
            this.分配算法.TabIndex = 10;
            this.分配算法.Text = "分配算法";
            // 
            // 所需内存
            // 
            this.所需内存.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.所需内存.Location = new System.Drawing.Point(638, 229);
            this.所需内存.Name = "所需内存";
            this.所需内存.Size = new System.Drawing.Size(130, 35);
            this.所需内存.TabIndex = 11;
            this.所需内存.Text = "所需内存";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // 内存区域大小输入框
            // 
            this.内存区域大小输入框.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.内存区域大小输入框.Location = new System.Drawing.Point(912, 126);
            this.内存区域大小输入框.Name = "内存区域大小输入框";
            this.内存区域大小输入框.Size = new System.Drawing.Size(60, 35);
            this.内存区域大小输入框.TabIndex = 12;
            this.内存区域大小输入框.Text = "128";
            // 
            // 内存区域大小
            // 
            this.内存区域大小.AutoSize = true;
            this.内存区域大小.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.内存区域大小.Location = new System.Drawing.Point(721, 134);
            this.内存区域大小.Name = "内存区域大小";
            this.内存区域大小.Size = new System.Drawing.Size(154, 24);
            this.内存区域大小.TabIndex = 13;
            this.内存区域大小.Text = "内存区域大小";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(978, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "KB";
            // 
            // 初始化内存分配
            // 
            this.初始化内存分配.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.初始化内存分配.Location = new System.Drawing.Point(1056, 115);
            this.初始化内存分配.Name = "初始化内存分配";
            this.初始化内存分配.Size = new System.Drawing.Size(161, 56);
            this.初始化内存分配.TabIndex = 15;
            this.初始化内存分配.Text = "初始化";
            this.初始化内存分配.UseVisualStyleBackColor = true;
            this.初始化内存分配.Click += new System.EventHandler(this.初始化内存分配_Click);
            // 
            // 清空日志
            // 
            this.清空日志.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.清空日志.Location = new System.Drawing.Point(1541, 372);
            this.清空日志.Name = "清空日志";
            this.清空日志.Size = new System.Drawing.Size(161, 56);
            this.清空日志.TabIndex = 16;
            this.清空日志.Text = "清空日志";
            this.清空日志.UseVisualStyleBackColor = true;
            // 
            // MemoryAllcation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1844, 912);
            this.Controls.Add(this.清空日志);
            this.Controls.Add(this.初始化内存分配);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.内存区域大小);
            this.Controls.Add(this.内存区域大小输入框);
            this.Controls.Add(this.所需内存);
            this.Controls.Add(this.分配算法);
            this.Controls.Add(this.分配算法选择);
            this.Controls.Add(this.内存区域);
            this.Controls.Add(this.内存分配日志区);
            this.Controls.Add(this.内存分配演示表格);
            this.Controls.Add(this.申请内存);
            this.Controls.Add(this.回收内存);
            this.Controls.Add(this.内存分配复选框);
            this.Name = "MemoryAllcation";
            this.Controls.SetChildIndex(this.内存分配复选框, 0);
            this.Controls.SetChildIndex(this.回收内存, 0);
            this.Controls.SetChildIndex(this.申请内存, 0);
            this.Controls.SetChildIndex(this.内存分配演示表格, 0);
            this.Controls.SetChildIndex(this.内存分配日志区, 0);
            this.Controls.SetChildIndex(this.内存区域, 0);
            this.Controls.SetChildIndex(this.分配算法选择, 0);
            this.Controls.SetChildIndex(this.分配算法, 0);
            this.Controls.SetChildIndex(this.所需内存, 0);
            this.Controls.SetChildIndex(this.内存区域大小输入框, 0);
            this.Controls.SetChildIndex(this.内存区域大小, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.初始化内存分配, 0);
            this.Controls.SetChildIndex(this.清空日志, 0);
            ((System.ComponentModel.ISupportInitialize)(this.内存分配演示表格)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox 内存分配复选框;
        private System.Windows.Forms.Button 回收内存;
        private System.Windows.Forms.Button 申请内存;
        private System.Windows.Forms.DataGridView 内存分配演示表格;
        private System.Windows.Forms.TextBox 内存分配日志区;
        private System.Windows.Forms.Label 内存区域;
        private System.Windows.Forms.ComboBox 分配算法选择;
        private System.Windows.Forms.Label 分配算法;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起始地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内存块大小;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内存块状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业号;
        private System.Windows.Forms.TextBox 所需内存;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox 内存区域大小输入框;
        private System.Windows.Forms.Label 内存区域大小;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button 初始化内存分配;
        private System.Windows.Forms.Button 清空日志;
    }
}
