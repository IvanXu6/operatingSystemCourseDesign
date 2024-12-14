using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public partial class MemoryAllcation : 操作系统模拟系统.Main
    {
        public int 总内存 = 0;
        //内存块结构
        public class MemoryBlock
        {
            public int StartAddress { get; set; }  // 起始地址
            public int EndAddress { get; set; }    // 结束地址
            public int Size { get; set; }          // 内存块大小
            public bool IsAllocated { get; set; }  // 是否分配
            public int JobId { get; set; }         // 所属作业号
        }

        // 定义作业结构
        public class Job
        {
            public int JobId { get; set; }  // 作业编号
            public int MemoryNeeded { get; set; }  // 需要的内存
        }

        private List<MemoryBlock> memoryBlocks = new List<MemoryBlock>(); // 内存块列表
        private List<Job> jobs = new List<Job>(); // 作业列表


        public MemoryAllcation()
        {
            InitializeComponent();
            InitializeMemory();
            InitializeJobs();
            UpdateMemoryDisplay();
        }

        // 初始化内存块
        private void InitializeMemory()
        {
            // 假设内存区域有5个块，每个块大小随机
            memoryBlocks.Add(new MemoryBlock { StartAddress = 0, Size = 300, IsAllocated = false });
            memoryBlocks.Add(new MemoryBlock { StartAddress = 300, Size = 500, IsAllocated = false });
            memoryBlocks.Add(new MemoryBlock { StartAddress = 800, Size = 200, IsAllocated = false });
            memoryBlocks.Add(new MemoryBlock { StartAddress = 1000, Size = 700, IsAllocated = false });
            memoryBlocks.Add(new MemoryBlock { StartAddress = 1700, Size = 600, IsAllocated = false });

            // 更新结束地址
            foreach (var block in memoryBlocks)
            {
                block.EndAddress = block.StartAddress + block.Size - 1;
            }
        }

        // 初始化作业
        private void InitializeJobs()
        {
            jobs.Add(new Job { JobId = 1, MemoryNeeded = 400 });
            jobs.Add(new Job { JobId = 2, MemoryNeeded = 600 });
            jobs.Add(new Job { JobId = 3, MemoryNeeded = 200 });
            jobs.Add(new Job { JobId = 4, MemoryNeeded = 500 });
            jobs.Add(new Job { JobId = 5, MemoryNeeded = 300 });
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 申请内存_Click(object sender, EventArgs e)
        {
            foreach (var job in jobs)
            {
                bool allocated = false;

                // 首次适应算法
                for (int i = 0; i < memoryBlocks.Count; i++)
                {
                    if (!memoryBlocks[i].IsAllocated && memoryBlocks[i].Size >= job.MemoryNeeded)
                    {
                        memoryBlocks[i].IsAllocated = true;
                        memoryBlocks[i].JobId = job.JobId;
                        allocated = true;
                        break;
                    }
                }

                if (!allocated)
                {
                    MessageBox.Show($"作业 {job.JobId} 无法分配内存！");
                }
            }

            UpdateMemoryDisplay();
    }

        private void 回收内存_Click(object sender, EventArgs e)
        {
            // 假设释放内存的顺序是作业ID顺序
            foreach (var job in jobs)
            {
                for (int i = 0; i < memoryBlocks.Count; i++)
                {
                    if (memoryBlocks[i].IsAllocated && memoryBlocks[i].JobId == job.JobId)
                    {
                        memoryBlocks[i].IsAllocated = false;
                        memoryBlocks[i].JobId = 0;
                        break;
                    }
                }
            }

            UpdateMemoryDisplay();
        }

        // 更新内存显示到 DataGridView
        private void UpdateMemoryDisplay()
        {
            // 清空现有的行
            内存分配演示表格.Rows.Clear();

            // 设置 DataGridView 列标题
            内存分配演示表格.Columns.Clear();
            内存分配演示表格.Columns.Add("StartAddress", "起始地址");
            内存分配演示表格.Columns.Add("EndAddress", "结束地址");
            内存分配演示表格.Columns.Add("Size", "内存块大小");
            内存分配演示表格.Columns.Add("Status", "内存块状态");
            内存分配演示表格.Columns.Add("JobId", "作业号");

            // 填充数据
            foreach (var block in memoryBlocks)
            {
                string status = block.IsAllocated ? $"分配给作业 {block.JobId}" : "空闲";
                内存分配演示表格.Rows.Add(block.StartAddress, block.EndAddress, block.Size, status, block.JobId);
            }
        }

        private void 初始化内存分配_Click(object sender, EventArgs e)
        {
            if (int.Parse(所需内存.Text) > 0)
                总内存 = int.Parse(所需内存.Text);
        }
    }
}
