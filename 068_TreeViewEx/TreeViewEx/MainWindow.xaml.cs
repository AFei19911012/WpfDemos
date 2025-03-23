using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Shapes;

namespace TreeViewEx
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectItem = MyTreeView.SelectedValue as TreeViewItem;
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = $"添加子项:{DateTime.Now}";
            if (selectItem != null)
            {
     
                selectItem.Items.Add(treeViewItem);
            }
            else
            {
                MyTreeView.Items.Add(treeViewItem);
            }

            
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem selectItem = MyTreeView.SelectedItem as TreeViewItem;
            if (selectItem != null)
            {
                //selectItem.Parent
                //int  index = MyTreeView.ItemContainerGenerator.IndexFromContainer(selectItem);
                if(selectItem.Parent is TreeView)
                {
                    MyTreeView.Items.Remove(selectItem);
                }
                else
                {
                    var parents = selectItem.Parent as TreeViewItem;
                    parents.Items.Remove(selectItem);
                }
            }

        }
    }

    class TreeViewLineConverter : IMultiValueConverter
    {


        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double height = (double) values[0];

            TreeViewItem item = values[2] as TreeViewItem;
            ItemsControl ic = ItemsControl.ItemsControlFromItemContainer(item);
            bool isLastOne = ic.ItemContainerGenerator.IndexFromContainer(item) == ic.Items.Count - 1;

            Rectangle rectangle = values[3] as Rectangle;
            if (isLastOne)
            {                
                rectangle.VerticalAlignment = VerticalAlignment.Top;
                return 9.0;
            }
            else
            {
                rectangle.VerticalAlignment = VerticalAlignment.Stretch;
                return double.NaN;
            }

           
        }

  

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
