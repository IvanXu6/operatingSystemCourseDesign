using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public partial class processControl : 操作系统模拟系统.Main
    {
        public ProcessController processController;

        public processControl()
        {
            InitializeComponent();
            processController = new ProcessController(txt_Diary);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(combo_chooseProcess.Text);
            processController.TerminateProcess(ID);
            UpdateProcessView(ID);
        }

        private void btn_createProcess_Click(object sender, EventArgs e)
        {
            try
            {
                int processID = Convert.ToInt32(txt_processID.Text);
                string processName = txt_processName.Text;
                int processPeriod = Convert.ToInt32(txt_processPeriod.Text);
                int processExecutionTime = Convert.ToInt32(txt_processExecutionTime.Text);
                processController.CreateProcess(processID, processName, processPeriod, processExecutionTime);
                AddProcessView(processID, processName, processPeriod, processExecutionTime);
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

        private void btn_Running_Click(object sender, EventArgs e)
        {
            int ID =Convert.ToInt32(combo_chooseProcess.Text);
            processController.RunningProcess(ID);
            UpdateProcessView(ID);
        }

        private void btn_Blocked_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(combo_chooseProcess.Text);
            processController.SuspendProcess(ID);
            UpdateProcessView(ID);
        }

        private void btn_Ready_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(combo_chooseProcess.Text);
            processController.ActivateProcess(ID);
            UpdateProcessView(ID);
        }

        private void AddProcessView(int  processID, string processName, int processPeriod, int processExecutionTime)
        {

            // 添加一行到DataGridView
            processView.Rows.Add(processID, processName, processPeriod, processExecutionTime, processController.processStates[processID]);
        }

        private void UpdateProcessView(int processID)
        {
            processView.Rows[processID-1].Cells["进程状态"].Value = processController.processStates[processID];
        }

        private void processView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
