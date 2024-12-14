namespace 操作系统模拟系统
{
    partial class processDeadlockHandling
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
            this.lab_processID = new System.Windows.Forms.Label();
            this.lab_Max = new System.Windows.Forms.Label();
            this.lab_Allocation = new System.Windows.Forms.Label();
            this.lab_Need = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.P1_Max = new System.Windows.Forms.MaskedTextBox();
            this.P2_Max = new System.Windows.Forms.MaskedTextBox();
            this.P3_Max = new System.Windows.Forms.MaskedTextBox();
            this.P4_Max = new System.Windows.Forms.MaskedTextBox();
            this.P4_Allocation = new System.Windows.Forms.MaskedTextBox();
            this.P3_Allocation = new System.Windows.Forms.MaskedTextBox();
            this.P2_Allocation = new System.Windows.Forms.MaskedTextBox();
            this.P1_Allocation = new System.Windows.Forms.MaskedTextBox();
            this.P4_Need = new System.Windows.Forms.MaskedTextBox();
            this.P3_Need = new System.Windows.Forms.MaskedTextBox();
            this.P2_Need = new System.Windows.Forms.MaskedTextBox();
            this.P1_Need = new System.Windows.Forms.MaskedTextBox();
            this.lab_P1 = new System.Windows.Forms.Label();
            this.lab_P2 = new System.Windows.Forms.Label();
            this.lab_P3 = new System.Windows.Forms.Label();
            this.lab_P4 = new System.Windows.Forms.Label();
            this.btn_Work = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_Diary = new System.Windows.Forms.TextBox();
            this.请求资源 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_processID
            // 
            this.lab_processID.AutoSize = true;
            this.lab_processID.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_processID.Location = new System.Drawing.Point(3, 15);
            this.lab_processID.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_processID.Name = "lab_processID";
            this.lab_processID.Size = new System.Drawing.Size(124, 28);
            this.lab_processID.TabIndex = 5;
            this.lab_processID.Text = "进程编号";
            // 
            // lab_Max
            // 
            this.lab_Max.AutoSize = true;
            this.lab_Max.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Max.Location = new System.Drawing.Point(300, 15);
            this.lab_Max.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_Max.Name = "lab_Max";
            this.lab_Max.Size = new System.Drawing.Size(124, 28);
            this.lab_Max.TabIndex = 6;
            this.lab_Max.Text = "最大需求";
            // 
            // lab_Allocation
            // 
            this.lab_Allocation.AutoSize = true;
            this.lab_Allocation.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Allocation.Location = new System.Drawing.Point(655, 15);
            this.lab_Allocation.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_Allocation.Name = "lab_Allocation";
            this.lab_Allocation.Size = new System.Drawing.Size(124, 28);
            this.lab_Allocation.TabIndex = 7;
            this.lab_Allocation.Text = "现已分配";
            // 
            // lab_Need
            // 
            this.lab_Need.AutoSize = true;
            this.lab_Need.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Need.Location = new System.Drawing.Point(1003, 15);
            this.lab_Need.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_Need.Name = "lab_Need";
            this.lab_Need.Size = new System.Drawing.Size(124, 28);
            this.lab_Need.TabIndex = 8;
            this.lab_Need.Text = "剩余需求";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lab_processID);
            this.flowLayoutPanel4.Controls.Add(this.panel14);
            this.flowLayoutPanel4.Controls.Add(this.lab_Max);
            this.flowLayoutPanel4.Controls.Add(this.panel15);
            this.flowLayoutPanel4.Controls.Add(this.lab_Allocation);
            this.flowLayoutPanel4.Controls.Add(this.panel16);
            this.flowLayoutPanel4.Controls.Add(this.lab_Need);
            this.flowLayoutPanel4.Controls.Add(this.panel17);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(326, 102);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1478, 69);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(133, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(161, 66);
            this.panel14.TabIndex = 6;
            // 
            // panel15
            // 
            this.panel15.Location = new System.Drawing.Point(430, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(219, 66);
            this.panel15.TabIndex = 7;
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(785, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(212, 66);
            this.panel16.TabIndex = 8;
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(1133, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(212, 66);
            this.panel17.TabIndex = 9;
            // 
            // P1_Max
            // 
            this.P1_Max.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P1_Max.Location = new System.Drawing.Point(756, 223);
            this.P1_Max.Mask = "{ 0 ，0 ，0 }";
            this.P1_Max.Name = "P1_Max";
            this.P1_Max.Size = new System.Drawing.Size(219, 44);
            this.P1_Max.TabIndex = 14;
            // 
            // P2_Max
            // 
            this.P2_Max.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P2_Max.Location = new System.Drawing.Point(756, 337);
            this.P2_Max.Mask = "{ 0 ，0 ，0 }";
            this.P2_Max.Name = "P2_Max";
            this.P2_Max.Size = new System.Drawing.Size(219, 44);
            this.P2_Max.TabIndex = 15;
            // 
            // P3_Max
            // 
            this.P3_Max.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P3_Max.Location = new System.Drawing.Point(756, 459);
            this.P3_Max.Mask = "{ 0 ，0 ，0 }";
            this.P3_Max.Name = "P3_Max";
            this.P3_Max.Size = new System.Drawing.Size(219, 44);
            this.P3_Max.TabIndex = 16;
            // 
            // P4_Max
            // 
            this.P4_Max.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P4_Max.Location = new System.Drawing.Point(756, 577);
            this.P4_Max.Mask = "{ 0 ，0 ，0 }";
            this.P4_Max.Name = "P4_Max";
            this.P4_Max.Size = new System.Drawing.Size(219, 44);
            this.P4_Max.TabIndex = 17;
            // 
            // P4_Allocation
            // 
            this.P4_Allocation.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P4_Allocation.Location = new System.Drawing.Point(1111, 577);
            this.P4_Allocation.Mask = "{ 0 ，0 ，0 }";
            this.P4_Allocation.Name = "P4_Allocation";
            this.P4_Allocation.Size = new System.Drawing.Size(219, 44);
            this.P4_Allocation.TabIndex = 21;
            // 
            // P3_Allocation
            // 
            this.P3_Allocation.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P3_Allocation.Location = new System.Drawing.Point(1111, 459);
            this.P3_Allocation.Mask = "{ 0 ，0 ，0 }";
            this.P3_Allocation.Name = "P3_Allocation";
            this.P3_Allocation.Size = new System.Drawing.Size(219, 44);
            this.P3_Allocation.TabIndex = 20;
            // 
            // P2_Allocation
            // 
            this.P2_Allocation.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P2_Allocation.Location = new System.Drawing.Point(1111, 337);
            this.P2_Allocation.Mask = "{ 0 ，0 ，0 }";
            this.P2_Allocation.Name = "P2_Allocation";
            this.P2_Allocation.Size = new System.Drawing.Size(219, 44);
            this.P2_Allocation.TabIndex = 19;
            // 
            // P1_Allocation
            // 
            this.P1_Allocation.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P1_Allocation.Location = new System.Drawing.Point(1111, 223);
            this.P1_Allocation.Mask = "{ 0 ，0 ，0 }";
            this.P1_Allocation.Name = "P1_Allocation";
            this.P1_Allocation.Size = new System.Drawing.Size(219, 44);
            this.P1_Allocation.TabIndex = 18;
            // 
            // P4_Need
            // 
            this.P4_Need.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P4_Need.Location = new System.Drawing.Point(1459, 577);
            this.P4_Need.Mask = "{ 0 ，0 ，0 }";
            this.P4_Need.Name = "P4_Need";
            this.P4_Need.Size = new System.Drawing.Size(219, 44);
            this.P4_Need.TabIndex = 25;
            // 
            // P3_Need
            // 
            this.P3_Need.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P3_Need.Location = new System.Drawing.Point(1459, 459);
            this.P3_Need.Mask = "{ 0 ，0 ，0 }";
            this.P3_Need.Name = "P3_Need";
            this.P3_Need.Size = new System.Drawing.Size(219, 44);
            this.P3_Need.TabIndex = 24;
            // 
            // P2_Need
            // 
            this.P2_Need.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P2_Need.Location = new System.Drawing.Point(1459, 337);
            this.P2_Need.Mask = "{ 0 ，0 ，0 }";
            this.P2_Need.Name = "P2_Need";
            this.P2_Need.Size = new System.Drawing.Size(219, 44);
            this.P2_Need.TabIndex = 23;
            // 
            // P1_Need
            // 
            this.P1_Need.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.P1_Need.Location = new System.Drawing.Point(1459, 223);
            this.P1_Need.Mask = "{ 0 ，0 ，0 }";
            this.P1_Need.Name = "P1_Need";
            this.P1_Need.Size = new System.Drawing.Size(219, 44);
            this.P1_Need.TabIndex = 22;
            // 
            // lab_P1
            // 
            this.lab_P1.AutoSize = true;
            this.lab_P1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_P1.Location = new System.Drawing.Point(513, 226);
            this.lab_P1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_P1.Name = "lab_P1";
            this.lab_P1.Size = new System.Drawing.Size(47, 33);
            this.lab_P1.TabIndex = 10;
            this.lab_P1.Text = "P1";
            // 
            // lab_P2
            // 
            this.lab_P2.AutoSize = true;
            this.lab_P2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_P2.Location = new System.Drawing.Point(513, 340);
            this.lab_P2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_P2.Name = "lab_P2";
            this.lab_P2.Size = new System.Drawing.Size(47, 33);
            this.lab_P2.TabIndex = 26;
            this.lab_P2.Text = "P2";
            // 
            // lab_P3
            // 
            this.lab_P3.AutoSize = true;
            this.lab_P3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_P3.Location = new System.Drawing.Point(513, 462);
            this.lab_P3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_P3.Name = "lab_P3";
            this.lab_P3.Size = new System.Drawing.Size(47, 33);
            this.lab_P3.TabIndex = 27;
            this.lab_P3.Text = "P3";
            // 
            // lab_P4
            // 
            this.lab_P4.AutoSize = true;
            this.lab_P4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_P4.Location = new System.Drawing.Point(513, 580);
            this.lab_P4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lab_P4.Name = "lab_P4";
            this.lab_P4.Size = new System.Drawing.Size(47, 33);
            this.lab_P4.TabIndex = 28;
            this.lab_P4.Text = "P4";
            // 
            // btn_Work
            // 
            this.btn_Work.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Work.Location = new System.Drawing.Point(1216, 680);
            this.btn_Work.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.btn_Work.Name = "btn_Work";
            this.btn_Work.Size = new System.Drawing.Size(238, 51);
            this.btn_Work.TabIndex = 11;
            this.btn_Work.Text = "初始化资源";
            this.btn_Work.UseVisualStyleBackColor = true;
            this.btn_Work.Click += new System.EventHandler(this.btn_Work_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(1557, 726);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(124, 51);
            this.btn_Reset.TabIndex = 30;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Diary
            // 
            this.txt_Diary.Location = new System.Drawing.Point(519, 680);
            this.txt_Diary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Diary.Multiline = true;
            this.txt_Diary.Name = "txt_Diary";
            this.txt_Diary.Size = new System.Drawing.Size(616, 164);
            this.txt_Diary.TabIndex = 31;
            // 
            // 请求资源
            // 
            this.请求资源.Location = new System.Drawing.Point(1216, 760);
            this.请求资源.Name = "请求资源";
            this.请求资源.Size = new System.Drawing.Size(236, 53);
            this.请求资源.TabIndex = 32;
            this.请求资源.Text = "请求资源";
            this.请求资源.UseVisualStyleBackColor = true;
            this.请求资源.Click += new System.EventHandler(this.请求资源_Click);
            // 
            // processDeadlockHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1844, 912);
            this.Controls.Add(this.请求资源);
            this.Controls.Add(this.txt_Diary);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lab_P4);
            this.Controls.Add(this.lab_P3);
            this.Controls.Add(this.lab_P2);
            this.Controls.Add(this.P4_Need);
            this.Controls.Add(this.P3_Need);
            this.Controls.Add(this.P2_Need);
            this.Controls.Add(this.P1_Need);
            this.Controls.Add(this.btn_Work);
            this.Controls.Add(this.P4_Allocation);
            this.Controls.Add(this.P3_Allocation);
            this.Controls.Add(this.lab_P1);
            this.Controls.Add(this.P2_Allocation);
            this.Controls.Add(this.P1_Allocation);
            this.Controls.Add(this.P4_Max);
            this.Controls.Add(this.P3_Max);
            this.Controls.Add(this.P2_Max);
            this.Controls.Add(this.P1_Max);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "processDeadlockHandling";
            this.Controls.SetChildIndex(this.flowLayoutPanel4, 0);
            this.Controls.SetChildIndex(this.P1_Max, 0);
            this.Controls.SetChildIndex(this.P2_Max, 0);
            this.Controls.SetChildIndex(this.P3_Max, 0);
            this.Controls.SetChildIndex(this.P4_Max, 0);
            this.Controls.SetChildIndex(this.P1_Allocation, 0);
            this.Controls.SetChildIndex(this.P2_Allocation, 0);
            this.Controls.SetChildIndex(this.lab_P1, 0);
            this.Controls.SetChildIndex(this.P3_Allocation, 0);
            this.Controls.SetChildIndex(this.P4_Allocation, 0);
            this.Controls.SetChildIndex(this.btn_Work, 0);
            this.Controls.SetChildIndex(this.P1_Need, 0);
            this.Controls.SetChildIndex(this.P2_Need, 0);
            this.Controls.SetChildIndex(this.P3_Need, 0);
            this.Controls.SetChildIndex(this.P4_Need, 0);
            this.Controls.SetChildIndex(this.lab_P2, 0);
            this.Controls.SetChildIndex(this.lab_P3, 0);
            this.Controls.SetChildIndex(this.lab_P4, 0);
            this.Controls.SetChildIndex(this.btn_Reset, 0);
            this.Controls.SetChildIndex(this.txt_Diary, 0);
            this.Controls.SetChildIndex(this.请求资源, 0);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_processID;
        private System.Windows.Forms.Label lab_Max;
        private System.Windows.Forms.Label lab_Allocation;
        private System.Windows.Forms.Label lab_Need;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.MaskedTextBox P1_Max;
        private System.Windows.Forms.MaskedTextBox P2_Max;
        private System.Windows.Forms.MaskedTextBox P3_Max;
        private System.Windows.Forms.MaskedTextBox P4_Max;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.MaskedTextBox P4_Allocation;
        private System.Windows.Forms.MaskedTextBox P3_Allocation;
        private System.Windows.Forms.MaskedTextBox P2_Allocation;
        private System.Windows.Forms.MaskedTextBox P1_Allocation;
        private System.Windows.Forms.MaskedTextBox P4_Need;
        private System.Windows.Forms.MaskedTextBox P3_Need;
        private System.Windows.Forms.MaskedTextBox P2_Need;
        private System.Windows.Forms.MaskedTextBox P1_Need;
        private System.Windows.Forms.Label lab_P1;
        private System.Windows.Forms.Label lab_P2;
        private System.Windows.Forms.Label lab_P3;
        private System.Windows.Forms.Label lab_P4;
        private System.Windows.Forms.Button btn_Work;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_Diary;
        private System.Windows.Forms.Button 请求资源;
    }
}
