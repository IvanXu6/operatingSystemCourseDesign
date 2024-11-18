using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
{
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
}
