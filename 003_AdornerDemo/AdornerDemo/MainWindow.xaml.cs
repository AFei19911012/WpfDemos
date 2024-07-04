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

namespace AdornerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Index { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.AddItem(new Point(100, 20), $"Text {Index++:D2}", true);
        }

        /// <summary>
        /// 对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.SetItemsAlignment();
        }

        /// <summary>
        /// 清除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.ClearItems();
        }

        /// <summary>
        /// 锁定/解锁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.SetItemsLocked();
        }

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.InsertItem(1);
        }

        /// <summary>
        /// 设置尺寸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.SetItemSize();
        }

        /// <summary>
        /// 自适应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            MyDragCanvas.FitItems();
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 500; i++)
            {
                MyDragCanvas.AddItem(new Point(100, 20), $"Text {i:D3}", true);
            }
        }
    }
}
