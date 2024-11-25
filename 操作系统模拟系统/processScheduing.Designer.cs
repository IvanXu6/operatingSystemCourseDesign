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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.周期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服务时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label13);
            this.flowLayoutPanel3.Controls.Add(this.textBox3);
            this.flowLayoutPanel3.Controls.Add(this.label14);
            this.flowLayoutPanel3.Controls.Add(this.textBox4);
            this.flowLayoutPanel3.Controls.Add(this.label15);
            this.flowLayoutPanel3.Controls.Add(this.textBox5);
            this.flowLayoutPanel3.Controls.Add(this.label16);
            this.flowLayoutPanel3.Controls.Add(this.textBox6);
            this.flowLayoutPanel3.Controls.Add(this.button8);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(308, 131);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1478, 69);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "序号：";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(105, 10);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(211, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 28);
            this.label14.TabIndex = 2;
            this.label14.Text = "作业名：";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(341, 10);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(447, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 28);
            this.label15.TabIndex = 4;
            this.label15.Text = "周期：";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(549, 10);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 31);
            this.textBox5.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(655, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 28);
            this.label16.TabIndex = 6;
            this.label16.Text = "服务时间：";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(813, 10);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 31);
            this.textBox6.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(946, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 51);
            this.button8.TabIndex = 10;
            this.button8.Text = "创建";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(392, 291);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 28);
            this.label18.TabIndex = 4;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(720, 291);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 28);
            this.label19.TabIndex = 5;
            this.label19.Text = "label19";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EDF调度算法",
            "LLF调度算法"});
            this.comboBox1.Location = new System.Drawing.Point(968, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 41);
            this.comboBox1.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(1227, 280);
            this.button9.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 51);
            this.button9.TabIndex = 11;
            this.button9.Text = "执行";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(1401, 280);
            this.button10.Margin = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 51);
            this.button10.TabIndex = 12;
            this.button10.Text = "撤销";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.作业名,
            this.周期,
            this.服务时间});
            this.dataGridView1.Location = new System.Drawing.Point(422, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 400);
            this.dataGridView1.TabIndex = 13;
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 8;
            this.序号.Name = "序号";
            this.序号.Width = 150;
            // 
            // 作业名
            // 
            this.作业名.HeaderText = "作业名";
            this.作业名.MinimumWidth = 8;
            this.作业名.Name = "作业名";
            this.作业名.Width = 150;
            // 
            // 周期
            // 
            this.周期.HeaderText = "周期";
            this.周期.MinimumWidth = 8;
            this.周期.Name = "周期";
            this.周期.Width = 150;
            // 
            // 服务时间
            // 
            this.服务时间.HeaderText = "服务时间";
            this.服务时间.MinimumWidth = 8;
            this.服务时间.Name = "服务时间";
            this.服务时间.Width = 150;
            // 
            // processScheduing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1844, 912);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "processScheduing";
            this.Controls.SetChildIndex(this.flowLayoutPanel3, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.button9, 0);
            this.Controls.SetChildIndex(this.button10, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 周期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服务时间;
    }
}
