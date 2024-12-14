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
            this.BufferView = new System.Windows.Forms.DataGridView();
            this.ProcucerView = new System.Windows.Forms.DataGridView();
            this.生产者编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目前操作_生产 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsumerView = new System.Windows.Forms.DataGridView();
            this.消费者编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目前操作_消费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.增加生产者 = new System.Windows.Forms.Button();
            this.增加消费者 = new System.Windows.Forms.Button();
            this.清空缓冲区 = new System.Windows.Forms.Button();
            this.自动演示 = new System.Windows.Forms.Button();
            this.comboSemaphore = new System.Windows.Forms.ComboBox();
            this.lab_Semaphore = new System.Windows.Forms.Label();
            this.txt_Diary = new System.Windows.Forms.TextBox();
            this.缓冲区编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BufferView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcucerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumerView)).BeginInit();
            this.SuspendLayout();
            // 
            // BufferView
            // 
            this.BufferView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BufferView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.缓冲区编号,
            this.数据名});
            this.BufferView.Location = new System.Drawing.Point(675, 213);
            this.BufferView.Name = "BufferView";
            this.BufferView.RowHeadersWidth = 62;
            this.BufferView.RowTemplate.Height = 30;
            this.BufferView.Size = new System.Drawing.Size(408, 321);
            this.BufferView.TabIndex = 3;
            // 
            // ProcucerView
            // 
            this.ProcucerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcucerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.生产者编号,
            this.目前操作_生产});
            this.ProcucerView.Location = new System.Drawing.Point(264, 213);
            this.ProcucerView.Name = "ProcucerView";
            this.ProcucerView.RowHeadersWidth = 62;
            this.ProcucerView.RowTemplate.Height = 30;
            this.ProcucerView.Size = new System.Drawing.Size(365, 321);
            this.ProcucerView.TabIndex = 4;
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
            // ConsumerView
            // 
            this.ConsumerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsumerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.消费者编号,
            this.目前操作_消费});
            this.ConsumerView.Location = new System.Drawing.Point(1089, 213);
            this.ConsumerView.Name = "ConsumerView";
            this.ConsumerView.RowHeadersWidth = 62;
            this.ConsumerView.RowTemplate.Height = 30;
            this.ConsumerView.Size = new System.Drawing.Size(365, 321);
            this.ConsumerView.TabIndex = 5;
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
            // 增加生产者
            // 
            this.增加生产者.Location = new System.Drawing.Point(318, 630);
            this.增加生产者.Name = "增加生产者";
            this.增加生产者.Size = new System.Drawing.Size(211, 64);
            this.增加生产者.TabIndex = 6;
            this.增加生产者.Text = "增加生产者";
            this.增加生产者.UseVisualStyleBackColor = true;
            this.增加生产者.Click += new System.EventHandler(this.button8_Click);
            // 
            // 增加消费者
            // 
            this.增加消费者.Location = new System.Drawing.Point(1172, 630);
            this.增加消费者.Name = "增加消费者";
            this.增加消费者.Size = new System.Drawing.Size(211, 64);
            this.增加消费者.TabIndex = 8;
            this.增加消费者.Text = "增加消费者";
            this.增加消费者.UseVisualStyleBackColor = true;
            this.增加消费者.Click += new System.EventHandler(this.增加消费者_Click);
            // 
            // 清空缓冲区
            // 
            this.清空缓冲区.Location = new System.Drawing.Point(725, 746);
            this.清空缓冲区.Name = "清空缓冲区";
            this.清空缓冲区.Size = new System.Drawing.Size(211, 64);
            this.清空缓冲区.TabIndex = 11;
            this.清空缓冲区.Text = "清空缓冲区";
            this.清空缓冲区.UseVisualStyleBackColor = true;
            this.清空缓冲区.Click += new System.EventHandler(this.清空缓冲区_Click);
            // 
            // 自动演示
            // 
            this.自动演示.Location = new System.Drawing.Point(725, 630);
            this.自动演示.Name = "自动演示";
            this.自动演示.Size = new System.Drawing.Size(211, 64);
            this.自动演示.TabIndex = 10;
            this.自动演示.Text = "自动演示";
            this.自动演示.UseVisualStyleBackColor = true;
            this.自动演示.Click += new System.EventHandler(this.自动演示_Click);
            // 
            // comboSemaphore
            // 
            this.comboSemaphore.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboSemaphore.FormattingEnabled = true;
            this.comboSemaphore.Items.AddRange(new object[] {
            "记录型信号量",
            "AND型信号量"});
            this.comboSemaphore.Location = new System.Drawing.Point(479, 131);
            this.comboSemaphore.Name = "comboSemaphore";
            this.comboSemaphore.Size = new System.Drawing.Size(198, 41);
            this.comboSemaphore.TabIndex = 12;
            // 
            // lab_Semaphore
            // 
            this.lab_Semaphore.AutoSize = true;
            this.lab_Semaphore.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Semaphore.Location = new System.Drawing.Point(266, 134);
            this.lab_Semaphore.Name = "lab_Semaphore";
            this.lab_Semaphore.Size = new System.Drawing.Size(207, 33);
            this.lab_Semaphore.TabIndex = 13;
            this.lab_Semaphore.Text = "信号量类型：";
            // 
            // txt_Diary
            // 
            this.txt_Diary.Location = new System.Drawing.Point(1506, 213);
            this.txt_Diary.Multiline = true;
            this.txt_Diary.Name = "txt_Diary";
            this.txt_Diary.Size = new System.Drawing.Size(462, 509);
            this.txt_Diary.TabIndex = 14;
            // 
            // 缓冲区编号
            // 
            this.缓冲区编号.HeaderText = "缓冲区编号";
            this.缓冲区编号.MinimumWidth = 8;
            this.缓冲区编号.Name = "缓冲区编号";
            this.缓冲区编号.Width = 135;
            // 
            // 数据名
            // 
            this.数据名.HeaderText = "数据名";
            this.数据名.MinimumWidth = 8;
            this.数据名.Name = "数据名";
            this.数据名.Width = 150;
            // 
            // processSynchronization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1971, 912);
            this.Controls.Add(this.txt_Diary);
            this.Controls.Add(this.lab_Semaphore);
            this.Controls.Add(this.comboSemaphore);
            this.Controls.Add(this.清空缓冲区);
            this.Controls.Add(this.自动演示);
            this.Controls.Add(this.增加消费者);
            this.Controls.Add(this.增加生产者);
            this.Controls.Add(this.ConsumerView);
            this.Controls.Add(this.ProcucerView);
            this.Controls.Add(this.BufferView);
            this.Name = "processSynchronization";
            this.Controls.SetChildIndex(this.BufferView, 0);
            this.Controls.SetChildIndex(this.ProcucerView, 0);
            this.Controls.SetChildIndex(this.ConsumerView, 0);
            this.Controls.SetChildIndex(this.增加生产者, 0);
            this.Controls.SetChildIndex(this.增加消费者, 0);
            this.Controls.SetChildIndex(this.自动演示, 0);
            this.Controls.SetChildIndex(this.清空缓冲区, 0);
            this.Controls.SetChildIndex(this.comboSemaphore, 0);
            this.Controls.SetChildIndex(this.lab_Semaphore, 0);
            this.Controls.SetChildIndex(this.txt_Diary, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BufferView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcucerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView BufferView;
        private System.Windows.Forms.DataGridView ProcucerView;
        private System.Windows.Forms.DataGridView ConsumerView;
        private System.Windows.Forms.Button 增加生产者;
        private System.Windows.Forms.Button 增加消费者;
        private System.Windows.Forms.Button 清空缓冲区;
        private System.Windows.Forms.Button 自动演示;
        private System.Windows.Forms.ComboBox comboSemaphore;
        private System.Windows.Forms.Label lab_Semaphore;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生产者编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目前操作_生产;
        private System.Windows.Forms.DataGridViewTextBoxColumn 消费者编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目前操作_消费;
        public System.Windows.Forms.TextBox txt_Diary;
        private System.Windows.Forms.DataGridViewTextBoxColumn 缓冲区编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据名;
    }
}
