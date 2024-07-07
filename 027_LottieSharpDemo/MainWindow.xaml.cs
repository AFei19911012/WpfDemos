using System.IO;
using System.Windows;

namespace LottieSharpDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> LottieFileList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            foreach (var item in Directory.EnumerateFiles("Resource"))
            {
                LottieFileList.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PART_Lottie.FileName = LottieFileList[new Random().Next(LottieFileList.Count)];
            PART_Lottie.PlayAnimation();
        }
    }
}