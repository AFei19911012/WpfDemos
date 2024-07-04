using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Point = System.Windows.Point;

namespace ImageSelectZoomDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point OriPoint;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OriPoint = e.GetPosition(this);

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var pt = e.GetPosition(this);
            // 假设左上、右下
            var bitmap = BitmapSourceToBitmap((BitmapSource)imgSrc.Source);
            int x = (int)OriPoint.X;
            int y = (int)OriPoint.Y;
            int w = (int)(pt.X - OriPoint.X);
            int h = (int)(pt.Y - OriPoint.Y);
            if (w > 0 && h > 0)
            {
                var bmp = CroppedBitmap(bitmap, x, y, w, h);
                imgDst.Source = BitmapToBitmapImage(bmp);
            }
        }

        private Bitmap BitmapSourceToBitmap(BitmapSource bitmapSource)
        {
            using MemoryStream stream = new MemoryStream();
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
            encoder.Save(stream);
            Bitmap bmp = new Bitmap(stream);
            return bmp;
        }

        private BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            using MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Png);
            BitmapImage result = new BitmapImage();
            result.BeginInit();
            result.StreamSource = ms;
            result.CacheOption = BitmapCacheOption.OnLoad;
            result.EndInit();
            result.Freeze();
            return result;
        }
        private Bitmap CroppedBitmap(Bitmap bitmap, int x, int y, int w, int h)
        {
            return bitmap.Clone(new System.Drawing.Rectangle(x, y, w, h), bitmap.PixelFormat);
        }

    }
}