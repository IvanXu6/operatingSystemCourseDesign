using System;
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public partial class processSynchronization : 操作系统模拟系统.Main
    {
        public ProducerConsumer producerConsumer;
        private Timer _autoDemoTimer ;
        private int tickCount = 0;  // 计时器触发的次数
        private Timer _autoDemoDurationTimer;  // 用于定时停止演示

        public Random random = new Random();
        // 初始化定时器
        private void InitializeAutoDemoTimers()
        {
            // 自动演示定时器
            _autoDemoTimer = new Timer();
            _autoDemoTimer.Interval = 3000;  // 每3秒触发一次
            _autoDemoTimer.Tick += AutoDemoTimer_Tick;

            // 自动停止定时器
            _autoDemoDurationTimer = new Timer();
            _autoDemoDurationTimer.Interval = 15000;  // 15秒后停止
            _autoDemoDurationTimer.Tick += AutoDemoDurationTimer_Tick;
        }

        public processSynchronization()
        {
            InitializeComponent();
            producerConsumer = new ProducerConsumer(5, 5, 20, this);  // 传递当前UI实例
        }
        
        private void SelectSemphore()
        {
            // 获取信号量类型
            producerConsumer.SelectSemphore(comboSemaphore.SelectedItem.ToString());
        }

        /// <summary>
        /// 增加生产者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            producerConsumer.CreateProducer();
            ProcucerView.Rows.Add(producerConsumer.producers[producerConsumer.producers.Count - 1].Id,
                producerConsumer.producers[producerConsumer.producers.Count - 1].Status);
            txt_Diary.Multiline = true;
            txt_Diary.AppendText($"生产者 {producerConsumer.producers[producerConsumer.producers.Count - 1].Id} 已创建，" +
                $"状态{producerConsumer.producers[producerConsumer.producers.Count - 1].Status}" + Environment.NewLine);
        }


        private void 自动演示_Click(object sender, EventArgs e)
        {
            SelectSemphore();
            txt_Diary.AppendText("开始自动演示，持续时间15s" + Environment.NewLine);
            // 启动所有生产者
            producerConsumer.StartProducers();
            // 启动所有消费者
            producerConsumer.StartConsumers();

            // 启动定时器
            InitializeAutoDemoTimers();

            // 启动自动演示定时器
            _autoDemoTimer.Start();

            // 启动自动停止定时器（15秒后停止）
            _autoDemoDurationTimer.Start();
        }

        private void 清空缓冲区_Click(object sender, EventArgs e)
        {
            _autoDemoTimer.Stop();
            producerConsumer.Reset();  // 重置生产者消费者状态
        }

        private void 增加消费者_Click(object sender, EventArgs e)
        {
            producerConsumer.CreateConsumer();
            ConsumerView.Rows.Add(producerConsumer.consumers[producerConsumer.consumers.Count - 1].Id,
                producerConsumer.consumers[producerConsumer.consumers.Count - 1].Status);
            txt_Diary.Multiline = true;
            txt_Diary.AppendText($"消费者 {producerConsumer.consumers[producerConsumer.consumers.Count - 1].Id} 已创建，" +
                $"状态{producerConsumer.consumers[producerConsumer.consumers.Count - 1].Status}" + Environment.NewLine);
        }
       

        private void AutoDemoTimer_Tick(object sender, EventArgs e)
        {
            // 随机选择一个生产者和一个消费者进行操作
            int actionChoice = random.Next(0, 2);  // 0表示生产，1表示消费

            if (actionChoice == 0)  // 选择生产
            {
                // 随机选择生产者
                if (producerConsumer.producers.Count > 0)
                {
                    var producer = producerConsumer.producers[random.Next(0, producerConsumer.producers.Count)];
                    producerConsumer.Produce();
                    // 记录日志
                    txt_Diary.AppendText($"生产者 {producer.Id} 生产了产品，状态: {producer.Status}" + Environment.NewLine);
                }
            }
            else  // 选择消费
            {
                // 随机选择消费者
                if (producerConsumer.consumers.Count > 0)
                {
                    var consumer = producerConsumer.consumers[random.Next(0, producerConsumer.consumers.Count)];
                    producerConsumer.Consume();
                    // 记录日志
                    txt_Diary.AppendText($"消费者 {consumer.Id} 消费了产品，状态: {consumer.Status}" + Environment.NewLine);
                }
            }

            // 更新缓冲区视图
            UpdateBufferView();
            tickCount++;
        }

        private void AutoDemoDurationTimer_Tick(object sender, EventArgs e)
        {
            // 停止自动演示
            _autoDemoTimer.Stop();
            _autoDemoDurationTimer.Stop();

            // 停止所有生产者和消费者进程
            producerConsumer.isRunning = false;      
            txt_Diary.AppendText("自动演示结束，所有进程已停止。" + Environment.NewLine);
        }


        private void UpdateBufferView()
        {
            // 清空现有的行
            BufferView.Rows.Clear();

            // 添加新的行，显示缓冲区的内容
            foreach (var product in producerConsumer.buffer)
            {
                // 将每个产品添加到缓冲区视图中
                BufferView.Rows.Add(new object[] { product.productId, product.name });
            }
        }



    }
       

}
