<<<<<<< Updated upstream
<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作系统模拟系统
=======
﻿namespace 操作系统模拟系统
>>>>>>> Stashed changes
=======
﻿namespace 操作系统模拟系统
>>>>>>> Stashed changes
{
    public class Process
    {
        public int ProcessId { get; private set; }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        public string ProcessName { get; private set; }
>>>>>>> Stashed changes
=======
        public string ProcessName { get; private set; }
>>>>>>> Stashed changes
        public int Period { get; private set; }
        public int ExecutionTime { get; private set; } // 执行时间
        public int Deadline { get; private set; } // 截止时间
        public int RemainingTime { get; private set; } // 剩余执行时间
        public int NextReleaseTime { get; private set; } // 下一次释放时间

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public Process(int processId, int period, int executionTime)
        {
            ProcessId = processId;
=======
=======
>>>>>>> Stashed changes
        public Process(int processId,string processname, int period, int executionTime)
        {
            ProcessId = processId;
            ProcessName = processname;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            Period = period;
            ExecutionTime = executionTime;
            RemainingTime = executionTime;
            Deadline = period; // 假设截止时间等于周期
            NextReleaseTime = 0;
        }

        // 重置进程的剩余执行时间，并更新下一次释放时间。
        public void Reset()
        {
            RemainingTime = ExecutionTime;
            NextReleaseTime += Period;
        }

        // 模拟进程执行一个时间单位
        public void Run()
        {
            if (RemainingTime > 0)
            {
                RemainingTime--;
            }
        }

        // 检查进程是否完成
        public bool IsFinished()
        {
            return RemainingTime == 0;
        }

        // 更新进程状态，可以在每个时间单位被调用
        public void Update(int currentTime)
        {
            if (IsFinished() && currentTime >= NextReleaseTime)
            {
                Reset();
            }
        }
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    }

}
