using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AdornerDemo
{
    public class RectangleAdorner : Control
    {
        public delegate void DelegateEventHandle();
        public event DelegateEventHandle OnMoveEvent;
        public event DelegateEventHandle OnDoubleClickEvent;

        public delegate void DelegateEventHandleDrag(RectangleAdornerInfo id);
        public event DelegateEventHandleDrag OnDragStarted;
        public event DelegateEventHandleDrag OnDragDelta;
        public event DelegateEventHandleDrag OnDragCompleted;


        private const double AdonerThumbSize = 7.5;
        private const double ElementMiniSize = 20;

        private readonly Thumb tMove;
        private readonly Thumb tBorder;
        private readonly Thumb tLeftUp;
        private readonly Thumb tRightUp;
        private readonly Thumb tLeftBottom;
        private readonly Thumb tRightBottom;
        private readonly Thumb tLeft;
        private readonly Thumb tRight;
        private readonly Thumb tUp;
        private readonly Thumb tBottom;
        private readonly VisualCollection visualCollection;
       

        public RectangleAdornerInfo Info { get; set; } = new RectangleAdornerInfo();  


        /// <summary>
        /// 显示节点和控制点
        /// </summary>
        /// <param name="visibility"></param>
        public void ShowThumbs(Visibility visibility = Visibility.Collapsed)
        {
            Info.IsHitTest = visibility == Visibility.Visible;

            tLeftUp.Visibility = visibility;
            tRightUp.Visibility = visibility;
            tLeftBottom.Visibility = visibility;
            tRightBottom.Visibility = visibility;
            tLeft.Visibility = visibility;
            tRight.Visibility = visibility;
            tUp.Visibility = visibility;
            tBottom.Visibility = visibility;
            InvalidateVisual();
        }

        /// <summary>
        /// 设置文本内容
        /// </summary>
        /// <param name="txt"></param>
        public void SetText(string txt)
        {
            Info.Text = txt;
            InvalidateVisual();
        }

        /// <summary>
        /// 平移
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public void DoMove(double dx, double dy)
        {
            Canvas.SetLeft(this, Canvas.GetLeft(this) + dx);
            Canvas.SetTop(this, Canvas.GetTop(this) + dy);
        }

        public RectangleAdorner(RectangleAdornerInfo info)
        {
            Info = new RectangleAdornerInfo(info);

            Canvas.SetLeft(this, info.Position.X);
            Canvas.SetTop(this, info.Position.Y);
            Width = info.Width;
            Height = info.Height;

            RenderTransformOrigin = new Point(0.5, 0.5);
            AllowDrop = true;

            visualCollection = new VisualCollection(this)
            {
                (tMove = CreateMoveThumb()),
                (tBorder = CreateBorderThumb()),

                (tLeftUp = CreateResizeThumb(Cursors.SizeNWSE, HorizontalAlignment.Left, VerticalAlignment.Top)),
                (tRightUp = CreateResizeThumb(Cursors.SizeNESW, HorizontalAlignment.Right, VerticalAlignment.Top)),
                (tLeftBottom = CreateResizeThumb(Cursors.SizeNESW, HorizontalAlignment.Left, VerticalAlignment.Bottom)),
                (tRightBottom = CreateResizeThumb(Cursors.SizeNWSE, HorizontalAlignment.Right, VerticalAlignment.Bottom)),

                //(tLeft = CreateResizeThumb(Cursors.SizeWE, HorizontalAlignment.Left, VerticalAlignment.Stretch)),
                //(tUp = CreateResizeThumb(Cursors.SizeNS, HorizontalAlignment.Stretch, VerticalAlignment.Top)),
                //(tRight = CreateResizeThumb(Cursors.SizeWE, HorizontalAlignment.Right, VerticalAlignment.Stretch)),
                //(tBottom = CreateResizeThumb(Cursors.SizeNS, HorizontalAlignment.Stretch, VerticalAlignment.Bottom)),

                (tLeft = CreateDragNodeThumb()),
                (tUp = CreateDragNodeThumb()),
                (tRight = CreateDragNodeThumb()),
                (tBottom = CreateDragNodeThumb()),
            };

            ShowThumbs();
        }

        protected override int VisualChildrenCount => visualCollection.Count;

        protected override Visual GetVisualChild(int index) => visualCollection[index];

        protected override void OnRender(DrawingContext drawingContext)
        {
            Typeface typeface = new Typeface(new FontFamily("微软雅黑"), FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
            FormattedText txt = new FormattedText(Info.Text, System.Globalization.CultureInfo.InvariantCulture, FlowDirection.LeftToRight,
                typeface, 14, Brushes.Yellow, 1);
            drawingContext.DrawText(txt, new Point(Height, 0.5 * (Height - txt.Height)));
            drawingContext.DrawImage((DrawingImage)Application.Current.FindResource("Image_Element_Circle"), new Rect(5, 5, Height - 10, Height - 10));

            double offset = AdonerThumbSize / 2;
            // 考虑线宽
            double d = 0.5 * Info.StrokeThickness;
            Size sz = new(AdonerThumbSize, AdonerThumbSize);
            tMove.Arrange(new Rect(new Point(0, 0), new Size(Width, Height)));
            tBorder.Arrange(new Rect(new Point(0, 0), new Size(Width, Height)));

            tLeftUp.Arrange(new Rect(new Point(-offset + d, -offset + d), sz));
            tRightUp.Arrange(new Rect(new Point(Width - offset - d, -offset + d), sz));
            tLeftBottom.Arrange(new Rect(new Point(-offset + d, Height - offset - d), sz));
            tRightBottom.Arrange(new Rect(new Point(Width - offset - d, Height - offset - d), sz));

            tLeft.Arrange(new Rect(new Point(-offset + d, Height / 2 - offset), sz));
            tUp.Arrange(new Rect(new Point(Width / 2 - offset, -offset + d), sz));
            tRight.Arrange(new Rect(new Point(Width - offset - d, Height / 2 - offset), sz));
            tBottom.Arrange(new Rect(new Point(Width / 2 - offset, Height - offset - d), sz));
        }

        /// <summary>
        /// 平移：透明色
        /// </summary>
        /// <returns></returns>
        private Thumb CreateMoveThumb()
        {
            Thumb thumb = new()
            {
                Cursor = Cursors.SizeAll,
                Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryMove()
                },
            };

            thumb.MouseEnter += (s, e) =>
            {
                tBorder.Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder(true)
                };
            };
            thumb.MouseLeave += (s, e) =>
            {
                tBorder.Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder()
                };
            };
            thumb.MouseDoubleClick += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    OnDoubleClickEvent?.Invoke();
                }
            };

            thumb.DragStarted += (s, e) =>
            {
                ShowThumbs(Visibility.Visible);
            };
            thumb.DragDelta += (s, e) =>
            {
                //Canvas.SetLeft(this, Canvas.GetLeft(this) + e.HorizontalChange);
                //Canvas.SetTop(this, Canvas.GetTop(this) + e.VerticalChange);
                DoMove(e.HorizontalChange, e.VerticalChange);
                OnMoveEvent?.Invoke();
            };

            return thumb;
        }

        /// <summary>
        /// 边框
        /// </summary>
        /// <returns></returns>
        private Thumb CreateBorderThumb()
        {
            Thumb thumb = new()
            {
                Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder()
                },
            };
            return thumb;
        }

        /// <summary>
        /// 尺寸
        /// </summary>
        /// <param name="cursor">鼠标</param>
        /// <param name="horizontal">水平</param>
        /// <param name="vertical">垂直</param>
        /// <returns></returns>
        private Thumb CreateResizeThumb(Cursor cursor, HorizontalAlignment horizontal, VerticalAlignment vertical)
        {
            Thumb thumb = new()
            {
                Cursor = cursor,
                Width = AdonerThumbSize,
                Height = AdonerThumbSize,
                HorizontalAlignment = horizontal,
                VerticalAlignment = vertical,
                Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryResize(),
                },
            };

            thumb.MouseEnter += (s, e) =>
            {
                tBorder.Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder(true)
                };
            };
            thumb.MouseLeave += (s, e) =>
            {
                tBorder.Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder()
                };
            };

            thumb.DragDelta += (s, e) =>
            {
                if (thumb.VerticalAlignment == VerticalAlignment.Bottom)
                {
                    if (Height + e.VerticalChange > ElementMiniSize)
                    {
                        Height += e.VerticalChange;
                    }
                }
                else if (thumb.VerticalAlignment == VerticalAlignment.Top)
                {
                    if (Height - e.VerticalChange > ElementMiniSize)
                    {
                        Height -= e.VerticalChange;
                        Canvas.SetTop(this, Canvas.GetTop(this) + e.VerticalChange);
                    }
                }

                if (thumb.HorizontalAlignment == HorizontalAlignment.Left)
                {
                    if (Width - e.HorizontalChange > ElementMiniSize)
                    {
                        Width -= e.HorizontalChange;
                        Canvas.SetLeft(this, Canvas.GetLeft(this) + e.HorizontalChange);
                    }
                }
                else if (thumb.HorizontalAlignment == HorizontalAlignment.Right)
                {
                    if (Width + e.HorizontalChange > ElementMiniSize)
                    {
                        Width += e.HorizontalChange;
                    }
                }

                Info.Width = Width;
                Info.Height = Height;

                OnMoveEvent?.Invoke();
            };

            return thumb;
        }

        /// <summary>
        /// 拖拽节点
        /// </summary>
        /// <param name="cursor">鼠标</param>
        /// <param name="horizontal">水平</param>
        /// <param name="vertical">垂直</param>
        /// <returns></returns>
        private Thumb CreateDragNodeThumb()
        {
            Thumb thumb = new()
            {
                Cursor = Cursors.Cross,
                Width = AdonerThumbSize,
                Height = AdonerThumbSize,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryDragNode(),
                },
            };
            //thumb.AddHandler(MouseLeftButtonDownEvent, new MouseButtonEventHandler(Thumb_MouseLeftButtonDown), true);
            //thumb.AddHandler(MouseLeftButtonUpEvent, new MouseButtonEventHandler(Thumb_MouseLeftButtonUp), true);
            //thumb.MouseLeftButtonDown += Thumb_MouseLeftButtonDown;
            //thumb.MouseLeftButtonUp += Thumb_MouseLeftButtonUp;

            thumb.MouseEnter += (s, e) =>
            {
                tBorder.Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder(true)
                };
            };
            thumb.MouseLeave += (s, e) =>
            {
                tBorder.Template = new ControlTemplate(typeof(Thumb))
                {
                    VisualTree = GetFactoryBorder()
                };
            };

            thumb.DragStarted += (s, e) =>
            {
                if (thumb == tLeft)
                {
                    Info.OrientationDrag = EnumDragThumbType.Left;
                }
                else if (thumb == tRight)
                {
                    Info.OrientationDrag = EnumDragThumbType.Right;
                }
                else if (thumb == tUp)
                {
                    Info.OrientationDrag = EnumDragThumbType.Up;
                }
                else
                {
                    Info.OrientationDrag = EnumDragThumbType.Down;
                }
                OnDragStarted?.Invoke(Info);
            };
            thumb.DragDelta += (s, e) =>
            {
                OnDragDelta?.Invoke(Info);
            };
            thumb.DragCompleted += (s, e) =>
            {
                OnDragCompleted?.Invoke(Info);
                Info.OrientationDrag = EnumDragThumbType.None;
            };

            return thumb;
        }

        private void Thumb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
        }
        private void Thumb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        /// <summary>
        /// 拖拽节点
        /// </summary>
        /// <returns></returns>
        private FrameworkElementFactory GetFactoryDragNode()
        {
            FrameworkElementFactory thisFactory = new(typeof(Ellipse));
            thisFactory.SetValue(Shape.StrokeProperty, Brushes.Yellow);
            thisFactory.SetValue(Shape.StrokeThicknessProperty, 1d);
            thisFactory.SetValue(Shape.FillProperty, (Brush)Application.Current.FindResource("BrushMoveThumb"));
            return thisFactory;
        }

        /// <summary>
        /// 尺寸
        /// </summary>
        /// <returns></returns>
        private FrameworkElementFactory GetFactoryResize()
        {
            FrameworkElementFactory thisFactory = new(typeof(Rectangle));
            thisFactory.SetValue(Shape.StrokeProperty, Brushes.Yellow);
            thisFactory.SetValue(Shape.StrokeThicknessProperty, 1d);
            thisFactory.SetValue(Shape.FillProperty, (Brush)Application.Current.FindResource("BrushMoveThumb"));
            return thisFactory;
        }

        /// <summary>
        /// 边框
        /// </summary>
        /// <returns></returns>
        private FrameworkElementFactory GetFactoryBorder(bool isActive = false)
        {
            FrameworkElementFactory thisFactory = new(typeof(Rectangle));
            thisFactory.SetValue(Shape.StrokeProperty, (Brush)Application.Current.FindResource("BrushRotateThumb"));
            thisFactory.SetValue(Shape.StrokeThicknessProperty, 1d);
            thisFactory.SetValue(Shape.StrokeDashArrayProperty, new DoubleCollection { 4, 2 });
            thisFactory.SetValue(Shape.FillProperty, (Brush)Application.Current.FindResource("BrushMoveThumb"));
            thisFactory.SetValue(Shape.IsHitTestVisibleProperty, false);
            if (isActive)
            {
                thisFactory.SetValue(Shape.StrokeProperty, Brushes.Yellow);
            }
            return thisFactory;
        }

        /// <summary>
        /// 平移
        /// </summary>
        /// <returns></returns>
        private FrameworkElementFactory GetFactoryMove()
        {
            FrameworkElementFactory thisFactory = new(typeof(Rectangle));
            thisFactory.SetValue(Shape.FillProperty, Brushes.Transparent);
            return thisFactory;
        }
    }
}