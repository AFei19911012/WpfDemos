using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomWindowDemo
{
    [TemplatePart(Name = "PART_MIN", Type = typeof(Button))]
    [TemplatePart(Name = "PART_MAX", Type = typeof(Button))]
    [TemplatePart(Name = "PART_NORMAL", Type = typeof(Button))]
    [TemplatePart(Name = "PART_CLOSE", Type = typeof(Button))]
    public class CustomWindow : Window
    {
        #region Methods
        static CustomWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomWindow), new FrameworkPropertyMetadata(typeof(CustomWindow)));
        }

        public override void OnApplyTemplate()
        {
            (this.GetTemplateChild("PART_MIN") as Button).Click += (sender, e) => this.WindowState = WindowState.Minimized;
            (this.GetTemplateChild("PART_MAX") as Button).Click += (sender, e) => this.WindowState = WindowState.Maximized;
            (this.GetTemplateChild("PART_NORMAL") as Button).Click += (sender, e) => this.WindowState = WindowState.Normal;
            (this.GetTemplateChild("PART_CLOSE") as Button).Click += (sender, e) => this.Close();
            base.OnApplyTemplate();
        }
        #endregion

        #region Properties
        /// <summary>
        /// 获取或设置标题栏高度
        /// </summary>
        public double CaptionHeight
        {
            get { return (double)GetValue(CaptionHeightProperty); }
            set { SetValue(CaptionHeightProperty, value); }
        }

        public static readonly DependencyProperty CaptionHeightProperty =
            DependencyProperty.Register("CaptionHeight", typeof(double), typeof(CustomWindow), new PropertyMetadata(60d));

        /// <summary>
        /// 获取或设置标题栏背景
        /// </summary>
        public Brush CaptionBackground
        {
            get { return (Brush)GetValue(CaptionBackgroundProperty); }
            set { SetValue(CaptionBackgroundProperty, value); }
        }

        public static readonly DependencyProperty CaptionBackgroundProperty =
            DependencyProperty.Register("CaptionBackground", typeof(Brush), typeof(CustomWindow), new PropertyMetadata(Brushes.DodgerBlue));


        /// <summary>
        /// 获取或设置标题栏内容
        /// </summary>
        public object CaptionBarContent
        {
            get { return (object)GetValue(CaptionBarContentProperty); }
            set { SetValue(CaptionBarContentProperty, value); }
        }

        public static readonly DependencyProperty CaptionBarContentProperty =
            DependencyProperty.Register("CaptionBarContent", typeof(object), typeof(CustomWindow));
        #endregion
    }
}
