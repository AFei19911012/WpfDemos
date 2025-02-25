using SkiaSharp;
using SkiaSharp.Views.WPF;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkiaSharpDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnDraw_Click(object sender, RoutedEventArgs e)
        {
            var writeableBitmap = new WriteableBitmap(1920, 1080, 96, 96, PixelFormats.Bgra32, BitmapPalettes.Halftone256Transparent);
            int width = (int)writeableBitmap.Width;
            int height = (int)writeableBitmap.Height;
            writeableBitmap.Lock();
            var skImageInfo = new SKImageInfo()
            {
                Width = width,
                Height = height,
                ColorType = SKColorType.Bgra8888,
                AlphaType = SKAlphaType.Premul,
                ColorSpace = SKColorSpace.CreateSrgb()
            };

            using (SKSurface surface = SKSurface.Create(skImageInfo, writeableBitmap.BackBuffer))
            {
                SKCanvas canvas = surface.Canvas;
                canvas.Clear(new SKColor(130, 130, 130));


                SKPaint paint = new()
                {
                    Color = new SKColor(0, 0, 0)
                };
                SKFont font = new()
                {
                    Size = 100
                };
                canvas.DrawText("SkiaSharp on Wpf!", 50, 500, font, paint);
            }
            writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, width, height));
            writeableBitmap.Unlock();

            img.Source = writeableBitmap;
        }

        private void OnMontage_Click(object sender, RoutedEventArgs e)
        {
            // 设定切片的数量和排列
            int rows = 2;
            int cols = 2;

            // 每个小图像的大小
            int tileWidth = 200;
            int tileHeight = 200;

            // 创建一个目标图像来容纳拼接后的图像
            int totalWidth = tileWidth * cols;
            int totalHeight = tileHeight * rows;

            // 创建一个 SKBitmap 作为拼接后的图像
            using SKBitmap resultBitmap = new SKBitmap(totalWidth, totalHeight);
            using SKCanvas canvas = new SKCanvas(resultBitmap);
            // 设定背景颜色
            canvas.Clear(SKColors.White);

            // 加载并绘制每个小图像
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // 加载每个切片图像
                    string imagePath = $"images\\tile{row * cols + col + 1}.ico";
                    using SKBitmap tileBitmap = SKBitmap.Decode(imagePath);
                    // 计算当前切片的绘制位置
                    int x = col * tileWidth;
                    int y = row * tileHeight;
                    // 将切片绘制到目标图像上
                    canvas.DrawBitmap(tileBitmap, x, y);
                }
            }

            img.Source = resultBitmap.ToWriteableBitmap();

            // 保存拼接后的图像到文件
            using SKImage finalImage = SKImage.FromBitmap(resultBitmap);
            using SKData data = finalImage.Encode(SKEncodedImageFormat.Png, 100);
            using FileStream fs = new(@"images\puzzle.png", FileMode.Create);
            data.SaveTo(fs);
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var canvas = e.Surface.Canvas;
            canvas.Clear(SKColors.White);

            using var paint = new SKPaint
            {
                Color = SKColors.Black,
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            using var font = new SKFont
            {
                Size = 24
            };
            var coord = new SKPoint(e.Info.Width / 2, (e.Info.Height + font.Size) / 2);
            canvas.DrawText("SkiaSharp", coord, SKTextAlign.Center, font, paint);
        }
    }
}