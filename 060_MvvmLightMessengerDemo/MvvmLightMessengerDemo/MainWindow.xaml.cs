using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace MvvmLightMessengerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Messenger.Default.Register<string>(this, "HandlerFromSub", Handler);
        }

        private void Handler(string obj)
        {
            tb.Text = obj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WinSub winSub = new WinSub();
            winSub.Show();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send("来自主窗体的消息", "HandlerFromMain");
        }
    }
}