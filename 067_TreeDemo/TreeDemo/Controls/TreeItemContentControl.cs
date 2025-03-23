using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TreeDemo.Controls
{
    public class TreeItemContentControl : ContentControl
    {
        static TreeItemContentControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeItemContentControl), new FrameworkPropertyMetadata(typeof(TreeItemContentControl)));
        }

        public TreeItemContentControl()
        {
            this.Loaded += TreeItemContentControl_Loaded;
        }

        private void TreeItemContentControl_Loaded(object sender, RoutedEventArgs e)
        { 
            Loaded -= TreeItemContentControl_Loaded;
            var p = VisualTreeHelper.GetParent(this);
            if (p != null && p is FrameworkElement f)
            {
                f.Margin = new Thickness(0);

                if(p is ContentPresenter cp)
                {
                    
                }
            }
        }

        #region TreeData DependencyProperty
        public TreeItemData TreeData
        {
            get { return (TreeItemData)GetValue(TreeDataProperty); }
            set { SetValue(TreeDataProperty, value); }
        }
        public static readonly DependencyProperty TreeDataProperty =
                DependencyProperty.Register("TreeData", typeof(TreeItemData), typeof(TreeItemContentControl),
                new PropertyMetadata(null, new PropertyChangedCallback(TreeItemContentControl.OnTreeDataPropertyChanged)));

        private static void OnTreeDataPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeItemContentControl)
            {
                (obj as TreeItemContentControl).OnTreeDataValueChanged();
            }
        }

        protected void OnTreeDataValueChanged()
        {

        }
        #endregion

        #region LevelIndentSize DependencyProperty
        public int LevelIndentSize
        {
            get { return (int)GetValue(LevelIndentSizeProperty); }
            set { SetValue(LevelIndentSizeProperty, value); }
        }
        public static readonly DependencyProperty LevelIndentSizeProperty =
                DependencyProperty.Register("LevelIndentSize", typeof(int), typeof(TreeItemContentControl),
                new PropertyMetadata(30, new PropertyChangedCallback(TreeItemContentControl.OnLevelIndentSizePropertyChanged)));

        private static void OnLevelIndentSizePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeItemContentControl)
            {
                (obj as TreeItemContentControl).OnLevelIndentSizeValueChanged();
            }
        }

        protected void OnLevelIndentSizeValueChanged()
        {

        }
        #endregion

        #region IconLineStroke DependencyProperty
        public Brush IconLineStroke
        {
            get { return (Brush)GetValue(IconLineStrokeProperty); }
            set { SetValue(IconLineStrokeProperty, value); }
        }
        public static readonly DependencyProperty IconLineStrokeProperty =
                DependencyProperty.Register("IconLineStroke", typeof(Brush), typeof(TreeItemContentControl),
                new PropertyMetadata(new SolidColorBrush(Colors.Blue), new PropertyChangedCallback(TreeItemContentControl.OnIconLineStrokePropertyChanged)));

        private static void OnIconLineStrokePropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is TreeItemContentControl)
            {
                (obj as TreeItemContentControl).OnIconLineStrokeValueChanged();
            }
        }

        protected void OnIconLineStrokeValueChanged()
        {

        }
        #endregion
    }
}
