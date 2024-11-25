namespace 操作系统模拟系统
{
    partial class processSynchronization
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.缓冲区编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目前状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.生产者编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目前操作_生产 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否堵塞_生产 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.消费者编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目前操作_消费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否阻塞_消费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.增加生产者 = new System.Windows.Forms.Button();
            this.生产数据 = new System.Windows.Forms.Button();
            this.消费数据 = new System.Windows.Forms.Button();
            this.增加消费者 = new System.Windows.Forms.Button();
            this.清空缓冲区 = new System.Windows.Forms.Button();
            this.自动演示 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.缓冲区编号,
            this.数据名,
            this.目前状态});
            this.dataGridView1.Location = new System.Drawing.Point(805, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(507, 321);
            this.dataGridView1.TabIndex = 3;
            // 
            // 缓冲区编号
            // 
            this.缓冲区编号.HeaderText = "缓冲区编号";
            this.缓冲区编号.MinimumWidth = 8;
            this.缓冲区编号.Name = "缓冲区编号";
            this.缓冲区编号.Width = 150;
            // 
            // 数据名
            // 
            this.数据名.HeaderText = "数据名";
            this.数据名.MinimumWidth = 8;
            this.数据名.Name = "数据名";
            this.数据名.Width = 150;
            // 
            // 目前状态
            // 
            this.目前状态.HeaderText = "目前状态";
            this.目前状态.MinimumWidth = 8;
            this.目前状态.Name = "目前状态";
            this.目前状态.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.生产者编号,
            this.目前操作_生产,
            this.是否堵塞_生产});
            this.dataGridView2.Location = new System.Drawing.Point(264, 213);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(481, 321);
            this.dataGridView2.TabIndex = 4;
            // 
            // 生产者编号
            // 
            this.生产者编号.HeaderText = "生产者编号";
            this.生产者编号.MinimumWidth = 8;
            this.生产者编号.Name = "生产者编号";
            this.生产者编号.Width = 150;
            // 
            // 目前操作_生产
            // 
            this.目前操作_生产.HeaderText = "目前操作";
            this.目前操作_生产.MinimumWidth = 8;
            this.目前操作_生产.Name = "目前操作_生产";
            this.目前操作_生产.Width = 150;
            // 
            // 是否堵塞_生产
            // 
            this.是否堵塞_生产.HeaderText = "是否堵塞";
            this.是否堵塞_生产.MinimumWidth = 8;
            this.是否堵塞_生产.Name = "是否堵塞_生产";
            this.是否堵塞_生产.Width = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.消费者编号,
            this.目前操作_消费,
            this.是否阻塞_消费});
            this.dataGridView3.Location = new System.Drawing.Point(1367, 213);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 30;
            this.dataGridView3.Size = new System.Drawing.Size(465, 321);
            this.dataGridView3.TabIndex = 5;
            // 
            // 消费者编号
            // 
            this.消费者编号.HeaderText = "消费者编号";
            this.消费者编号.MinimumWidth = 8;
            this.消费者编号.Name = "消费者编号";
            this.消费者编号.Width = 150;
            // 
            // 目前操作_消费
            // 
            this.目前操作_消费.HeaderText = "目前操作";
            this.目前操作_消费.MinimumWidth = 8;
            this.目前操作_消费.Name = "目前操作_消费";
            this.目前操作_消费.Width = 150;
            // 
            // 是否阻塞_消费
            // 
            this.是否阻塞_消费.HeaderText = "是否阻塞";
            this.是否阻塞_消费.MinimumWidth = 8;
            this.是否阻塞_消费.Name = "是否阻塞_消费";
            this.是否阻塞_消费.Width = 150;
            // 
            // 增加生产者
            // 
            this.增加生产者.Location = new System.Drawing.Point(398, 570);
            this.增加生产者.Name = "增加生产者";
            this.增加生产者.Size = new System.Drawing.Size(211, 64);
            this.增加生产者.TabIndex = 6;
            this.增加生产者.Text = "增加生产者";
            this.增加生产者.UseVisualStyleBackColor = true;
            this.增加生产者.Click += new System.EventHandler(this.button8_Click);
            // 
            // 生产数据
            // 
            this.生产数据.Location = new System.Drawing.Point(398, 664);
            this.生产数据.Name = "生产数据";
            this.生产数据.Size = new System.Drawing.Size(211, 64);
            this.生产数据.TabIndex = 7;
            this.生产数据.Text = "生产数据";
            this.生产数据.UseVisualStyleBackColor = true;
            this.生产数据.Click += new System.EventHandler(this.生产数据_Click);
            // 
            // 消费数据
            // 
            this.消费数据.Location = new System.Drawing.Point(1503, 664);
            this.消费数据.Name = "消费数据";
            this.消费数据.Size = new System.Drawing.Size(211, 64);
            this.消费数据.TabIndex = 9;
            this.消费数据.Text = "消费数据";
            this.消费数据.UseVisualStyleBackColor = true;
            // 
            // 增加消费者
            // 
            this.增加消费者.Location = new System.Drawing.Point(1503, 570);
            this.增加消费者.Name = "增加消费者";
            this.增加消费者.Size = new System.Drawing.Size(211, 64);
            this.增加消费者.TabIndex = 8;
            this.增加消费者.Text = "增加消费者";
            this.增加消费者.UseVisualStyleBackColor = true;
            // 
            // 清空缓冲区
            // 
            this.清空缓冲区.Location = new System.Drawing.Point(961, 658);
            this.清空缓冲区.Name = "清空缓冲区";
            this.清空缓冲区.Size = new System.Drawing.Size(211, 64);
            this.清空缓冲区.TabIndex = 11;
            this.清空缓冲区.Text = "清空缓冲区";
            this.清空缓冲区.UseVisualStyleBackColor = true;
            this.清空缓冲区.Click += new System.EventHandler(this.清空缓冲区_Click);
            // 
            // 自动演示
            // 
            this.自动演示.Location = new System.Drawing.Point(961, 564);
            this.自动演示.Name = "自动演示";
            this.自动演示.Size = new System.Drawing.Size(211, 64);
            this.自动演示.TabIndex = 10;
            this.自动演示.Text = "自动演示";
            this.自动演示.UseVisualStyleBackColor = true;
            this.自动演示.Click += new System.EventHandler(this.自动演示_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "记录型信号量",
            "AND型信号量"});
            this.comboBox1.Location = new System.Drawing.Point(479, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 41);
            this.comboBox1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(266, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 33);
            this.label13.TabIndex = 13;
            this.label13.Text = "信号量类型：";
            // 
            // processSynchronization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1844, 912);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.清空缓冲区);
            this.Controls.Add(this.自动演示);
            this.Controls.Add(this.消费数据);
            this.Controls.Add(this.增加消费者);
            this.Controls.Add(this.生产数据);
            this.Controls.Add(this.增加生产者);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "processSynchronization";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.dataGridView3, 0);
            this.Controls.SetChildIndex(this.增加生产者, 0);
            this.Controls.SetChildIndex(this.生产数据, 0);
            this.Controls.SetChildIndex(this.增加消费者, 0);
            this.Controls.SetChildIndex(this.消费数据, 0);
            this.Controls.SetChildIndex(this.自动演示, 0);
            this.Controls.SetChildIndex(this.清空缓冲区, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 缓冲区编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目前状态;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产者编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目前操作_生产;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否堵塞_生产;
        private System.Windows.Forms.DataGridViewTextBoxColumn 消费者编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目前操作_消费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否阻塞_消费;
        private System.Windows.Forms.Button 增加生产者;
        private System.Windows.Forms.Button 生产数据;
        private System.Windows.Forms.Button 消费数据;
        private System.Windows.Forms.Button 增加消费者;
        private System.Windows.Forms.Button 清空缓冲区;
        private System.Windows.Forms.Button 自动演示;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
    }
}
