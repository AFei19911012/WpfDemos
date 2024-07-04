using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;

namespace ImageViewerDemo
{
    [TemplatePart(Name = elementName, Type = typeof(Image))]
    public class ImageViewer : Control
    {
        const string elementName = "Part_Image";
        Image? img;
        Canvas? canvas;
        private MatrixTransform tranformer { get; set; }                 // 变形器

        private Point geometryCenter { get; set; }                       // img的几何中心
        Point moveStart;
        Point rotateStart;
        bool mouseDown;
        bool executable;   // 命令是否能执

        #region 依赖属性

        internal static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
            "Source", typeof(BitmapSource), typeof(ImageViewer), new PropertyMetadata(null));

        /// <summary>
        /// 图片的源
        /// </summary>
        public BitmapSource Source
        {
            get => (BitmapSource)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }
        #endregion

        static ImageViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageViewer), new FrameworkPropertyMetadata(typeof(ImageViewer)));
        }


        public ImageViewer()
        {
            // 注册命令
            CommandBindings.Add(new CommandBinding(TransformCommands.MoveUp, OnMoveUp));
            CommandBindings.Add(new CommandBinding(TransformCommands.MoveDown, OnMoveDown));
            CommandBindings.Add(new CommandBinding(TransformCommands.MoveLeft, OnMoveLeft));
            CommandBindings.Add(new CommandBinding(TransformCommands.MoveRight, OnMoveRight));
            CommandBindings.Add(new CommandBinding(TransformCommands.RotateLeft, OnRotateLeft));
            CommandBindings.Add(new CommandBinding(TransformCommands.RotateRight, OnRotateRight));
            CommandBindings.Add(new CommandBinding(TransformCommands.Enlarge, OnEnlarge));
            CommandBindings.Add(new CommandBinding(TransformCommands.Reduce, OnReduce));
            CommandBindings.Add(new CommandBinding(TransformCommands.FlipX, OnFlipX));
            CommandBindings.Add(new CommandBinding(TransformCommands.FlipY, OnFlipY));
            CommandBindings.Add(new CommandBinding(TransformCommands.Reset, OnReset));
        }
        #region 命令：对基础方法的调用

        // 向上移动20
        private void OnMoveUp(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoMove(0, -20);
        }

        // 向下移动20
        private void OnMoveDown(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoMove(0, 20);
        }

        // 向左移动20
        private void OnMoveLeft(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoMove(-20, 0);
        }

        // 向右移动20
        private void OnMoveRight(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoMove(20, 0);
        }

        // 向左旋转90°
        private void OnRotateLeft(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoRotate(-90);
        }

        // 向右旋转90°
        private void OnRotateRight(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoRotate(90);
        }

        // 放大0.2倍
        private void OnEnlarge(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoScale(true);
        }


        // 缩小0.2倍
        private void OnReduce(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoScale(false);
        }


        // 垂直翻转命令
        private void OnFlipY(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoVerFlip();
        }


        // 水平翻转命令
        private void OnFlipX(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoHorFlip();
        }


        // 重置
        private void OnReset(object sender, ExecutedRoutedEventArgs e)
        {
            if (executable) DoReset();
        }

        #endregion


        #region 基础方法：平移、缩放、旋转

        /// <summary>
        /// 移动图片
        /// </summary>
        /// <param name="deltaX">水平方向增量</param>
        /// <param name="deltaY">垂直方向增量</param>
        private void DoMove(double deltaX, double deltaY)
        {
            Vector v = new Vector(deltaX, deltaY);
            DoMove(v);
        }

        /// <summary>
        /// 移动图片
        /// </summary>
        /// <param name="vector">移动的向量</param>
        private void DoMove(Vector vector)
        {
            Matrix temp = tranformer.Matrix;
            Vector moveReal = temp.Transform(vector);           // 将相对于图片原始坐标的向量，变换为经过变换的向量，其实就是考虑到了旋转、翻转的情况
            temp.Translate(moveReal.X, moveReal.Y);
            tranformer.Matrix = temp;
        }

        /// <summary>
        /// 缩放元素：以几何中心点为缩放中心点。
        /// 最小缩放0.2倍，最大30倍
        /// </summary>
        /// <param name="delta">缩放倍率的增量</param>
        private void DoScale(bool enlarge)
        {
            DoScale(enlarge, geometryCenter);
        }

        /// <summary>
        /// 缩放元素
        /// </summary>
        /// <param name="delta">缩放倍率</param>
        /// <param name="center">缩放的中心点。这个中心点就是e.GetPosition(img)获取到的点</param>
        private void DoScale(bool enlarge, Point center)
        {
            Matrix temp = tranformer.Matrix;
            Point centerReal = temp.Transform(center);　　　　// 将相对于img原始坐标的点，变换成现状坐标系的点（鼠标在屏幕中的位置）

            if (Math.Abs(temp.M11) < 0.2)
            {
                if (enlarge)
                {
                    temp.ScaleAt(1.1, 1.1, centerReal.X, centerReal.Y);
                }
            }
            else if (Math.Abs(temp.M11) > 50)
            {
                if (!enlarge)
                {
                    temp.ScaleAt(0.9, 0.9, centerReal.X, centerReal.Y);
                }
            }
            else
            {
                if (enlarge)
                {
                    temp.ScaleAt(1.1, 1.1, centerReal.X, centerReal.Y);
                }
                else
                {
                    temp.ScaleAt(0.9, 0.9, centerReal.X, centerReal.Y);
                }
            }
            tranformer.Matrix = temp;
        }

        /// <summary>
        /// 旋转元素：以几何中心点为旋转中心点
        /// </summary>
        /// <param name="angle">旋转的角度增量</param>
        private void DoRotate(double angle)
        {
            DoRotate(angle, geometryCenter);
        }

        /// <summary>
        /// 旋转元素
        /// </summary>
        /// <param name="angle">旋转的角度增量</param>
        /// <param name="center">旋转的中心点</param>
        private void DoRotate(double angle, Point center)
        {
            Matrix temp = tranformer.Matrix;
            Point centerReal = temp.Transform(center);
            temp.RotateAt(angle, centerReal.X, centerReal.Y);
            tranformer.Matrix = temp;
        }

        /// <summary>
        /// 水平翻转：以元素的几何中心为中心点水平翻转
        /// </summary>
        private void DoHorFlip()
        {
            Matrix temp = tranformer.Matrix;
            temp.M11 *= -1;
            temp.M21 *= -1;
            temp.OffsetX = img.ActualWidth - temp.OffsetX;　　// 以几何中心为原点，沿Y轴翻转
            tranformer.Matrix = temp;
        }

        /// <summary>
        /// 垂直翻转：以元素的几何中心为中心点垂直翻转
        /// </summary>
        private void DoVerFlip()
        {
            Matrix temp = tranformer.Matrix;
            temp.M12 *= -1;
            temp.M22 *= -1;
            temp.OffsetY = img.ActualHeight - temp.OffsetY;　　　　// 以几何中心为原点，沿X轴翻转
            tranformer.Matrix = temp;
        }

        /// <summary>
        /// 重置
        /// </summary>
        private void DoReset()
        {
            tranformer.Matrix = new Matrix();

            if (canvas != null && img != null)
            {
                double ratio1 = canvas.ActualWidth / img.ActualWidth;
                double ratio2 = canvas.ActualHeight / img.ActualHeight;
                double ratio = Math.Min(ratio1, ratio2);
                // 偏移
                double dx = 0.5 * (canvas.ActualWidth - ratio * img.ActualWidth);
                double dy = 0.5 * (canvas.ActualHeight - ratio * img.ActualHeight);
                // 缩放
                Matrix matrix = new Matrix();
                matrix.Scale(ratio, ratio);
                matrix.Translate(dx, dy);
                tranformer.Matrix = matrix;
            }
        }


        #endregion


        // 设置模板
        public override void OnApplyTemplate()
        {
            executable = false;
            if (img != null)
            {
                tranformer = null;
            }

            img = GetTemplateChild(elementName) as Image;
            canvas = GetTemplateChild("PART_Canvas") as Canvas;

            if (img != null && canvas != null)
            {
                tranformer = new MatrixTransform();
                img.RenderTransform = tranformer;
                executable = true;  // 命令是否能执行

                // 鼠标事件
                canvas.MouseLeftButtonDown += Element_MouseLeftButtonDown;
                canvas.MouseRightButtonDown += Element_MouseRightButtonDown;
                canvas.MouseMove += Element_MouseMove;
                canvas.MouseUp += Element_MouseUp;
                canvas.MouseWheel += Element_MouseWheel;
                canvas.SizeChanged += Element_SizeChanged;
            }
        }

        // 尺寸发生改变时：中心发生变化
        private void Element_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.geometryCenter = new Point(img.ActualWidth / 2, img.ActualHeight / 2);

            DoReset();
        }

        // 按下鼠标左键
        private void Element_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                DoReset();
            }
            img.CaptureMouse();
            mouseDown = true;
            moveStart = e.GetPosition(img);
        }

        private void Element_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            img.CaptureMouse();
            mouseDown = true;
            rotateStart = e.GetPosition(img);
        }

        // 鼠标移动
        private void Element_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown) return;
            Point mouseEnd = e.GetPosition(img);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var delta = mouseEnd - moveStart;
                DoMove(delta.X, delta.Y);
                //moveStart = mouseEnd;
            }
            else if (e.RightButton == MouseButtonState.Pressed)
            {
                // 按下鼠标右键，旋转图片
                double angle = (mouseEnd.Y - rotateStart.Y) * 0.2;
                DoRotate(angle, rotateStart);
            }
        }

        // 释放鼠标
        private void Element_MouseUp(object sender, MouseButtonEventArgs e)
        {
            img.ReleaseMouseCapture();
            mouseDown = false;
        }

        // 滚动鼠标滚轮
        private void Element_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Point scaleCenter = e.GetPosition(img);
            bool enlarge = e.Delta > 0;
            DoScale(enlarge, scaleCenter);
        }

    }
    // 以下为该控件支持的命令 
    public static class TransformCommands
    {
        /// <summary>
        /// 向上移动
        /// </summary>
        public static RoutedCommand MoveUp { get; } = new(nameof(MoveUp), typeof(TransformCommands));

        /// <summary>
        /// 向下移动
        /// </summary>
        public static RoutedCommand MoveDown { get; } = new(nameof(MoveDown), typeof(TransformCommands));

        /// <summary>
        /// 向左移动
        /// </summary>
        public static RoutedCommand MoveLeft { get; } = new(nameof(MoveLeft), typeof(TransformCommands));

        /// <summary>
        /// 向右移动
        /// </summary>
        public static RoutedCommand MoveRight { get; } = new(nameof(MoveRight), typeof(TransformCommands));

        /// <summary>
        /// 向左旋转
        /// </summary>
        public static RoutedCommand RotateLeft { get; } = new(nameof(RotateLeft), typeof(TransformCommands));

        /// <summary>
        /// 向右旋转
        /// </summary>
        public static RoutedCommand RotateRight { get; } = new(nameof(RotateRight), typeof(TransformCommands));

        /// <summary>
        /// 放大
        /// </summary>
        public static RoutedCommand Enlarge { get; } = new(nameof(Enlarge), typeof(TransformCommands));

        /// <summary>
        /// 缩小
        /// </summary>
        public static RoutedCommand Reduce { get; } = new(nameof(Reduce), typeof(TransformCommands));

        /// <summary>
        /// 水平翻转
        /// </summary>
        public static RoutedCommand FlipX { get; } = new(nameof(FlipX), typeof(TransformCommands));

        /// <summary>
        /// 垂直翻转
        /// </summary>
        public static RoutedCommand FlipY { get; } = new(nameof(FlipY), typeof(TransformCommands));

        /// <summary>
        /// 重置
        /// </summary>
        public static RoutedCommand Reset { get; } = new(nameof(Reset), typeof(TransformCommands));
    }
}
