using System;
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public partial class processScheduing : 操作系统模拟系统.Main
    {
        public ProcessController processController;
        private Scheduler scheduler;
        public processScheduing()
        {
            InitializeComponent();
            processController = new ProcessController(txt_Diary);
        }
        
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }
<<<<<<< Updated upstream:操作系统模拟系统/fuben/processScheduing.cs
=======

        private void Btn_Schedule_Click(object sender, EventArgs e)
        {
            string selectedAlgorithm = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedAlgorithm))
            {
                MessageBox.Show("请选择调度算法！", "选择错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 根据选择的调度算法设置调度器
            if (selectedAlgorithm == "EDF调度算法")
            {
                scheduler = new EDF(processController);
            }
            else if (selectedAlgorithm == "LLF调度算法")
            {
                scheduler = new LLF(processController);
            }

            processController.SetScheduler(scheduler);

            // 启动调度
           scheduler.StartScheduling();

            // 输出调度日志
            //txt_Diary.Clear();
            txt_Diary.AppendText("调度过程：\n");
            foreach (var process in processController.processes.Values)
            {
                txt_Diary.AppendText($"进程 {process.ProcessName} 执行，剩余时间 {process.RemainingTime}。\n"+ Environment.NewLine);
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            // 清空进程控制器
            processController.ClearSchedulingQueue();

            // 清空调度日志
            txt_Diary.Clear();

            // 清空输入框
            txt_processID.Clear();
            txt_processName.Clear();
            txt_processPeriod.Clear();
            txt_processExecutionTime.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_createProcess_Click(object sender, EventArgs e)
        {
            try
            {
                int processId = int.Parse(txt_processID.Text);
                string processName = txt_processName.Text;
                int period = int.Parse(txt_processPeriod.Text);
                int executionTime = int.Parse(txt_processExecutionTime.Text);

                // 创建进程并添加到进程控制器
                Process newProcess = processController.CreateProcess(processId, processName, period, executionTime);

                // 在DataGridView中显示进程
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["序号"].Value = newProcess.ProcessId;
                dataGridView1.Rows[rowIndex].Cells["进程名"].Value = newProcess.ProcessName;
                dataGridView1.Rows[rowIndex].Cells["周期"].Value = newProcess.Period;
                dataGridView1.Rows[rowIndex].Cells["执行时间"].Value = newProcess.ExecutionTime;
                dataGridView1.Rows[rowIndex].Cells["截止时间"].Value = newProcess.Deadline;
                dataGridView1.Rows[rowIndex].Cells["进程状态"].Value = processController.processStates[newProcess.ProcessId];
                // 清空输入框
                txt_processID.Clear();
                txt_processName.Clear();
                txt_processPeriod.Clear();
                txt_processExecutionTime.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
>>>>>>> Stashed changes:操作系统模拟系统/processScheduing.cs
    }
}
