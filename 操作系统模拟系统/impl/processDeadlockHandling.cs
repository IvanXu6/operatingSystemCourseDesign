using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public partial class processDeadlockHandling : 操作系统模拟系统.Main
    {
        private BankersAlgorithm bankersAlgorithm;

        public Random random;
        public processDeadlockHandling()
        {
            InitializeComponent();
            bankersAlgorithm = new BankersAlgorithm();
        }

        private void btn_Work_Click(object sender, EventArgs e)
        {
            bankersAlgorithm.GenerateProcesses();
            txt_Diary.AppendText($"初始化资源并生成进程: 初始可用资源{string.Join(", ", bankersAlgorithm.AvailableResources)}"+ Environment.NewLine);
            //txt_Diary.AppendText($"P1最大需求：{string.Join(", ", bankersAlgorithm.Max[0,0], bankersAlgorithm.Max[0, 1] , bankersAlgorithm.Max[0, 2])}" + Environment.NewLine);
            //txt_Diary.AppendText($"P2最大需求：{string.Join(", ", bankersAlgorithm.Max[1, 0], bankersAlgorithm.Max[1, 1], bankersAlgorithm.Max[1, 2])}" + Environment.NewLine);
            //txt_Diary.AppendText($"P3最大需求：{string.Join(", ", bankersAlgorithm.Max[2, 0], bankersAlgorithm.Max[2, 1], bankersAlgorithm.Max[2, 2])}" + Environment.NewLine);
            //txt_Diary.AppendText($"P4最大需求：{string.Join(", ", bankersAlgorithm.Max[3, 0], bankersAlgorithm.Max[3, 1], bankersAlgorithm.Max[3, 2])}" + Environment.NewLine);
            //txt_Diary.AppendText($"P1已分配：{string.Join(", ", bankersAlgorithm.Allocation[0, 0], bankersAlgorithm.Allocation[0, 1], bankersAlgorithm.Allocation[0, 2])}" + Environment.NewLine);
            //txt_Diary.AppendText($"P1还需要：{string.Join(", ", bankersAlgorithm.Need[0, 0], bankersAlgorithm.Need[0, 1], bankersAlgorithm.Need[0, 2])}" + Environment.NewLine);
            // 格式化资源信息
            bankersAlgorithm.FormatResourceArray();
            // 更新MaskedTextBox显示进程的资源信息
            UpdateProcessUI();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            bankersAlgorithm.Reset();
            txt_Diary.AppendText("系统已重置" + Environment.NewLine);

            // 清空MaskedTextBox
            ClearProcessUI();
        }

        

        private void 请求资源_Click(object sender, EventArgs e)
        {
            // 随机选择一个进程进行资源请求
            int randomProcessId = new Random().Next(1, 5); // 随机选择P1到P4
            string log;
            bool success = bankersAlgorithm.RequestResources(randomProcessId, out log);

            // 将日志显示到txtDiary
            txt_Diary.AppendText($"进程P{randomProcessId}请求资源: {log}"+ Environment.NewLine);
            // 格式化资源信息
            bankersAlgorithm.FormatResourceArray();
            // 更新MaskedTextBox显示资源变化
            UpdateProcessUI();
        }
        

        // 清空UI中的MaskedTextBox
        private void ClearProcessUI()
        {
            P1_Max.Clear();
            P2_Max.Clear();
            P3_Max.Clear();
            P4_Max.Clear();
            P1_Allocation.Clear();
            P2_Allocation.Clear();
            P3_Allocation.Clear();
            P4_Allocation.Clear();
            P1_Need.Clear();
            P2_Need.Clear();
            P3_Need.Clear();
            P4_Need.Clear();
        }

        private void UpdateProcessUI()
        {
            

            // 格式化并填充到 MaskedTextBox 中
            P1_Max.Text = string.Join("", bankersAlgorithm.Text[0]);
            P2_Max.Text = string.Join("", bankersAlgorithm.Text[3]);
            P3_Max.Text = string.Join("", bankersAlgorithm.Text[6]);
            P4_Max.Text = string.Join("", bankersAlgorithm.Text[9]);

            P1_Allocation.Text = string.Join("", bankersAlgorithm.Text[1]);
            P2_Allocation.Text = string.Join("", bankersAlgorithm.Text[4]);
            P3_Allocation.Text = string.Join("", bankersAlgorithm.Text[7]);
            P4_Allocation.Text = string.Join("", bankersAlgorithm.Text[10]);

            P1_Need.Text = string.Join("", bankersAlgorithm.Text[2]);
            P2_Need.Text = string.Join("", bankersAlgorithm.Text[5]);
            P3_Need.Text = string.Join("", bankersAlgorithm.Text[8]);
            P4_Need.Text = string.Join("", bankersAlgorithm.Text[11]);



        }


    }
}
