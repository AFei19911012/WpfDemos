using HelixToolkit.Wpf;
using System.Linq;
using System.Windows.Controls;
using TestHelixToolkit.ViewModel;

namespace TestHelixToolkit.UserControls
{
    /// <summary>
    /// ModelViewerDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ModelViewerDemo : UserControl
    {
        private ModelViewerVM MyModelViewrVM { get; set; }

        public ModelViewerDemo()
        {
            InitializeComponent();

            MyModelViewrVM = new ModelViewerVM()
            {
                HViewPort3D = HView3D,
            };
            DataContext = MyModelViewrVM;
        }

        private void MenuItemSize_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            HView3D.ZoomExtents(500);
        }

        private void HView3D_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Viewport3DHelper.HitResult firstHit = HView3D.Viewport.FindHits(e.GetPosition(HView3D)).FirstOrDefault();
            MyModelViewrVM.SelectedObject = firstHit?.Visual;
        }
    }
}