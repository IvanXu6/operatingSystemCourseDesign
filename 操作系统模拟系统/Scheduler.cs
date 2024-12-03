using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
{
<<<<<<< Updated upstream
    public abstract class Scheduler//调度器
    {
        protected ProcessController controller;

        public Scheduler(ProcessController controller)
        {
            this.controller = controller;
        }

        public abstract Process SelectNextProcess(int currentTime);
    }
=======
    public abstract class Scheduler
    {
        protected ProcessController processController;

        public Scheduler(ProcessController processController)
        {
            this.processController = processController;
        }

        // 开始调度
        public abstract void StartScheduling();

        // 停止调度并重置所有进程
        public void StopScheduling()
        {
            processController.ClearSchedulingQueue(); // 清空调度队列
            foreach (var processId in processController.processes.Keys)
            {
                processController.processStates[processId] = ProcessState.Ready; // 将所有进程状态恢复为就绪态
            }
        }
    }

>>>>>>> Stashed changes
}
