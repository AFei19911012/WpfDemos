using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomWindowDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button btn && btn.CommandParameter != null)
            {
                string v = btn.CommandParameter.ToString();
                switch (v)
                {
                    case "1":
                        this.ResizeMode = ResizeMode.CanMinimize;
                        break;
                    case "2":
                        this.ResizeMode = ResizeMode.NoResize;
                        break;
                    case "3":
                        this.ResizeMode = ResizeMode.CanResize;
                        break;
                    case "4":
                        this.CaptionBarContent = this.Resources["CustomCaptionBar"];
                        break;
                    case "5":
                        this.Style = this.FindResource("CustomWindowStyle") as Style;
                        btn.Content = "默认Window模板";
                        btn.CommandParameter = "6";
                        break;
                    case "6":
                        this.Style = null;
                        btn.Content = "自定义Window模板";
                        btn.CommandParameter = "5";
                        break;
                }
            }
        }
    }
}
