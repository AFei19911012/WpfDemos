using System.Windows;

namespace SuperDogDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string info = SuperDog3160698.CheckSuperDog();
            MessageBox.Show(info);
        }

        private void ButtonDog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run without dog !!!");
        }
    }
}
