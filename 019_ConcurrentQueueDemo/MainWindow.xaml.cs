using System.Collections.Concurrent;
using System.Windows;

namespace ConcurrentQueueDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ConcurrentQueue<int> IntQueue = [];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintMessage(string msg)
        {
            Dispatcher.BeginInvoke(() =>
            {
                lb.Items.Add(msg);
            });
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintMessage("队列中元素入队**********************");

            Task.Run(() =>
            {
                int value = 0;
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);

                    value += 10;
                    PrintMessage($"队列入队元素：{value}");
                    IntQueue.Enqueue(value);
                }
            });

            Task.Run(() =>
            {
                int va = 0;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(50);
                    va++;
                    PrintMessage($"队列入队元素：{va}");
                    IntQueue.Enqueue(va);
                }
            });
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            PrintMessage("队列中元素出队**********************");
            int count = IntQueue.Count;
            for (int i = 0; i < count; i++)
            {
                if (IntQueue.TryDequeue(out int entity))
                {
                    PrintMessage($"队列出队元素：{entity}");
                }
            }
        }
    }
}