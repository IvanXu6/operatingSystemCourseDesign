using System.Collections.Generic;
using System.Threading;
using System;
<<<<<<< Updated upstream

namespace 操作系统模拟系统
{
    public enum ProductName 
    {
        喵喵兵,
        工程兵,
        西八里耶,
        十字弩
    }
=======
using System.Windows.Forms;

namespace 操作系统模拟系统
{
        public enum ProductName 
        {
            喵喵兵,
            工程兵,
            西八里耶,
            十字弩
        }
    
        public enum ProducerStatus
        {
            空闲,
            生产中,
            被阻塞
        }
        public enum ConsumerStatus
        {
            空闲,
            消费中,
            被阻塞
        }

    // 生产者结构体，包含 ID 和状态
    public struct Producer
    {
        public int Id;
        public ProducerStatus Status;
    }

    // 消费者结构体，包含 ID 和状态
    public struct Consumer
    {
        public int Id;
        public ConsumerStatus Status;
    }

    /// <summary>
    /// 产品
    /// </summary>
>>>>>>> Stashed changes
    public struct Product
    {
        public int productId;
        public string name;
    }
<<<<<<< Updated upstream
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
=======

    public class ProducerConsumer
    {
        public int numProducers;
        public int numConsumers;
        public int bufferCapacity;
        public string useSemaphore;
        public Semaphore empty;
        public Semaphore full;
        public List<Product> buffer;

        public Random random;
        public int i = 1;
        public bool isRunning = true;

        // 存储生产者和消费者的结构体列表
        public List<Producer> producers;
        public List<Consumer> consumers;

        public processSynchronization ui;

        public ProducerConsumer(int numProducers, int numConsumers, int bufferCapacity, processSynchronization ui)
>>>>>>> Stashed changes
        {
            this.numProducers = numProducers;
            this.numConsumers = numConsumers;
            this.bufferCapacity = bufferCapacity;
            this.buffer = new List<Product>(bufferCapacity);
            this.random = new Random();
<<<<<<< Updated upstream

            // 根据参数选择信号量类型
            if (useCountingSemaphore)
=======
            // 初始化生产者和消费者的结构体列表
            producers = new List<Producer>(numProducers);
            consumers = new List<Consumer>(numConsumers);
            this.ui = ui;  // 保存UI实例，用于更新UI
        }

        // 选择信号量
        public void SelectSemphore(string useSemaphore)
        {
            if (useSemaphore == "记录型信号量")
>>>>>>> Stashed changes
            {
                empty = new CountingSemaphore(bufferCapacity);  // 空位信号量
                full = new CountingSemaphore(0);  // 产品信号量
            }
<<<<<<< Updated upstream
            else
=======
            else if (useSemaphore == "AND型信号量")
>>>>>>> Stashed changes
            {
                empty = new AndSemaphore(bufferCapacity);  // 空位信号量
                full = new AndSemaphore(0);  // 产品信号量
            }
        }

<<<<<<< Updated upstream
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
=======
        // 创建生产者线程
        public void CreateProducer()
        {
            if (isRunning && producers.Count < numProducers)
            {
                // 创建新的生产者，并将其添加到列表中
                Producer producer = new Producer
                {
                    Id = producers.Count + 1,
                    Status = ProducerStatus.空闲,
                };
                producers.Add(producer);
            }
        }

        // 创建消费者线程
        public void CreateConsumer()
        {
            if (isRunning && consumers.Count < numConsumers)
            {
                Consumer consumer = new Consumer
                {
                    Id = consumers.Count + 1,
                    Status = ConsumerStatus.空闲,
                };
                consumers.Add(consumer);  // 添加消费者
            }
        }

        // 启动生产者线程
        public void StartProducers()
        {
            for (int i = 0; i < producers.Count; i++)
            {
                Producer producer = producers[i];
                ThreadPool.QueueUserWorkItem(state => Produce());
            }
        }

