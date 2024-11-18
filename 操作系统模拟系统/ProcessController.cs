using System;
using System.Collections.Generic;

namespace 操作系统模拟系统
{
    public enum ProcessState//进程状态
    {
        Ready,//就绪
        Running,//运行
        Blocked,//阻塞
        Terminated//终止
    }

    public class ProcessController//进程控制类，对进程执行相关操作
    {
        /// <summary>
        /// processes字典存储了所有进程的实例，键是进程ID，值是Process类的实例。
        /// </summary>
        public Dictionary<int, Process> processes = new Dictionary<int, Process>();
        /// <summary>
        /// processStates字典存储了每个进程的当前状态，键是进程ID，值是ProcessState枚举。
        /// </summary>
        public Dictionary<int, ProcessState> processStates = new Dictionary<int, ProcessState>();
        public Scheduler scheduler;

        public List<Process> suspendedProcesses = new List<Process>(); // 模拟外存中的挂起进程列表


        public void SetScheduler(Scheduler scheduler)
        {
            this.scheduler = scheduler;
        }

        //创建进程
        public Process CreateProcess(int processId, int period, int executionTime)
        {
            //检查该ID是否被创建
            if (processes.ContainsKey(processId))
            {
                throw new ArgumentException("该ID进程已被创建");
            }

            Process newProcess = new Process(processId, period, executionTime);
            processes.Add(processId, newProcess);//将进程放入processes
            processStates.Add(processId, ProcessState.Ready);//进程状态设为就绪
            return newProcess;
        }

        //终止进程
        public void TerminateProcess(int processId)
        {
            if (processes.ContainsKey(processId))
            {
                processes.Remove(processId);//将进程移除processes
                processStates[processId] = ProcessState.Terminated;//进程状态设为终止
            }
        }

        // 挂起进程
        public void SuspendProcess(int processId)
        {
            if (processes.TryGetValue(processId, out Process process))
            {
                processStates[processId] = ProcessState.Blocked;
                suspendedProcesses.Add(process); // 将进程移入外存表示
                processes.Remove(processId); // 从活动进程列表中移除                
            }
        }

        // 激活进程
        public void ActivateProcess(int processId)
        {
            Process processToActivate = suspendedProcesses.Find(p => p.ProcessId == processId);
            if (processToActivate != null)
            {
                suspendedProcesses.Remove(processToActivate); // 从外存表示中移除
                processes[processId] = processToActivate; // 添加回活动进程列表
                processStates[processId] = ProcessState.Ready; // 更新状态为就绪
            }
        }


        //监控进程
        public void MonitorProcesses(int currentTime)
        {
            foreach (var process in processes.Values)
            {
                if (processStates[process.ProcessId] == ProcessState.Running)
                {
                    //若进程处于运行态，模拟进程执行
                    process.Run();
                    //进程运行结束后，重置进程剩余运行时间，更新状态为就绪
                    if (process.IsFinished())
                    {
                        processStates[process.ProcessId] = ProcessState.Ready;
                        process.Reset();
                    }
                }
                //若进程处于就绪态，则更新进程状态，可以在每个时间单位被调用
                else if (processStates[process.ProcessId] == ProcessState.Ready)
                {
                    process.Update(currentTime);
                }
            }
        }



        //进程调度（EDF，LLF两种调度算法）
        public void DemonstrateScheduling(int currentTime)
        {
            // 使用调度器选择下一个要运行的进程（此处需添加功能，选择EDF或者LLF）
            Process nextProcess = scheduler.SelectNextProcess(currentTime);

            // 如果有进程被选中，则运行它
            if (nextProcess != null)
            {
                ProcessState state = ProcessState.Ready;
                processStates.TryGetValue(nextProcess.ProcessId, out state);

                if (state == ProcessState.Ready)
                {
                    processStates[nextProcess.ProcessId] = ProcessState.Running;
                    nextProcess.Run();
                    if (nextProcess.IsFinished())
                    {
                        processStates[nextProcess.ProcessId] = ProcessState.Ready;
                        nextProcess.Reset();
                    }
                }
            }
        }
        //进程同步（记录型，AND或信号量集模拟解决生产者消费者问题）
        //在已创建的线程中，分别选择进程放入生产者和消费者队列，对缓冲池进行调用，模拟执行生产者-消费者问题

        //进程通信（模拟直接消息传递系统？）

        //死锁处理（模拟银行家算法）

        //内存分配

    }

}
