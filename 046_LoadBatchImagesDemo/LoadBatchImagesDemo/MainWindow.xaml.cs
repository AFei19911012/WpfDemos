using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace LoadBatchImagesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Uri> Images { get; set; } = [];

        // 用于线程间同步的对象
        private object lockobj = new object();

        public MainWindow()
        {
            InitializeComponent();

            // 设置绑定
            Binding bind = new Binding
            {
                Source = Images,
                IsAsync = true
            };
            lb.SetBinding(ItemsControl.ItemsSourceProperty, bind);

            // 这一句很关键，开启集合的异步访问支持
            BindingOperations.EnableCollectionSynchronization(Images, lockobj);
            Task.Run(() =>
            {
                // 代码写在 lock 块中
                lock (lockobj)
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        Uri u = new Uri("01.png", UriKind.Relative);
                        Images.Add(u);
                    }
                }
            });
        }
    }

    public sealed class UriToBitmapImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Uri uri = (Uri)value;
            BitmapImage bmp = new BitmapImage();
            // 解码高度，或者设置宽度，可减小内存开销
            bmp.DecodePixelHeight = 250; 
            bmp.BeginInit();
            // 延迟，必要时创建
            bmp.CreateOptions = BitmapCreateOptions.DelayCreation;
            bmp.CacheOption = BitmapCacheOption.OnLoad;
            bmp.UriSource = uri;
            bmp.EndInit();
            return bmp;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}