namespace 操作系统模拟系统
{
    partial class processControl
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
            this.processView = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.周期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.执行时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进程状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_chooseProcess = new System.Windows.Forms.ComboBox();
            this.processControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_Running = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_Blocked = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btn_Ready = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btn_Terminated = new System.Windows.Forms.Button();
            this.processControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processControllerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Diary = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processControlBindingSource)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processControllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processControllerBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.flowLayoutPanel3.Location = new System.Drawing.Point(322, 131);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1478, 61);
            this.flowLayoutPanel3.TabIndex = 4;
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
            // processView
            // 
            this.processView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.进程名,
            this.周期,
            this.执行时间,
            this.进程状态});
            this.processView.Location = new System.Drawing.Point(322, 318);
            this.processView.Name = "processView";
            this.processView.RowHeadersWidth = 62;
            this.processView.RowTemplate.Height = 30;
            this.processView.Size = new System.Drawing.Size(972, 486);
            this.processView.TabIndex = 5;
            this.processView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processView_CellContentClick);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 8;
            this.序号.Name = "序号";
            this.序号.Width = 120;
            // 
            // 进程名
            // 
            this.进程名.HeaderText = "进程名";
            this.进程名.MinimumWidth = 8;
            this.进程名.Name = "进程名";
            this.进程名.Width = 120;
            // 
            // 周期
            // 
            this.周期.HeaderText = "周期";
            this.周期.MinimumWidth = 8;
            this.周期.Name = "周期";
            this.周期.Width = 120;
            // 
            // 执行时间
            // 
            this.执行时间.HeaderText = "执行时间";
            this.执行时间.MinimumWidth = 8;
            this.执行时间.Name = "执行时间";
            this.执行时间.Width = 140;
            // 
            // 进程状态
            // 
            this.进程状态.HeaderText = "进程状态";
            this.进程状态.MinimumWidth = 8;
            this.进程状态.Name = "进程状态";
            this.进程状态.Width = 140;
            // 
            // combo_chooseProcess
            // 
            this.combo_chooseProcess.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo_chooseProcess.FormattingEnabled = true;
            this.combo_chooseProcess.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combo_chooseProcess.Location = new System.Drawing.Point(3, 15);
            this.combo_chooseProcess.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.combo_chooseProcess.Name = "combo_chooseProcess";
            this.combo_chooseProcess.Size = new System.Drawing.Size(197, 41);
            this.combo_chooseProcess.TabIndex = 7;
            this.combo_chooseProcess.Text = "1";
            // 
            // processControlBindingSource
            // 
            this.processControlBindingSource.DataSource = typeof(操作系统模拟系统.processControl);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.combo_chooseProcess);
            this.flowLayoutPanel4.Controls.Add(this.panel14);
            this.flowLayoutPanel4.Controls.Add(this.btn_Running);
            this.flowLayoutPanel4.Controls.Add(this.panel15);
            this.flowLayoutPanel4.Controls.Add(this.btn_Blocked);
            this.flowLayoutPanel4.Controls.Add(this.panel16);
            this.flowLayoutPanel4.Controls.Add(this.btn_Ready);
            this.flowLayoutPanel4.Controls.Add(this.panel17);
            this.flowLayoutPanel4.Controls.Add(this.btn_Terminated);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(322, 224);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1478, 68);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(206, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(129, 65);
            this.panel14.TabIndex = 8;
            // 
            // btn_Running
            // 
            this.btn_Running.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Running.Location = new System.Drawing.Point(341, 12);
            this.btn_Running.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btn_Running.Name = "btn_Running";
            this.btn_Running.Size = new System.Drawing.Size(124, 51);
            this.btn_Running.TabIndex = 11;
            this.btn_Running.Text = "运行";
            this.btn_Running.UseVisualStyleBackColor = true;
            this.btn_Running.Click += new System.EventHandler(this.btn_Running_Click);
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(471, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(97, 65);
            this.panel15.TabIndex = 9;
            // 
            // btn_Blocked
            // 
            this.btn_Blocked.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Blocked.Location = new System.Drawing.Point(574, 12);
            this.btn_Blocked.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btn_Blocked.Name = "btn_Blocked";
            this.btn_Blocked.Size = new System.Drawing.Size(124, 51);
            this.btn_Blocked.TabIndex = 12;
            this.btn_Blocked.Text = "挂起";
            this.btn_Blocked.UseVisualStyleBackColor = true;
            this.btn_Blocked.Click += new System.EventHandler(this.btn_Blocked_Click);
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(704, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(97, 65);
            this.panel16.TabIndex = 13;
            // 
            // btn_Ready
            // 
            this.btn_Ready.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ready.Location = new System.Drawing.Point(807, 12);
            this.btn_Ready.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(124, 51);
            this.btn_Ready.TabIndex = 14;
            this.btn_Ready.Text = "激活";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(937, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(97, 65);
            this.panel17.TabIndex = 15;
            // 
            // btn_Terminated
            // 
            this.btn_Terminated.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Terminated.Location = new System.Drawing.Point(1040, 12);
            this.btn_Terminated.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btn_Terminated.Name = "btn_Terminated";
            this.btn_Terminated.Size = new System.Drawing.Size(124, 51);
            this.btn_Terminated.TabIndex = 16;
            this.btn_Terminated.Text = "中止";
            this.btn_Terminated.UseVisualStyleBackColor = true;
            this.btn_Terminated.Click += new System.EventHandler(this.button12_Click);
            // 
            // processControllerBindingSource
            // 
            this.processControllerBindingSource.DataSource = typeof(操作系统模拟系统.ProcessController);
            // 
            // processControllerBindingSource1
            // 
            this.processControllerBindingSource1.DataSource = typeof(操作系统模拟系统.ProcessController);
            // 
            // txt_Diary
            // 
            this.txt_Diary.Location = new System.Drawing.Point(1499, 318);
            this.txt_Diary.Multiline = true;
            this.txt_Diary.Name = "txt_Diary";
            this.txt_Diary.Size = new System.Drawing.Size(301, 415);
            this.txt_Diary.TabIndex = 9;
            // 
            // processControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1844, 912);
            this.Controls.Add(this.txt_Diary);
            this.Controls.Add(this.processView);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "processControl";
            this.Controls.SetChildIndex(this.flowLayoutPanel4, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel3, 0);
            this.Controls.SetChildIndex(this.processView, 0);
            this.Controls.SetChildIndex(this.txt_Diary, 0);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processControlBindingSource)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processControllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processControllerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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

        private System.Windows.Forms.DataGridView processView;

        private System.Windows.Forms.ComboBox combo_chooseProcess;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_Running;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btn_Blocked;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btn_Terminated;
        private System.Windows.Forms.BindingSource processControlBindingSource;
        private System.Windows.Forms.BindingSource processControllerBindingSource;
        private System.Windows.Forms.BindingSource processControllerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 周期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 执行时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进程状态;
        private System.Windows.Forms.TextBox txt_Diary;
    }
}
