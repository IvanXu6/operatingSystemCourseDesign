using System;
using System.Collections.Generic;
using System.Linq;

namespace 操作系统模拟系统
{
    class BankersAlgorithm
    {
        public int[] AvailableResources { get; private set; } // 当前系统中可用的资源
        public List<ProcessForDeadlockAvoid> Processes { get; private set; } // 所有进程
        public int[][] Allocation { get; private set; } // 记录所有进程的资源分配情况
        public int[][] Max { get; private set; } // 记录所有进程的最大资源需求
        public int[][] Need { get; private set; } // 记录所有进程的剩余需求

        private static Random random = new Random();

        public BankersAlgorithm()
        {
            // 随机生成系统的资源总数（每种资源的可用数量在 1 到 10 之间）
            AvailableResources = new int[3];
            for (int i = 0; i < 3; i++)
            {
                AvailableResources[i] = random.Next(1, 11); // 可用资源数量在 1 到 10 之间
            }

            Processes = new List<ProcessForDeadlockAvoid>();
        }

        // 随机生成四个进程
        public void GenerateProcesses()
        {
            for (int i = 0; i < 4; i++)
            {
                string processName = $"P{i + 1}";
                ProcessForDeadlockAvoid newProcess = new ProcessForDeadlockAvoid(i + 1, processName, 3);
                Processes.Add(newProcess);
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
                return true;
            }
            else
            {
                // 如果不安全，撤销资源分配
                for (int i = 0; i < request.Length; i++)
                {
                    AvailableResources[i] += request[i];
                    process.ReleaseResources(request);
                }
                //此处打印不安全序列
                //Console.WriteLine("Unsafe Sequence: No safe sequence exists.");
                return false; // 系统处于不安全状态
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
                    AvailableResources[i] += release[i]; // 释放资源到可用资源池
                }
            }
        }

        // 安全性算法：检查系统是否处于安全状态，并返回安全序列
        public bool IsSafeState(out List<int> safeSequence)
        {
            int[] work = new int[AvailableResources.Length];
            AvailableResources.CopyTo(work, 0);

            bool[] finish = new bool[Processes.Count];
            safeSequence = new List<int>();

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


        // 检查是否可以分配资源给一个进程
        private bool CanAllocate(ProcessForDeadlockAvoid process, int[] work)
        {
            for (int i = 0; i < process.NeedResources.Length; i++)
            {
                if (process.NeedResources[i] > work[i])
                {
                    return false; // 需要的资源超过当前可用资源
                }
            }
            return true;
        }

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
}
