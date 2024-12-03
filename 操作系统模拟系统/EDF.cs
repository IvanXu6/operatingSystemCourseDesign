<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
{
    public class EDF:Scheduler
    {
        public EDF(ProcessController controller) : base(controller) { }

        public override Process SelectNextProcess(int currentTime)
        {
            return controller.processes.Values
                .Where(p => p.RemainingTime > 0 && (p.NextReleaseTime <= currentTime))
                .OrderBy(p => p.Deadline - currentTime)
                .FirstOrDefault();
        }
    }
=======
﻿using System.Linq;

namespace 操作系统模拟系统
{
    public class EDF : Scheduler
    {
        public EDF(ProcessController processController) : base(processController) { }

        public override void StartScheduling()
        {
            // 获取所有就绪态进程并按截止时间排序
            var readyProcesses = processController.processes
                .Where(p => processController.processStates[p.Key] == ProcessState.Ready)
                .OrderBy(p => p.Value.Deadline)
                .Select(p => p.Value)
                .ToList();

            foreach (var process in readyProcesses)
            {
                processController.processStates[process.ProcessId] = ProcessState.Running;
                process.Run(); // 执行一个时间单位
                processController.processStates[process.ProcessId] = ProcessState.Ready; // 结束后恢复为就绪态
            }
        }
    }

>>>>>>> Stashed changes
}
