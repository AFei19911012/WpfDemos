using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace MvvmLightMessengerDemo
{
    /// <summary>
    /// WinSub.xaml 的交互逻辑
    /// </summary>
    public partial class WinSub : Window
    {
        public WinSub()
        {
            InitializeComponent();

            Messenger.Default.Register<string>(this, "HandlerFromMain", Handler);
        }

        private void Handler(string obj)
        {
            tb.Text = obj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send("来自子窗体的消息", "HandlerFromSub");
        }
    }
}