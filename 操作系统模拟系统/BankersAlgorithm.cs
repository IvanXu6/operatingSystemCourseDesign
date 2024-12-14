using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< Updated upstream

namespace 操作系统模拟系统
{
    class BankersAlgorithm
    {
        public int[] AvailableResources { get; private set; } // 当前系统中可用的资源
        public List<ProcessForDeadlockAvoid> Processes { get; private set; } // 所有进程
        public int[][] Allocation { get; private set; } // 记录所有进程的资源分配情况
        public int[][] Max { get; private set; } // 记录所有进程的最大资源需求
        public int[][] Need { get; private set; } // 记录所有进程的剩余需求
=======
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public class BankersAlgorithm
    {
        public int[] AvailableResources { get; private set; } // 当前系统中可用的资源
        public List<ProcessForDeadlockAvoid> Processes { get; private set; } // 所有进程
        public int[,] Max { get; private set; } // 记录所有进程的最大资源需求（4行3列）
        public int[,] Allocation { get; private set; } // 记录所有进程的资源分配情况（4行3列）
        public int[,] Need { get; private set; } // 记录所有进程的剩余需求（4行3列）
        public List<int[]> Text { get; private set; } // 存储格式化后的资源数组（三位数格式的int数组）
>>>>>>> Stashed changes

        private static Random random = new Random();

        public BankersAlgorithm()
        {
<<<<<<< Updated upstream
            // 随机生成系统的资源总数（每种资源的可用数量在 1 到 10 之间）
            AvailableResources = new int[3];
            for (int i = 0; i < 3; i++)
            {
                AvailableResources[i] = random.Next(1, 11); // 可用资源数量在 1 到 10 之间
            }

            Processes = new List<ProcessForDeadlockAvoid>();
=======
            Processes = new List<ProcessForDeadlockAvoid>();
            Max = new int[4, 3]; // 4行3列
            Allocation = new int[4, 3]; // 4行3列
            Need = new int[4, 3]; // 4行3列
            Text = new List<int[]>(); // 每个元素为包含3个元素的int数组
>>>>>>> Stashed changes
        }

        // 随机生成四个进程
        public void GenerateProcesses()
        {
<<<<<<< Updated upstream
=======
            // 随机生成系统的资源总数（每种资源的可用数量在 7 到 10 之间）
            AvailableResources = new int[3];
            for (int i = 0; i < 3; i++)
            {
                AvailableResources[i] = random.Next(7, 11);
            }

>>>>>>> Stashed changes
            for (int i = 0; i < 4; i++)
            {
                string processName = $"P{i + 1}";
                ProcessForDeadlockAvoid newProcess = new ProcessForDeadlockAvoid(i + 1, processName, 3);
                Processes.Add(newProcess);
<<<<<<< Updated upstream
            }
        }

        // 请求资源
        public bool RequestResources(int processId, int[] request)
        {
            ProcessForDeadlockAvoid process = Processes.FirstOrDefault(p => p.ProcessId == processId);
            if (process == null || !process.RequestResources(request))
            {
                return false; // 无效的请求
            }

            // 尝试模拟分配资源，检查安全性
            for (int i = 0; i < request.Length; i++)
            {
                AvailableResources[i] -= request[i]; // 假设分配资源
                process.AllocateResources(request);
            }

            // 如果系统处于安全状态，资源分配生效
            if (IsSafeState(out List<int> safeSequence))
            {
                //此处打印安全序列
                //Console.WriteLine("Safe Sequence: " + string.Join(" -> ", safeSequence));
=======

                // 更新 Max, Allocation, Need 为二维矩阵
                for (int j = 0; j < 3; j++)
                {
                    Max[i, j] = newProcess.MaxResources[j];
                    Allocation[i, j] = newProcess.AllocatedResources[j];
                    Need[i, j] = newProcess.NeedResources[j];
                }
            }

            FormatResourceArray();
        }

        // 格式化资源数组为三位数的int数组
        public void FormatResourceArray()
        {
            Text.Clear();

            // 遍历 Max, Allocation, Need 三个矩阵
            for (int i = 0; i < 4; i++)
            {
                // 添加每行作为一个包含三个元素的int数组
                Text.Add(new int[] { Max[i, 0], Max[i, 1], Max[i, 2] });
                Text.Add(new int[] { Allocation[i, 0], Allocation[i, 1], Allocation[i, 2] });
                Text.Add(new int[] { Need[i, 0], Need[i, 1], Need[i, 2] });
            }
        }

        public bool RequestResources(int processId, out string log)
        {
            log = string.Empty;
            ProcessForDeadlockAvoid process = Processes.FirstOrDefault(p => p.ProcessId == processId);
            if (process == null)
            {
                log = "进程不存在";
                return false;
            }

            int[] request = new int[process.MaxResources.Length];

            // 检查每种资源请求是否有效
            for (int i = 0; i < request.Length; i++)
            {
                // 如果该进程不需要更多资源，则不请求
                if (process.NeedResources[i] == 0)
                {
                    request[i] = 0; // 该资源请求为 0
                    continue;
                }
                // 检查请求是否超出了可用资源
                if (request[i] > AvailableResources[i])
                {
                    log = $"请求资源超出可用资源：资源 {i + 1} 请求 {request[i]} 超过可用资源 {AvailableResources[i]}，拒绝请求。";
                    return false; // 超出最大资源，拒绝请求
                }

                // 请求的资源数量随机生成，确保不超过进程的需求
                if (process.NeedResources[i] > 0)
                {
                    request[i] = random.Next(0, process.NeedResources[i] + 1);

                }

                // 检查请求是否超出了需求范围
                if (request[i] > process.NeedResources[i])
                {
                    log = $"请求超出最大需求：资源 {i + 1} 请求 {request[i]} 超过最大需求 {process.NeedResources[i]}，拒绝请求。";
                    return false; // 超出最大需求，拒绝请求
                }
            }

            // 执行资源分配请求
            if (!process.RequestResources(request))
            {
                log = "请求无效，超过需求或最大资源";
                return false; // 请求无效
            }

            // 假设分配资源
            for (int i = 0; i < request.Length; i++)
            {
                AvailableResources[i] -= request[i];
                process.AllocateResources(request);
            }

            // 更新 Text 数据
            FormatResourceArray();

            // 检查是否处于安全状态
            if (IsSafeState(out List<int> safeSequence))
            {
                log = "安全序列：" + string.Join(" -> ", safeSequence) + $"当前可用资源{string.Join(", ", AvailableResources)}";
>>>>>>> Stashed changes
                return true;
            }
            else
            {
<<<<<<< Updated upstream
                // 如果不安全，撤销资源分配
=======
>>>>>>> Stashed changes
                for (int i = 0; i < request.Length; i++)
                {
                    AvailableResources[i] += request[i];
                    process.ReleaseResources(request);
                }
<<<<<<< Updated upstream
                //此处打印不安全序列
                //Console.WriteLine("Unsafe Sequence: No safe sequence exists.");
                return false; // 系统处于不安全状态
=======
                log = "不安全序列，无法分配资源";
                return false;
>>>>>>> Stashed changes
            }
        }

        // 释放资源
        public void ReleaseResources(int processId, int[] release)
        {
            ProcessForDeadlockAvoid process = Processes.FirstOrDefault(p => p.ProcessId == processId);
            if (process != null)
            {
                process.ReleaseResources(release);
                for (int i = 0; i < release.Length; i++)
                {
<<<<<<< Updated upstream
                    AvailableResources[i] += release[i]; // 释放资源到可用资源池
                }
=======
                    AvailableResources[i] += release[i];
                }

                FormatResourceArray();
>>>>>>> Stashed changes
            }
        }

