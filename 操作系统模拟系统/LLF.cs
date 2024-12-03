using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
{
<<<<<<< Updated upstream
    public class LLF:Scheduler
    {
        public LLF(ProcessController controller) : base(controller) { }

        public override Process SelectNextProcess(int currentTime)
        {
            return controller.processes.Values
                .Where(p => p.RemainingTime > 0 && (p.NextReleaseTime <= currentTime))
                .OrderBy(p => Math.Max(0, p.Deadline - currentTime - p.RemainingTime))
                .FirstOrDefault();
        }
    }
=======
    public class LLF : Scheduler
    {
        public LLF(ProcessController processController) : base(processController) { }

        public override void StartScheduling()
        {
            // 获取所有就绪态进程并计算宽松度
            var readyProcesses = processController.processes
                .Where(p => processController.processStates[p.Key] == ProcessState.Ready)
                .Select(p => p.Value)
                .OrderBy(p => p.Deadline - (processController.processStates[p.ProcessId] == ProcessState.Ready ? 0 : p.RemainingTime)) // 计算宽松度
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
