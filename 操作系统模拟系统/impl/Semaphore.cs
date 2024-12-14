namespace 操作系统模拟系统
{
    public abstract class Semaphore
    {
        protected int value;  // 信号量的值
        protected readonly object lockObject = new object();  // 锁对象

        public Semaphore(int initialValue)
        {
            value = initialValue;
        }

        // P操作（等待）
        public abstract void P();

        // V操作（信号）
        public abstract void V();
    }

}
