using Serilog;
using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace SerilogDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.File("logs\\log.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}", rollingInterval: RollingInterval.Minute)
                .CreateLogger();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using var log = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs\\test.txt", rollingInterval: RollingInterval.Day,
                                                fileSizeLimitBytes: 1024 * 1024 * 1024,
                                                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            log.Information("Hello, Serilog!");
            log.Warning("Goodbye, Serilog.");
            log.Error("Goodbye, Serilog.");
            log.Debug("Goodbye, Serilog.");

            log.Debug(GetMethod());

            log.Debug(GetCallerMethodName() + " 测试");
        }

        private string GetCallerMethodName()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            if (stackFrame != null)
            {
                return stackFrame.GetMethod().Name;
            }
            return "NA";
        }

        private string GetMethod(string msg = "")
        {
            return $"{GetCallerMethodName()}: {msg}";
        }
    }
}