using System.Diagnostics;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace WpfTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 适用于 WPF 中需要和 UI 线程交互的场景
            InitDispatcherTimer();

            // 适用于需要在一定时间间隔内重复执行任务的场景，如定时数据采集、日志记录等
            TimersTimer();

            // 适用于需要在一定时间间隔内执行任务，但不需要与UI线程交互的场景，如后台任务的调度
            InitThreadingTimer();

            // 可以比较方便地使用异步方式，消除了使用 callback 的机制，减少了使用的复杂度
            InitPeriodicTimerAsync();
        }

        private void InitDispatcherTimer()
        {
            // 创建定时器，每秒触发一次
            DispatcherTimer dispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            dispatcherTimer.Tick += TimerTick;
            // 启动定时器
            dispatcherTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // 在UI线程中更新UI
            lbl1.Content = "定时器触发时间：" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void TimersTimer()
        {
            // 创建定时器，每秒触发一次
            System.Timers.Timer timer = new System.Timers.Timer(1000);

            // 定时器触发事件
            timer.Elapsed += TimerElapsed;

            // 启动定时器
            timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Debug.WriteLine("TimersTimer 定时器触发时间：" + e.SignalTime);
        }

        private void InitThreadingTimer()
        {
            System.Threading.Timer timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
        }

        private void TimerCallback(object state)
        {
            Debug.WriteLine("ThreadingTimer 定时器触发时间：" + DateTime.Now);
        }

        private static async void InitPeriodicTimerAsync()
        {
            // 定时器触发事件
            using var cts = new CancellationTokenSource();
            cts.CancelAfter(TimeSpan.FromSeconds(10));
            // 创建定时器，每秒触发一次
            using PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(1));           
            try
            {
                while (await timer.WaitForNextTickAsync(cts.Token))
                //while (await timer.WaitForNextTickAsync())
                {
                    await Task.Delay(5000);
                    Debug.WriteLine($"Timed event triggered({DateTime.Now:HH:mm:ss})");
                }
            }
            catch (OperationCanceledException)
            {
                Debug.WriteLine("Operation cancelled");
            }
        }
    }
}