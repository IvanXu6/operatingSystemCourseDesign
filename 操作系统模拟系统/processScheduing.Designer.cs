namespace 操作系统模拟系统
{
    partial class processScheduing
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
            this.components = new System.ComponentModel.Container();
            this.调度算法 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_Schedule = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Diary = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lab_processID = new System.Windows.Forms.Label();
            this.txt_processID = new System.Windows.Forms.TextBox();
            this.lab_processName = new System.Windows.Forms.Label();
            this.txt_processName = new System.Windows.Forms.TextBox();
            this.lab_processPeriod = new System.Windows.Forms.Label();
            this.txt_processPeriod = new System.Windows.Forms.TextBox();
            this.lab_processExecutionTime = new System.Windows.Forms.Label();
            this.txt_processExecutionTime = new System.Windows.Forms.TextBox();
            this.btn_createProcess = new System.Windows.Forms.Button();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.周期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.执行时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.截止时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进程状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 调度算法
            // 
            this.调度算法.AutoSize = true;
            this.调度算法.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.调度算法.Location = new System.Drawing.Point(285, 316);
            this.调度算法.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.调度算法.Name = "调度算法";
            this.调度算法.Size = new System.Drawing.Size(124, 28);
            this.调度算法.TabIndex = 5;
            this.调度算法.Text = "调度算法";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EDF调度算法",
            "LLF调度算法"});
            this.comboBox1.Location = new System.Drawing.Point(480, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 41);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "EDF调度算法";
            // 
            // Btn_Schedule
            // 
            this.Btn_Schedule.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Schedule.Location = new System.Drawing.Point(798, 305);
            this.Btn_Schedule.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.Btn_Schedule.Name = "Btn_Schedule";
            this.Btn_Schedule.Size = new System.Drawing.Size(124, 51);
            this.Btn_Schedule.TabIndex = 11;
            this.Btn_Schedule.Text = "执行";
            this.Btn_Schedule.UseVisualStyleBackColor = true;
            this.Btn_Schedule.Click += new System.EventHandler(this.Btn_Schedule_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Reset.Location = new System.Drawing.Point(989, 305);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(124, 51);
            this.Btn_Reset.TabIndex = 12;
            this.Btn_Reset.Text = "重置";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.进程名,
            this.周期,
            this.执行时间,
            this.截止时间,
            this.进程状态});
            this.dataGridView1.Location = new System.Drawing.Point(289, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(808, 400);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Diary
            // 
            this.txt_Diary.Location = new System.Drawing.Point(1183, 414);
            this.txt_Diary.Multiline = true;
            this.txt_Diary.Name = "txt_Diary";
            this.txt_Diary.Size = new System.Drawing.Size(554, 408);
            this.txt_Diary.TabIndex = 14;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lab_processID);
            this.flowLayoutPanel3.Controls.Add(this.txt_processID);
            this.flowLayoutPanel3.Controls.Add(this.lab_processName);
            this.flowLayoutPanel3.Controls.Add(this.txt_processName);
            this.flowLayoutPanel3.Controls.Add(this.lab_processPeriod);
            this.flowLayoutPanel3.Controls.Add(this.txt_processPeriod);
            this.flowLayoutPanel3.Controls.Add(this.lab_processExecutionTime);
            this.flowLayoutPanel3.Controls.Add(this.txt_processExecutionTime);
            this.flowLayoutPanel3.Controls.Add(this.btn_createProcess);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(290, 166);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1478, 61);
            this.flowLayoutPanel3.TabIndex = 15;
            // 
            // lab_processID
            // 
            this.lab_processID.AutoSize = true;
            this.lab_processID.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_processID.Location = new System.Drawing.Point(3, 12);
            this.lab_processID.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lab_processID.Name = "lab_processID";
            this.lab_processID.Size = new System.Drawing.Size(96, 28);
            this.lab_processID.TabIndex = 0;
            this.lab_processID.Text = "序号：";
            // 
            // txt_processID
            // 
            this.txt_processID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_processID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_processID.Location = new System.Drawing.Point(105, 10);
            this.txt_processID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_processID.Name = "txt_processID";
            this.txt_processID.Size = new System.Drawing.Size(100, 31);
            this.txt_processID.TabIndex = 1;
            // 
            // lab_processName
            // 
            this.lab_processName.AutoSize = true;
            this.lab_processName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_processName.Location = new System.Drawing.Point(211, 12);
            this.lab_processName.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lab_processName.Name = "lab_processName";
            this.lab_processName.Size = new System.Drawing.Size(124, 28);
            this.lab_processName.TabIndex = 2;
            this.lab_processName.Text = "进程名：";
            // 
            // txt_processName
            // 
            this.txt_processName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_processName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_processName.Location = new System.Drawing.Point(341, 10);
            this.txt_processName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_processName.Name = "txt_processName";
            this.txt_processName.Size = new System.Drawing.Size(100, 31);
            this.txt_processName.TabIndex = 3;
            // 
            // lab_processPeriod
            // 
            this.lab_processPeriod.AutoSize = true;
            this.lab_processPeriod.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_processPeriod.Location = new System.Drawing.Point(447, 12);
            this.lab_processPeriod.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lab_processPeriod.Name = "lab_processPeriod";
            this.lab_processPeriod.Size = new System.Drawing.Size(96, 28);
            this.lab_processPeriod.TabIndex = 4;
            this.lab_processPeriod.Text = "周期：";
            // 
            // txt_processPeriod
            // 
            this.txt_processPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_processPeriod.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_processPeriod.Location = new System.Drawing.Point(549, 10);
            this.txt_processPeriod.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_processPeriod.Name = "txt_processPeriod";
            this.txt_processPeriod.Size = new System.Drawing.Size(100, 31);
            this.txt_processPeriod.TabIndex = 5;
            // 
            // lab_processExecutionTime
            // 
            this.lab_processExecutionTime.AutoSize = true;
            this.lab_processExecutionTime.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_processExecutionTime.Location = new System.Drawing.Point(655, 12);
            this.lab_processExecutionTime.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lab_processExecutionTime.Name = "lab_processExecutionTime";
            this.lab_processExecutionTime.Size = new System.Drawing.Size(152, 28);
            this.lab_processExecutionTime.TabIndex = 6;
            this.lab_processExecutionTime.Text = "执行时间：";
            // 
            // txt_processExecutionTime
            // 
            this.txt_processExecutionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_processExecutionTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_processExecutionTime.Location = new System.Drawing.Point(813, 10);
            this.txt_processExecutionTime.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_processExecutionTime.Name = "txt_processExecutionTime";
            this.txt_processExecutionTime.Size = new System.Drawing.Size(100, 31);
            this.txt_processExecutionTime.TabIndex = 7;
            // 
            // btn_createProcess
            // 
            this.btn_createProcess.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_createProcess.Location = new System.Drawing.Point(946, 0);
            this.btn_createProcess.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.btn_createProcess.Name = "btn_createProcess";
            this.btn_createProcess.Size = new System.Drawing.Size(124, 51);
            this.btn_createProcess.TabIndex = 10;
            this.btn_createProcess.Text = "创建";
            this.btn_createProcess.UseVisualStyleBackColor = true;
            this.btn_createProcess.Click += new System.EventHandler(this.btn_createProcess_Click);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 8;
            this.序号.Name = "序号";
            this.序号.Width = 150;
            // 
            // 进程名
            // 
            this.进程名.HeaderText = "进程名";
            this.进程名.MinimumWidth = 8;
            this.进程名.Name = "进程名";
            this.进程名.Width = 150;
            // 
            // 周期
            // 
            this.周期.HeaderText = "周期";
            this.周期.MinimumWidth = 8;
            this.周期.Name = "周期";
            this.周期.Width = 150;
            // 
            // 执行时间
            // 
            this.执行时间.HeaderText = "执行时间";
            this.执行时间.MinimumWidth = 8;
            this.执行时间.Name = "执行时间";
            this.执行时间.Width = 150;
            // 
            // 截止时间
            // 
            this.截止时间.HeaderText = "截止时间";
            this.截止时间.MinimumWidth = 8;
            this.截止时间.Name = "截止时间";
            this.截止时间.Width = 150;
            // 
            // 进程状态
            // 
            this.进程状态.HeaderText = "进程状态";
            this.进程状态.MinimumWidth = 8;
            this.进程状态.Name = "进程状态";
            this.进程状态.Width = 150;
            // 
            // processScheduing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1844, 912);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.txt_Diary);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_Schedule);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.调度算法);
            this.Name = "processScheduing";
            this.Controls.SetChildIndex(this.调度算法, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.Btn_Schedule, 0);
            this.Controls.SetChildIndex(this.Btn_Reset, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_Diary, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 调度算法;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_Schedule;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Diary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lab_processID;
        private System.Windows.Forms.TextBox txt_processID;
        private System.Windows.Forms.Label lab_processName;
        private System.Windows.Forms.TextBox txt_processName;
        private System.Windows.Forms.Label lab_processPeriod;
        private System.Windows.Forms.TextBox txt_processPeriod;
        private System.Windows.Forms.Label lab_processExecutionTime;
        private System.Windows.Forms.TextBox txt_processExecutionTime;
        private System.Windows.Forms.Button btn_createProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 周期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 执行时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 截止时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进程状态;
        private System.Windows.Forms.Timer timer1;
    }
}
