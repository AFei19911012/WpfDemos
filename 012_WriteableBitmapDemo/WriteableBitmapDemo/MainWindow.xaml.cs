using System.Drawing;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;
using Point = System.Windows.Point;
using Rectangle = System.Drawing.Rectangle;

namespace WriteableBitmapDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WriteableBitmap Source
        {
            get { return (WriteableBitmap)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(WriteableBitmap), typeof(MainWindow), new PropertyMetadata(default));


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int w = (int)Cvs.ActualWidth;
            int h = (int)Cvs.ActualHeight;
            Source = new WriteableBitmap(w, h, 72, 72, System.Windows.Media.PixelFormats.Bgr24, null);

            Source.Lock();
            var bitmap = new Bitmap(w, h, Source.BackBufferStride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, Source.BackBuffer);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.Gray, 0, 0, w, h);
            // 白色背景
            //g.Clear(System.Drawing.Color.White);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    g.FillRectangle((((i + j) % 2 == 0 ? Brushes.White : Brushes.DimGray)), new Rectangle(i * 20, j * 20, 20, 20));
                }
            }

            g.DrawLine(new Pen(Color.Red, 2), new PointF(100, 100), new PointF(400, 150));
            g.DrawBezier(new Pen(Color.Red, 2), 100, 100, 200, 400, 100, 300, 400, 400);

            g.DrawImage(bitmap, 0, 0);
            g.Flush();
            g.Dispose();
            Source.AddDirtyRect(new Int32Rect(0, 0, w, h));
            Source.Unlock();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int w = (int)Cvs.ActualWidth;
            int h = (int)Cvs.ActualHeight;
            Source = new WriteableBitmap(w, h, 72, 72, System.Windows.Media.PixelFormats.Bgr24, null);

            unsafe
            {
                var bytes = (byte*)Source.BackBuffer.ToPointer();
                Source.Lock();

                // 整张画布置为黑色
                for (int i = Source.BackBufferStride * Source.PixelHeight - 1; i >= 0; i--)
                {
                    bytes[i] = 0;
                }

                // 画一些随机的黄点
                Random rand = new Random();
                byte[] c = [0, 255, 255];
                for (int i = 0; i < w * h; i++)
                {
                    int x = rand.Next(w);
                    int y = rand.Next(h);
                    int array_start = y * Source.BackBufferStride + x * 3;

                    //bytes[array_start] = 0;
                    //bytes[array_start + 1] = 255;
                    //bytes[array_start + 2] = 255;

                    Source.WritePixels(new Int32Rect(x, y, 1, 1), c, 3, 0);
                }

                Source.AddDirtyRect(new Int32Rect(0, 0, w, h));
                Source.Unlock();
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int w = (int)Cvs.ActualWidth;
            int h = (int)Cvs.ActualHeight;
            Source = new WriteableBitmap(w, h, 72, 72, System.Windows.Media.PixelFormats.Bgr24, null);

            Source.Lock();
            var bitmap = new Bitmap(w, h, Source.BackBufferStride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, Source.BackBuffer);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillRectangle(Brushes.Gray, 0, 0, w, h);

            DrawCross(g, new Point(100, 100));
            DrawCross(g, new Point(150, 100), 30);
            DrawCross(g, new Point(200, 100), 45);

            g.DrawImage(bitmap, 0, 0);
            g.Flush();
            g.Dispose();
            Source.AddDirtyRect(new Int32Rect(0, 0, w, h));
            Source.Unlock();
        }

        private void DrawCross(Graphics g, Point pt, double angle = 0, double len = 15)
        {
            // 先确定 +x 的十字坐标
            var pt1 = new Point(pt.X - len, pt.Y);
            var pt2 = new Point(pt.X + len, pt.Y);
            var pt3 = new Point(pt.X, pt.Y - len);
            var pt4 = new Point(pt.X, pt.Y + len);
            // 旋转坐标，使用 Matrix
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, pt.X, pt.Y);
            pt1 = matrix.Transform(pt1);
            pt2 = matrix.Transform(pt2);
            pt3 = matrix.Transform(pt3);
            pt4 = matrix.Transform(pt4);

            g.DrawLine(new Pen(Color.Red, 2), new PointF((float)pt1.X, (float)pt1.Y), new PointF((float)pt2.X, (float)pt2.Y));
            g.DrawLine(new Pen(Color.Red, 2), new PointF((float)pt3.X, (float)pt3.Y), new PointF((float)pt4.X, (float)pt4.Y));
        }
    }
}