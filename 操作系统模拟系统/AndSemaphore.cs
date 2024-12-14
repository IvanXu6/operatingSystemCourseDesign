using System.Threading;

namespace 操作系统模拟系统
{
    public class AndSemaphore : Semaphore
    {
        private bool signal = false;

        public AndSemaphore(int initialValue) : base(initialValue) { }

        public override void P()
        {
            lock (lockObject)
            {
                while (!signal)
                {
                    Monitor.Wait(lockObject);  // 等待信号
                }
<<<<<<< Updated upstream
                signal = false;  // 重置信号状态
=======
                signal = false;  // 重置信号状态，确保生产/消费操作可以继续
>>>>>>> Stashed changes
            }
        }

        public override void V()
        {
            lock (lockObject)
            {
                signal = true;  // 设置信号状态为真
<<<<<<< Updated upstream
                Monitor.Pulse(lockObject);  // 唤醒等待的线程
=======
                Monitor.Pulse(lockObject);  // 唤醒一个等待的线程
>>>>>>> Stashed changes
            }
        }
    }

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
}
