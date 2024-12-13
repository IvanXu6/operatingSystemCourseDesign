using System.Threading;

namespace 操作系统模拟系统
{
    public class CountingSemaphore : Semaphore
    {
        public CountingSemaphore(int initialValue) : base(initialValue) { }

        public override void P()
        {
            lock (lockObject)
            {
                while (value <= 0)
                {
                    Monitor.Wait(lockObject);  // 等待信号量大于0
                }
                value--;  // 执行P操作，减少信号量值
            }
        }

        public override void V()
        {
            lock (lockObject)
            {
                value++;  // 执行V操作，增加信号量值
                Monitor.Pulse(lockObject);  // 唤醒等待的线程
            }
        }
    }

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
}
