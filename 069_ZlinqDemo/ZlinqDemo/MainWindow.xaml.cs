using System.Windows;
using ZLinq;

namespace ZlinqDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            var source = new int[] { 1, 2, 3, 4, 5 };

            // Call AsValueEnumerable to apply ZLinq
            var seq1 = source.AsValueEnumerable().Where(x => x % 2 == 0);

        }
    }
}