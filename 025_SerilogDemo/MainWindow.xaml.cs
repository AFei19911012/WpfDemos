using Serilog;
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
                .MinimumLevel.Debug()
                .WriteTo.File("logs\\log.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}", rollingInterval: RollingInterval.Minute)
                .CreateLogger();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using var log = new LoggerConfiguration()
                .WriteTo.File("logs\\test.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            log.Information("Hello, Serilog!");
            log.Warning("Goodbye, Serilog.");


            Log.Error("WoW");

            Log.CloseAndFlush();
        }
    }
}