using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatrixRainDemo
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

        private void OnStartRain(object sender, RoutedEventArgs e)
        {
            mRain.Start();
        }

        private void OnStopRain(object sender, RoutedEventArgs e)
        {
            mRain.Stop();
        }

        private void OnSetColor(object sender, RoutedEventArgs e)
        {
            mRain.SetParameter(textBrush: ((Button)sender).Background);
        }

        private void OnSetFont(object sender, RoutedEventArgs e)
        {
            FontFamily rfam = new FontFamily(new Uri("pack://application:,,,"), "./#Matrix Code NFI");
            mRain.SetParameter(fontFamily: rfam);
        }
    }
}