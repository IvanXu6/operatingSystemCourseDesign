using System;

namespace 操作系统模拟系统
{
<<<<<<< Updated upstream
    class ProcessForDeadlockAvoid
=======
    public class ProcessForDeadlockAvoid
>>>>>>> Stashed changes
    {
        public int ProcessId { get; private set; }
        public string ProcessName { get; private set; }
        public int[] MaxResources { get; private set; } // 每个进程的最大资源需求
        public int[] AllocatedResources { get; private set; } // 每个进程已经分配的资源
        public int[] NeedResources { get; private set; } // 每个进程还需要的资源

        private static Random random = new Random();

        public ProcessForDeadlockAvoid(int processId, string processName, int maxResourceTypes)
        {
            ProcessId = processId;
            ProcessName = processName;

            MaxResources = new int[maxResourceTypes];
            AllocatedResources = new int[maxResourceTypes];
            NeedResources = new int[maxResourceTypes];

<<<<<<< Updated upstream
            // 随机生成最大资源需求 (最大需求在 1 到 10 之间)
            for (int i = 0; i < maxResourceTypes; i++)
            {
                MaxResources[i] = random.Next(1, 11);
=======
            // 随机生成最大资源需求 (最大需求在 4 到 9 之间)
            for (int i = 0; i < maxResourceTypes; i++)
            {
                MaxResources[i] = random.Next(4, 10);
>>>>>>> Stashed changes
                AllocatedResources[i] = random.Next(0, MaxResources[i] + 1); // 已分配资源随机生成，最大不超过需求
                NeedResources[i] = MaxResources[i] - AllocatedResources[i];
            }
        }

        // 请求资源
        public bool RequestResources(int[] request)
        {
            for (int i = 0; i < request.Length; i++)
            {
                if (request[i] > NeedResources[i] || request[i] > (MaxResources[i] - AllocatedResources[i]))
                {
                    return false; // 请求超过需求或超过最大资源需求
                }
            }
            return true;
        }

        // 分配资源
        public void AllocateResources(int[] request)
        {
            for (int i = 0; i < request.Length; i++)
            {
                AllocatedResources[i] += request[i];
                NeedResources[i] -= request[i];
            }
        }

        // 释放资源
        public void ReleaseResources(int[] release)
        {
            for (int i = 0; i < release.Length; i++)
            {
                AllocatedResources[i] -= release[i];
                NeedResources[i] += release[i];
            }
        }

        // 重置进程的资源和需求
        public void Reset()
        {
            for (int i = 0; i < MaxResources.Length; i++)
            {
                AllocatedResources[i] = 0; // 将已分配资源清零
                NeedResources[i] = MaxResources[i]; // 需要的资源重新设置为最大需求
            }
        }
    }
}
