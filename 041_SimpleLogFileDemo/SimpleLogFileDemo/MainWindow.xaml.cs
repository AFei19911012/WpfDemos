using SoftCircuits.SimpleLogFile;
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

namespace SimpleLogFileDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            string filename = "log.txt";
            LogFile logFile = new LogFile(filename);

            // Log entries with different importance, or 'levels'
            logFile.LogInfo("An information-level log entry");
            logFile.LogWarning("A warning-level log entry");
            logFile.LogError("An error-level log entry");
            logFile.LogCritical("A critical-level log entry");

            // A divider helps separate groups of log entries
            logFile.LogDivider();

            // An entry can include any number of objects
            logFile.LogError("An error-level log entry", 12345, 'n', "Error");

            // The library has special handling for formatting exceptions. LogFile properties control
            // whether inner exceptions are written, and whether the name of the exception type
            // includes the namespace.
            logFile.LogError("This parameter is required", new ArgumentNullException("parameterName"));

            // And you can log formatted entries
            logFile.LogErrorFormat("Expected {0} items, but found {1} items", 25, 26);


            // 日志等级
            logFile.LogLevel = LogLevel.Warning;

            // This entry will not be written because LogLevel.Info is a lower level than LogLevel.Warning
            logFile.LogInfo("This is an information-level entry");

            // This entry will be written because LogLevel.Error is a higher level than LogLevel.Warning
            logFile.LogError("This is an error-level entry");

            logFile.LogLevel = LogLevel.None;

            // Now even a critical log entry will not be written
            logFile.LogCritical("This is an error-level entry");

            // These two lines are equivalent
            logFile.LogError("An error-level log entry");
            logFile.Log(LogLevel.Error, "An error-level log entry");


            // 异常
            // Create an exception with inner exceptions
            Exception ex = new ArgumentNullException("parameterName");
            ex = new InvalidOperationException("Unable to do that", ex);
            ex = new InvalidDataException("Unable to do this", ex);
            ex = new InvalidProgramException("There was a problem!", ex);

            // No inner exceptions logged here
            logFile.LogError("Something went wrong", ex);

            // Now log inner exceptions
            logFile.LogInnerExceptions = true;
            logFile.LogError("Something went wrong", ex);


            // 删除
            //logFile.Delete();
        }
    }
}