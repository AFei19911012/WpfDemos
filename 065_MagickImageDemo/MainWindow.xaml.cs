using Magick.NET.Samples;
using System.Windows;

namespace MagickImageDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Test();
        }

        private void Test()
        {
            ReadImageSamples.ReadImage();

            CombiningImagesSamples.CreateAnimatedGif();

            LosslessCompressionSamples.MakeGooglePageSpeedInsightsHappy();
        }
    }
}