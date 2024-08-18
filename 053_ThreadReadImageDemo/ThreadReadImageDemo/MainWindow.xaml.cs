using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ThreadReadImageDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> Images = [];
        private int Index { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            string imageDirectory = @"D:\MyPrograms\Dataset\sports";
            DirectoryInfo directoryInfo = new DirectoryInfo(imageDirectory);
            FileInfo[] files = directoryInfo.GetFiles("*.ico");
            foreach (FileInfo file in files)
            {
                Images.Add(file.FullName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(100);

                    Dispatcher.Invoke(() =>
                    {
                        img.Source = FileToBitmapImage(Images[Index]);

                        Index++;
                        if (Index == Images.Count)
                        {
                            Index = 0;
                        }
                    });
                }
            });
        }

        private BitmapImage FileToBitmapImage(string filename)
        {
            BitmapImage bmp = new BitmapImage();
            using FileStream fileStream = new FileStream(filename, FileMode.Open);
            bmp.BeginInit();
            bmp.CacheOption = BitmapCacheOption.OnLoad;
            bmp.StreamSource = fileStream;
            bmp.EndInit();
            bmp.Freeze();
            return bmp;
        }
    }
}