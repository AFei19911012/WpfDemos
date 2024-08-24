using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfPlot3DDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            plot3d.Function = Function;
            plot3d.Render();
        }

        private double Function(double x, double y)
        {
            return Math.Sin(x) * Math.Cos(y) / (Math.Sqrt(Math.Sqrt(x * x + y * y)) + 1) * 10;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            plot3d.SetColorSchema(new Plot3D.ColorSchema(slider.Value));
        }

        private void sDensity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            plot3d.SetDensity(sDensity.Value);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton button = (ToggleButton)sender;
            plot3d.ShadingInterp(button.IsChecked == true);
        }

        private void OnGridBrush_Click(object sender, RoutedEventArgs e)
        {
            plot3d.SetPenColor(Color.Transparent);
        }
    }
}