        // 安全性算法：检查系统是否处于安全状态，并返回安全序列
        public bool IsSafeState(out List<int> safeSequence)
        {
            int[] work = new int[AvailableResources.Length];
            AvailableResources.CopyTo(work, 0);

            bool[] finish = new bool[Processes.Count];
            safeSequence = new List<int>();

<<<<<<< Updated upstream
            while (safeSequence.Count < Processes.Count)
            {
                bool progressMade = false;

                for (int i = 0; i < Processes.Count; i++)
                {
                    if (!finish[i] && CanAllocate(Processes[i], work))
                    {
                        // 如果进程的需求可以满足，分配资源
                        for (int j = 0; j < AvailableResources.Length; j++)
                        {
                            work[j] += Processes[i].AllocatedResources[j];
                        }
                        finish[i] = true;
                        safeSequence.Add(Processes[i].ProcessId);
                        progressMade = true;
                        break;
                    }
                }

                if (!progressMade)
                {
                    return false; // 没有进程可以顺利执行，系统不安全
                }
            }

            return true; // 找到一个安全序列，系统安全
        }

=======
            Queue<int> readyQueue = new Queue<int>();

            // 找出所有能够执行的进程
            for (int i = 0; i < Processes.Count; i++)
            {
                if (CanAllocate(Processes[i], work) && !finish[i])
                {
                    readyQueue.Enqueue(i);
                }
            }

            while (readyQueue.Count > 0)
            {
                int i = readyQueue.Dequeue();
                if (finish[i]) continue;

                // 分配资源
                for (int j = 0; j < AvailableResources.Length; j++)
                {
                    work[j] += Processes[i].AllocatedResources[j];
                }

                finish[i] = true;
                safeSequence.Add(Processes[i].ProcessId);

                // 更新队列中的其他进程
                for (int j = 0; j < Processes.Count; j++)
                {
                    if (!finish[j] && CanAllocate(Processes[j], work))
                    {
                        readyQueue.Enqueue(j);
                    }
                }
            }

            return safeSequence.Count == Processes.Count;
        }
>>>>>>> Stashed changes

        // 检查是否可以分配资源给一个进程
        private bool CanAllocate(ProcessForDeadlockAvoid process, int[] work)
        {
            for (int i = 0; i < process.NeedResources.Length; i++)
            {
                if (process.NeedResources[i] > work[i])
                {
<<<<<<< Updated upstream
                    return false; // 需要的资源超过当前可用资源
=======
                    return false;
>>>>>>> Stashed changes
                }
            }
            return true;
        }

<<<<<<< Updated upstream
        // 重置系统和进程
        public void Reset()
        {
            // 重置可用资源
            for (int i = 0; i < AvailableResources.Length; i++)
            {
                AvailableResources[i] = random.Next(1, 11); // 随机重新生成可用资源数量
            }

            // 重置进程状态
            foreach (var process in Processes)
            {
                // 重置进程的已分配资源、剩余需求资源
                process.Reset();
            }
        }
    }
=======
        public void Reset()
        {
            // 清空所有进程
            Processes.Clear();

            // 清空所有资源分配相关数组
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Allocation[i, j] = 0; // 清空已分配资源
                    Max[i, j] = 0;        // 清空最大需求资源
                    Need[i, j] = 0;       // 清空剩余需求资源
                }
            }

            // 清空可用资源
            for (int i = 0; i < AvailableResources.Length; i++)
            {
                AvailableResources[i] = 0; // 清空每种资源的可用量
            }

            // 清空格式化的资源数组
            Text.Clear();
        }
    }

>>>>>>> Stashed changes
}
