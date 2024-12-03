using System.Collections.Generic;
using System.Threading;
using System;

namespace 操作系统模拟系统
{
    public enum ProductName 
    {
        喵喵兵,
        工程兵,
        西八里耶,
        十字弩
    }
    public struct Product
    {
        public int productId;
        public string name;
    }
    class ProducerConsumer
    {
        private int numProducers;
        private int numConsumers;
        private int producerId = 1;
        private int consumerId = 1;
        private int bufferCapacity;

        private Semaphore empty;
        private Semaphore full;
        private List<Product> buffer;

        private Random random;        
        private int i = 1;
        private bool isRunning = true;

        public ProducerConsumer(int numProducers, int numConsumers, int bufferCapacity, bool useCountingSemaphore)
        {
            this.numProducers = numProducers;
            this.numConsumers = numConsumers;
            this.bufferCapacity = bufferCapacity;
            this.buffer = new List<Product>(bufferCapacity);
            this.random = new Random();

            // 根据参数选择信号量类型
            if (useCountingSemaphore)
            {
                empty = new CountingSemaphore(bufferCapacity);  // 空位信号量
                full = new CountingSemaphore(0);  // 产品信号量
            }
            else
            {
                empty = new AndSemaphore(bufferCapacity);  // 空位信号量
                full = new AndSemaphore(0);  // 产品信号量
            }
        }

        // 创建生产者进程
        public void CreateProducer()
        {
            if (isRunning)
                ThreadPool.QueueUserWorkItem(state => Produce(producerId++));
        }

        // 创建消费者进程
        public void CreateConsumer()
        {
            if (isRunning)
                ThreadPool.QueueUserWorkItem(state => Consume(consumerId++));
        }

        private void Produce(int producerId)
        {
            while (isRunning)
            {
                empty.P();  // 等待空位

                // 随机选择一个产品（从 ProductName 枚举中）
                ProductName productName = (ProductName)random.Next(Enum.GetValues(typeof(ProductName)).Length);

                // 创建一个 Product 结构体，并赋值
                Product product = new Product
                {
                    productId = i++,  // 为产品生成唯一ID
                    name = productName.ToString()  // 将随机选择的产品名赋给产品
                };

                lock (buffer)
                {
                    buffer.Add(product);  // 将生产的产品放入缓冲区
                    Console.WriteLine($"Producer {producerId} produced {product.name} (ID: {product.productId})");
                    //此处添加前端信息显示代码

                }

                full.V();  // 唤醒消费者
                Thread.Sleep(1000);  // 模拟生产时间
            }
        }

        private void Consume(int consumerId)
        {
            while (isRunning)
            {
                full.P();  // 等待产品

                Product product;
                lock (buffer)
                {
                    if (buffer.Count > 0)
                    {
                        product = buffer[0];
                        buffer.RemoveAt(0);  // 从缓冲区取出产品
                        Console.WriteLine($"Consumer {consumerId} consumed {product.name} (ID: {product.productId})");
                        //此处添加前端信息显示代码
                    }
                    else
                    {
                        continue;
                    }
                }

                empty.V();  // 唤醒生产者
                Thread.Sleep(1500);  // 模拟消费时间
            }
        }

        // 重置功能
        public void Reset()
        {
            lock (buffer)
            {
                // 清空缓冲区
                buffer.Clear();
                Console.WriteLine("Buffer cleared.");

                // 重置生产者和消费者ID
                producerId = 1;
                consumerId = 1;

                // 停止当前的生产者和消费者线程
                isRunning = false;
                Console.WriteLine("Production and consumption stopped.");

                // 等待现有线程退出
                Thread.Sleep(2000);  // 等待现有线程退出

                // 重新开始生产和消费
                isRunning = true;
                
            }
        }
    }
}
