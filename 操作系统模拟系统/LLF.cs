using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
{
<<<<<<< Updated upstream
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
=======
>>>>>>> Stashed changes
    public class LLF : Scheduler
    {
        public LLF(ProcessController processController) : base(processController) { }

        public override void StartScheduling()
        {
<<<<<<< Updated upstream
            // 获取所有就绪态进程并计算宽松度
            var readyProcesses = processController.processes
                .Where(p => processController.processStates[p.Key] == ProcessState.Ready)
                .Select(p => p.Value)
                .OrderBy(p => p.Deadline - (processController.processStates[p.ProcessId] == ProcessState.Ready ? 0 : p.RemainingTime)) // 计算宽松度
=======
            var readyProcesses = processController.processes
                .Where(p => processController.processStates[p.Key] == ProcessState.就绪)
                .Select(p => p.Value)
                .OrderBy(p => p.Deadline - (processController.processStates[p.ProcessId] == ProcessState.就绪 ? 0 : p.RemainingTime))
>>>>>>> Stashed changes
                .ToList();

            foreach (var process in readyProcesses)
            {
<<<<<<< Updated upstream
                processController.processStates[process.ProcessId] = ProcessState.Running;
                process.Run(); // 执行一个时间单位
                processController.processStates[process.ProcessId] = ProcessState.Ready; // 结束后恢复为就绪态
=======
                processController.processStates[process.ProcessId] = ProcessState.运行;
                processController.Log($"[算法: LLF] 进程 {process.ProcessName} 执行，剩余时间 {process.RemainingTime}, 状态：就绪 -> 运行");

                process.Run();

                processController.processStates[process.ProcessId] = ProcessState.就绪;
                processController.Log($"[算法: LLF] 进程 {process.ProcessName} 完成，状态：运行 -> 就绪");
>>>>>>> Stashed changes
            }
        }
    }

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
}
