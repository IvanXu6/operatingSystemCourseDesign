using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
{
    public abstract class Scheduler//调度器
    {
        protected ProcessController controller;

        public Scheduler(ProcessController controller)
        {
            this.controller = controller;
        }

        public abstract Process SelectNextProcess(int currentTime);
    }
}
