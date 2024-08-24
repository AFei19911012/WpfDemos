using System.Drawing.Drawing2D;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Brush = System.Windows.Media.Brush;
using Color = System.Drawing.Color;
using Point = System.Windows.Point;

namespace WpfPlot3DDemo.Plot3D
{
    /// <summary>
    /// Plot3DControl.xaml 的交互逻辑
    /// </summary>
    public partial class Plot3DControl : System.Windows.Controls.UserControl
    {
        public delegate double RendererFunction(double x, double y);
        public RendererFunction Function;

        /// <summary>
        /// 图像源
        /// </summary>
        public WriteableBitmap Source
        {
            get { return (WriteableBitmap)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(WriteableBitmap), typeof(Plot3DControl), new PropertyMetadata(default));


        /// <summary>
        /// 用于绘制 3D 图
        /// </summary>
        private Surface3DRenderer surface3DRenderer;

        private Color PenColorPre { get; set; } = Color.Black;

        public Plot3DControl()
        {
            InitializeComponent();

            Loaded += OnLoaded;
            Unloaded += OnUnLoaded;
            SizeChanged += OnSizeChanged;
            Part_Image.MouseDown += OnMouseDown;
            Part_Image.MouseMove += OnMouseMove;
            Part_Image.MouseUp += OnMouseUp;
            Part_Image.MouseWheel += OnMouseWheel;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            surface3DRenderer = new Surface3DRenderer(ActualWidth, ActualHeight);
        }

        private void OnUnLoaded(object sender, RoutedEventArgs e)
        {
            Source = null;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            SetScreenSize(ActualWidth, ActualHeight);
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void OnMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void OnMouseWheel(object sender, MouseWheelEventArgs e)
        {
            
        }

        /// <summary>
        /// 图像自适应
        /// </summary>
        public void SetFullImagePart()
        {
            if (Source != null)
            {
                

            }
        }

        /// <summary>
        /// 绘图
        /// </summary>
        public void Render()
        {
            if (surface3DRenderer == null || ActualWidth * ActualHeight == 0 || Function == null)
            {
                return;
            }
            int width = (int)ActualWidth;
            int height = (int)ActualHeight;
            Source = new WriteableBitmap(width, height, 96, 96, PixelFormats.Bgr24, null);
            Source.Lock();

            var bitmap = new Bitmap(width, height, Source.BackBufferStride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, Source.BackBuffer);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighSpeed;
            g.CompositingQuality = CompositingQuality.HighSpeed;
            // 背景色
            g.Clear(MediaBrushToDrawingColor(Background));

            // 绘图
            surface3DRenderer.Function = (x, y) => Function(x, y);
            surface3DRenderer.RenderSurface(g);

            g.DrawImage(bitmap, 0, 0);
            g.Flush();
            g.Dispose();
            Source.AddDirtyRect(new Int32Rect(0, 0, width, height));
            Source.Unlock();
        }

        #region 设置属性后更新绘图

        public void SetScreenSize(double width, double height)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.ScreenWidth = width;
            surface3DRenderer.ScreenHeight = height;
            surface3DRenderer.CalTransformationsCoeficients();
            Render();
        }

        public void SetCoordinate(double x, double y)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.X0s = x;
            surface3DRenderer.Y0s = y;
            surface3DRenderer.CalTransformationsCoeficients();
            Render();
        }
        
        public void SetScreenDistance(double screenDistance)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.ScreenDistance = screenDistance;
            Render();
        }

        public void SetDensity(double density)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.Density = density;
            Render();
        }

        public void SetPenColor(Color penColor)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.PenColor = penColor;
            Render();
        }

        public void SetStartPoint(PointF startPoint)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.StartPoint = startPoint;
            Render();
        }

        public void SetEndPoint(PointF endPoint)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.EndPoint = endPoint;
            Render();
        }

        public void ShadingInterp(bool flag = true)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            if (flag)
            {
                PenColorPre = surface3DRenderer.PenColor;
                SetPenColor(Color.Transparent);
            }
            else
            {
                SetPenColor(PenColorPre);
            }
        }

        public void SetColorSchema(ColorSchema colorSchema)
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.ColorSchema = colorSchema;
            Render();
        }

        public void CalTransformationsCoeficients()
        {
            if (surface3DRenderer == null)
            {
                return;
            }
            surface3DRenderer.CalTransformationsCoeficients();
        }

        #endregion

        private Color MediaBrushToDrawingColor(Brush brush)
        {
            if (brush is SolidColorBrush)
            {
                var color = (brush as SolidColorBrush).Color;
                return Color.FromArgb(color.R, color.G, color.B);
            }
            else
            {
                return Color.Transparent;
            }
        }
    }
}