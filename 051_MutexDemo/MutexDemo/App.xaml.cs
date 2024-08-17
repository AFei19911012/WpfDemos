using System.Diagnostics;
using System.Windows;
using WffControls.Helper;

namespace MutexDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // 创建互斥对象
            var mutex = new Mutex(false, "MutexDemo", out bool IsNewInstans);
            if (!IsNewInstans)
            {
                var result = DialogHelper.Ask("已有相同程序启动，是否关闭旧程序打开新程序？");
                if (result == MessageBoxResult.OK)
                {
                    // 获取指定进程，与当前进程比较，不同则关闭
                    var processes = Process.GetProcessesByName("MutexDemo");
                    foreach (var process in processes)
                    {
                        if (process.Id != Process.GetCurrentProcess().Id)
                        {
                            process.Kill();
                        }
                    }
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    App.Current.Shutdown();
                    Environment.Exit(0);
                    return;
                }
            }

            
        }
    }

}