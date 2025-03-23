/*
 *  主要参考：https://blog.csdn.net/lhx527099095/article/details/8061169/ 
 */

namespace TreeDemo.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Media;

    public class TreeGrid : TreeView
    {
        static TreeGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeGrid), new FrameworkPropertyMetadata(typeof(TreeGrid)));
        }

        #region ColumnMappings DependencyProperty
        public string ColumnMappings
        {
            get { return (string)GetValue(ColumnMappingsProperty); }
            set { SetValue(ColumnMappingsProperty, value); }
        }
        public static readonly DependencyProperty ColumnMappingsProperty =
                DependencyProperty.Register("ColumnMappings", typeof(string), typeof(TreeGrid),
                new PropertyMetadata("", new PropertyChangedCallback(TreeGrid.OnColumnMappingsPropertyChanged)));

        private static void OnColumnMappingsPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeGrid)
            {
                (obj as TreeGrid).OnColumnMappingsValueChanged();
            }
        }

        protected void OnColumnMappingsValueChanged()
        {
            if (!string.IsNullOrEmpty(ColumnMappings))
            {
                ResetMappingColumns(ColumnMappings);
            }
        }

        private void ResetMappingColumns(string mapping)
        {
            GridViewColumnCollection items = new GridViewColumnCollection();
            var columns = mapping.Split(new char[] { ';', '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var c in columns)
            {
                var index = c.IndexOf(':');
                var title = "";
                var name = "";
                if (index > 0)
                {
                    title = c.Substring(0, index);
                    name = c.Substring(index + 1);
                }
                else
                {
                    title = c;
                    name = c;
                }

                DataTemplate temp = null;
                var res = this.FindTreeResource<DataTemplate>(name);
                if (res != null && res is DataTemplate template)
                {
                    temp = template;
                }
                else
                {
                    temp = new DataTemplate();
                    FrameworkElementFactory element = null;
                    if (items.Count == 0)
                    {
                        element = new FrameworkElementFactory(typeof(TreeItemContentControl));
                        element.SetValue(ContentControl.ContentProperty, new Binding(name));
                    }
                    else
                    {
                        element = new FrameworkElementFactory(typeof(TreeGridCell));
                        element.SetValue(ContentControl.ContentProperty, new Binding(name));
                    }
                    temp.VisualTree = element;
                }
                var col = new GridViewColumn
                {
                    Header = title,
                    CellTemplate = temp,
                };
                items.Add(col);
            }
            Columns = items;
        }
        #endregion

        #region Columns DependencyProperty
        public GridViewColumnCollection Columns
        {
            get { return (GridViewColumnCollection)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }
        public static readonly DependencyProperty ColumnsProperty =
                DependencyProperty.Register("Columns", typeof(GridViewColumnCollection), typeof(TreeGrid),
                new PropertyMetadata(null, new PropertyChangedCallback(TreeGrid.OnColumnsPropertyChanged)));

        private static void OnColumnsPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeGrid)
            {
                (obj as TreeGrid).OnColumnsValueChanged();
            }
        }

        protected void OnColumnsValueChanged()
        {

        }
        #endregion

        #region RowHeight DependencyProperty
        public double RowHeight
        {
            get { return (double)GetValue(RowHeightProperty); }
            set { SetValue(RowHeightProperty, value); }
        }
        public static readonly DependencyProperty RowHeightProperty =
                DependencyProperty.Register("RowHeight", typeof(double), typeof(TreeGrid),
                new PropertyMetadata(30.0, new PropertyChangedCallback(TreeGrid.OnRowHeightPropertyChanged)));

        private static void OnRowHeightPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeGrid)
            {
                (obj as TreeGrid).OnRowHeightValueChanged();
            }
        }

        protected void OnRowHeightValueChanged()
        {

        }
        #endregion

        #region ShowCellBorder DependencyProperty
        public bool ShowCellBorder
        {
            get { return (bool)GetValue(ShowCellBorderProperty); }
            set { SetValue(ShowCellBorderProperty, value); }
        }
        public static readonly DependencyProperty ShowCellBorderProperty =
                DependencyProperty.Register("ShowCellBorder", typeof(bool), typeof(TreeGrid),
                new PropertyMetadata(false, new PropertyChangedCallback(TreeGrid.OnShowCellBorderPropertyChanged)));

        private static void OnShowCellBorderPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeGrid)
            {
                (obj as TreeGrid).OnShowCellBorderValueChanged();
            }
        }

        protected void OnShowCellBorderValueChanged()
        {

        }
        #endregion

        #region IconStroke DependencyProperty
        public Brush IconStroke
        {
            get { return (Brush)GetValue(IconStrokeProperty); }
            set { SetValue(IconStrokeProperty, value); }
        }
        public static readonly DependencyProperty IconStrokeProperty =
                DependencyProperty.Register("IconStroke", typeof(Brush), typeof(TreeGrid),
                new PropertyMetadata(new SolidColorBrush(Colors.LightGray), new PropertyChangedCallback(TreeGrid.OnIconStrokePropertyChanged)));

        private static void OnIconStrokePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeGrid)
            {
                (obj as TreeGrid).OnIconStrokeValueChanged();
            }
        }

        protected void OnIconStrokeValueChanged()
        {

        }
        #endregion

        #region CellBorderBrush DependencyProperty
        public Brush CellBorderBrush
        {
            get { return (Brush)GetValue(CellBorderBrushProperty); }
            set { SetValue(CellBorderBrushProperty, value); }
        }
        public static readonly DependencyProperty CellBorderBrushProperty =
                DependencyProperty.Register("CellBorderBrush", typeof(Brush), typeof(TreeGrid),
                new PropertyMetadata(new SolidColorBrush(Colors.LightGray), new PropertyChangedCallback(TreeGrid.OnCellBorderBrushPropertyChanged)));

        private static void OnCellBorderBrushPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeGrid)
            {
                (obj as TreeGrid).OnCellBorderBrushValueChanged();
            }
        }

        protected void OnCellBorderBrushValueChanged()
        {

        }
        #endregion

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeGridItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TreeGridItem;
        }

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnItemsChanged(e);
        }
    }

    public class TreeGridItem : TreeViewItem
    {
        public event EventHandler IconStateChanged;
        static TreeGridItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeGridItem), new FrameworkPropertyMetadata(typeof(TreeGridItem)));
        }

        public TreeGridItem()
        {
            this.DataContextChanged += TreeGridItem_DataContextChanged;
        }

        private void TreeGridItem_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext != null && DataContext is TreeItemData treeData)
            {
                this.SetBinding(IsExpandedProperty, new Binding("IsExpanded") { Source = treeData, Mode = BindingMode.TwoWay });
            }
        }

        protected override void OnVisualParentChanged(DependencyObject oldParent)
        {
            base.OnVisualParentChanged(oldParent);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeGridItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TreeGridItem;
        }
    }

    /*
     * https://referencesource.microsoft.com/#PresentationFramework/src/Framework/System/Windows/Controls/GridViewRowPresenter.cs,ace7d38fc902993d
     * GridViewRow里的每个元素，增加了一个默认的Margin，这样在设置边框的时候会比较麻烦，在运行时去掉
     */
    public class TreeGridCell : ContentControl
    {
        static TreeGridCell()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeGridCell), new FrameworkPropertyMetadata(typeof(TreeGridCell)));
        }

        public TreeGridCell()
        {
            Loaded += TreeGridCell_Loaded;
        }

        private void TreeGridCell_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= TreeGridCell_Loaded;
            var p = VisualTreeHelper.GetParent(this);
            if (p != null && p is FrameworkElement f && f.Margin.Left > 0)
            {
                f.Margin = new Thickness(0);
            }
        }
    }

    public static class TreeHelper
    {
        public static T FindParent<T>(this DependencyObject obj)
        {
            var p = VisualTreeHelper.GetParent(obj);
            if (p == null)
            {
                return default(T);
            }
            if (p is T tt)
            {
                return tt;
            }
            return FindParent<T>(p);
        }

        public static IEnumerable<T> FindChild<T>(this DependencyObject obj) where T : DependencyObject
        {
            if (obj == null)
            {
                yield break;
            }
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child == null)
                {
                    continue;
                }
                if (child is T)
                {
                    yield return (T)child;
                }
                else
                {
                    foreach (var c in FindChild<T>(child))
                    {
                        yield return c;
                    }
                }
            }
        }

        public static T FindTreeResource<T>(this FrameworkElement obj, string key)
        {
            if (obj == null)
            {
                return default(T);
            }
            var r = obj.TryFindResource(key);
            if (r == null)
            {
                r = Application.Current.TryFindResource(key);
            }
            if (r != null && r is T t)
            {
                return t;
            }

            var p = FindParent<FrameworkElement>(obj);
            if (p != null)
            {
                return FindTreeResource<T>(p, key);
            }
            return default(T);
        }
    }

    public class LevelToMarginConverter : IValueConverter
    {
        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            return new Thickness((int)o * c_IndentSize, 0, 0, 0);
        }

        public object ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        private const double c_IndentSize = 15.0;
    }
}
