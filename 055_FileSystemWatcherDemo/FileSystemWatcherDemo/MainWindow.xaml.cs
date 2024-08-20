using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileSystemWatcherDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileSystemWatcher FileWatcher { get; set; }
        private string Filepath { get; set; } = @"D:\Users\王多鱼\Desktop\1";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnStart(object sender, RoutedEventArgs e)
        {
            FileWatcher = new FileSystemWatcher()
            {
                Path = Filepath,
                // 所有文件
                Filter = "*.*",
            };
            // 监听新增文件
            FileWatcher.Created += new FileSystemEventHandler(OnProcess);
            FileWatcher.Deleted += new FileSystemEventHandler(OnProcess);
            FileWatcher.Changed += new FileSystemEventHandler(OnProcess);
            FileWatcher.Renamed += new RenamedEventHandler(OnProcess);
            // 是否让监控事件生效
            FileWatcher.EnableRaisingEvents = true;
            //FileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess| NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            FileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size;
            // 包含子文件夹
            FileWatcher.IncludeSubdirectories = true;

            lb.Items.Add("启动监听");
        }

        private void OnProcess(object sender, FileSystemEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                if (e.ChangeType == WatcherChangeTypes.Created)
                {
                    lb.Items.Add("新增文件：" + e.FullPath);
                }
                else if (e.ChangeType == WatcherChangeTypes.Deleted)
                {
                    lb.Items.Add("删除文件：" + e.FullPath);
                }
                else if (e.ChangeType == WatcherChangeTypes.Renamed)
                {
                    lb.Items.Add("重命名文件：" + e.FullPath);
                }
                else if (e.ChangeType == WatcherChangeTypes.Changed)
                {
                    lb.Items.Add("修改文件：" + e.FullPath);
                }
            });
        }

        private void OnStop(object sender, RoutedEventArgs e)
        {
            FileWatcher.EnableRaisingEvents = false;
            lb.Items.Add("停止监听");
        }
    }
}