using HelixToolkit.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using TestHelixToolkit.Method;

namespace TestHelixToolkit.UserControls
{
    /// <summary>
    /// OverlayDemo.xaml 的交互逻辑
    /// </summary>
    public partial class OverlayDemo : UserControl
    {
        public OverlayDemo()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            CompositionTarget.Rendering += CompositionTargetRendering;

            const int N = 9;
            for (int i = -N; i <= N; i++)
            {
                for (int j = -N; j <= N; j++)
                {
                    Ellipse circle = new Ellipse { Width = 4, Height = 4, Fill = Brushes.Tomato };
                    TextBlock text = new TextBlock { Text = "(" + i + "," + j + ")" };
                    OverlayMethod.SetPosition3D(circle, new Point3D(i, j, 0));
                    OverlayMethod.SetPosition3D(text, new Point3D(i, j, 0));
                    Canvas_Overlay.Children.Add(circle);
                    Canvas_Overlay.Children.Add(text);
                }
            }

            TextBlock text1 = new TextBlock
            {
                Text = "Hello world!",
                FontWeight = FontWeights.Bold,
                FontSize = 16,
                Foreground = Brushes.YellowGreen,
                Background = Brushes.Gray,
                Padding = new Thickness(4)
            };
            OverlayMethod.SetPosition3D(text1, new Point3D(0, 0, 10));
            Canvas_Overlay.Children.Add(text1);
        }

        private void CompositionTargetRendering(object sender, EventArgs e)
        {
            Matrix3D matrix = Viewport3DHelper.GetTotalTransform(HView3D.Viewport);
            foreach (FrameworkElement element in Canvas_Overlay.Children)
            {
                Point3D position = OverlayMethod.GetPosition3D(element);
                Point3D position2D = matrix.Transform(position);
                Canvas.SetLeft(element, position2D.X - (element.ActualWidth / 2));
                Canvas.SetTop(element, position2D.Y - (element.ActualHeight / 2));
            }
        }
    }
}