        public void StartConsumers()
        {
            for (int i = 0; i < consumers.Count; i++)
            {
                Consumer consumer = consumers[i];
                ThreadPool.QueueUserWorkItem(state => Consume());
            }
        }

        public void Produce()
        {
            while (isRunning)
            {
                int producerId = random.Next(0, producers.Count);
                Producer producer = producers[producerId];

                // 状态先设置为阻塞，等待空位
                producer.Status = ProducerStatus.被阻塞;

                empty.P();  // 等待空位信号量

                // 生产者开始生产，设置状态为生产中
                producer.Status = ProducerStatus.生产中;

                ProductName productName = (ProductName)random.Next(Enum.GetValues(typeof(ProductName)).Length);

                Product product = new Product
                {
                    productId = i++,  // 产品ID
                    name = productName.ToString()  // 产品名称
>>>>>>> Stashed changes
                };

                lock (buffer)
                {
<<<<<<< Updated upstream
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
=======
                    buffer.Add(product);  // 将产品放入缓冲区
                                          // 更新 UI，显示日志
                    ui.Invoke((MethodInvoker)delegate
                    {
                        UpdateBufferView();  // 更新缓冲区视图
                        ui.txt_Diary.AppendText($"生产者 {producer.Id} 生产了产品 {product.name}, 产品ID: {product.productId}" + Environment.NewLine);
                    });
                }

                producers[producerId] = producer;

                full.V();  // 唤醒消费者

                Thread.Sleep(random.Next(1000, 3000));  // 生产延迟
            }
        }



        public void Consume()
        {
            while (isRunning)
            {
                // 随机选择一个消费者
                int consumerId = random.Next(0, consumers.Count);
                Consumer consumer = consumers[consumerId];

                // 消费者的状态设置为阻塞，等待产品
                consumer.Status = ConsumerStatus.被阻塞;

                full.P();  // 等待产品信号量

                // 设置消费者为消费中
                consumer.Status = ConsumerStatus.消费中;
>>>>>>> Stashed changes

                Product product;
                lock (buffer)
                {
                    if (buffer.Count > 0)
                    {
<<<<<<< Updated upstream
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

=======
                        int productIndex = random.Next(0, buffer.Count);
                        product = buffer[productIndex];
                        buffer.RemoveAt(productIndex);  // 移除缓冲区中的产品
                    }
                    else
                    {
                        continue;  // 如果没有产品，继续等待
                    }
                }

                // 更新消费者状态为空闲
                consumers[consumerId] = consumer;

                empty.V();  // 唤醒生产者

                // 更新UI
                ui.Invoke((MethodInvoker)delegate
                {
                    UpdateBufferView();  // 更新缓冲区视图
                    ui.txt_Diary.AppendText($"消费者 {consumer.Id} 消费了产品 {product.name}, 产品ID: {product.productId}" + Environment.NewLine);
                });

                // 模拟消费时间
                Thread.Sleep(random.Next(4000, 6000));  // 消费延迟
            }
        }

        // 更新缓冲区视图
        public void UpdateBufferView()
        {
            // 清空现有的行
            ui.BufferView.Rows.Clear();

            // 添加新的行，显示缓冲区的内容
            foreach (var product in buffer)
            {
                ui.BufferView.Rows.Add(new object[] { product.productId, product.name });
            }
        }


>>>>>>> Stashed changes
        // 重置功能
        public void Reset()
        {
            lock (buffer)
            {
                // 清空缓冲区
                buffer.Clear();
<<<<<<< Updated upstream
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
=======

                // 重置生产者和消费者ID
                producers.Clear();
                consumers.Clear();

                // 停止当前的生产者和消费者线程
                isRunning = false;

                // 等待现有线程退出
                Thread.Sleep(5000);  // 等待现有线程退出

                // 重新开始生产和消费
                isRunning = true;
            }
        }
    }

>>>>>>> Stashed changes
}
