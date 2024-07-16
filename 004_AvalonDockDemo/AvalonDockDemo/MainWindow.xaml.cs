using AvalonDock.Layout;
using AvalonDock.Layout.Serialization;
using AvalonDock.Themes;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using WffControls.Helper;

namespace AvalonDockDemo
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

        private void ButNew_Click(object sender, RoutedEventArgs e)
        {
            var firstDocumentPane = dockManager.Layout.Descendents().OfType<LayoutDocumentPane>().FirstOrDefault();
            if (firstDocumentPane != null)
            {
                LayoutDocument doc = new LayoutDocument
                {
                    Title = "Test1"
                };
                firstDocumentPane.Children.Add(doc);

                LayoutDocument doc2 = new LayoutDocument
                {
                    Title = "Test2"
                };
                firstDocumentPane.Children.Add(doc2);
            }

            var leftAnchorGroup = dockManager.Layout.LeftSide.Children.FirstOrDefault();
            if (leftAnchorGroup == null)
            {
                leftAnchorGroup = new LayoutAnchorGroup();
                dockManager.Layout.LeftSide.Children.Add(leftAnchorGroup);
            }

            leftAnchorGroup.Children.Add(new LayoutAnchorable() { Title = "New Anchorable" });
        }

        private void ButLoad_Click(object sender, RoutedEventArgs e)
        {
            var currentContentsList = dockManager.Layout.Descendents().OfType<LayoutContent>().Where(c => c.ContentId != null).ToArray();
            var serializer = new XmlLayoutSerializer(dockManager);
            using var stream = new StreamReader("AvalonDock_Demo.config");
            serializer.Deserialize(stream);
        }

        private void ButSave_Click(object sender, RoutedEventArgs e)
        {
            var serializer = new XmlLayoutSerializer(dockManager);
            using var stream = new StreamWriter("AvalonDock_Demo.config");
            serializer.Serialize(stream);
        }

        private void ButTheme_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Content.ToString();
            if (name.Equals("Vs2013DarkTheme"))
            {
                Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/MLib;component/Themes/DarkTheme.xaml");
                dockManager.Theme = new Vs2013DarkTheme();
            }
            else if (name.Equals("Vs2013LightTheme"))
            {
                Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/MLib;component/Themes/LightTheme.xaml");
                dockManager.Theme = new Vs2013LightTheme();
            }
            else
            {
                Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/MLib;component/Themes/LightTheme.xaml");
                dockManager.Theme = new Vs2013BlueTheme();
            }
        }

        private void DockManager_DocumentClosing(object sender, AvalonDock.DocumentClosingEventArgs e)
        {
            var result = DialogHelper.Ask("Are you sure you want to close the document?");
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OnToolWindow1Hiding(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = DialogHelper.Ask("Are you sure you want to hide this tool?");
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OnLayoutRootPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var activeContent = ((LayoutRoot)sender).ActiveContent;
            if (activeContent != null)
            {
                WffControls.Controls.Growl.Info($"ActiveContent-> {activeContent}");
            }
        }
    }
}