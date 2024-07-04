using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AdornerDemo
{
    public class DragCanvas : Control
    {
        static DragCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DragCanvas), new FrameworkPropertyMetadata(typeof(DragCanvas)));
        }


        /// <summary>
        /// 鼠标位置
        /// </summary>
        public string Position
        {
            get { return (string)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }
        public static readonly DependencyProperty PositionProperty =
            DependencyProperty.Register("Position", typeof(string), typeof(DragCanvas), new PropertyMetadata(""));


        private readonly double MinZoom = 0.2;
        private readonly double MaxZoom = 30;
        private readonly double Space = 20;

        private Point OriPoint;
        private bool CanMove = false;
        private bool CanDrawRect = false;
        private bool HasItems = false;


        private Canvas BackCanvas;
        private Canvas ConnectCanvas;


        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            BackCanvas = (Canvas)GetTemplateChild("PART_BackCanvas");
            ConnectCanvas = (Canvas)GetTemplateChild("PART_ConnectCanvas");
        }


        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);

            OriPoint = e.GetPosition(this);

            // 右键双击自适应
            if (e.ClickCount == 2 && e.RightButton == MouseButtonState.Pressed)
            {
                FitItems();
            }

            // 右键或中键平移
            if (e.RightButton == MouseButtonState.Pressed || e.MiddleButton == MouseButtonState.Pressed)
            {
                CanMove = true;

                // 判断是否有选中项
                foreach (RectangleAdorner item in BackCanvas.Children)
                {
                    if (item.Info.IsHitTest)
                    {
                        HasItems = true;
                        return;
                    }
                }
            }

            // 判断是否击中
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (BackCanvas.Children.Count == 0)
                {
                    CanDrawRect = true;
                    return;
                }
                foreach (RectangleAdorner item in BackCanvas.Children)
                {
                    Rect rect = GetBoundary(item);
                    if (!rect.Contains(OriPoint))
                    {
                        item.ShowThumbs(Visibility.Collapsed);
                        CanDrawRect = true;
                        HasItems = false;
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            Point curPoint = e.GetPosition(this);
            Position = "X: " + curPoint.X + ", Y: " + curPoint.Y;

            // 平移
            if (CanMove)
            {
                double offsetX = curPoint.X - OriPoint.X;
                double offsetY = curPoint.Y - OriPoint.Y;
                if (!HasItems)
                {
                    MoveElement(BackCanvas, offsetX, offsetY);
                }
                else
                {
                    double r = BackCanvas.RenderTransform.Value.M11;
                    foreach (RectangleAdorner item in BackCanvas.Children)
                    {
                        if (item.Info.IsHitTest)
                        {
                            item.DoMove(offsetX / r, offsetY / r);
                        }
                    }
                    DrawConnectLines();
                }
                OriPoint = curPoint;
            }

            // 绘制虚线框
            if (CanDrawRect)
            {
                double x = Math.Min(curPoint.X, OriPoint.X);
                double y = Math.Min(curPoint.Y, OriPoint.Y);
                Point point = TranslatePoint(new Point(x, y), ConnectCanvas);
                double r = ConnectCanvas.RenderTransform.Value.M11;
                Rectangle rectangle = new Rectangle
                {
                    Stroke = Brushes.WhiteSmoke,
                    StrokeThickness = 1,
                    StrokeDashArray = new DoubleCollection { 4, 2 },
                    Width = Math.Abs(curPoint.X - OriPoint.X) / r,
                    Height = Math.Abs(curPoint.Y - OriPoint.Y) / r,
                    Margin = new Thickness(point.X, point.Y, 0, 0),
                    IsHitTestVisible = false,
                };

                int count = ConnectCanvas.Children.Count;
                if (count == 0)
                {
                    ConnectCanvas.Children.Add(rectangle);
                }
                else if (ConnectCanvas.Children[count - 1] is not Rectangle)
                {
                    ConnectCanvas.Children.Add(rectangle);
                }
                else if (ConnectCanvas.Children[count - 1] is Rectangle rect)
                {
                    ConnectCanvas.Children.Remove(rect);
                    ConnectCanvas.Children.Add(rectangle);
                }
            }
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);

            CanMove = false;
            CanDrawRect = false;
            int count = ConnectCanvas.Children.Count;
            if (count > 0 && ConnectCanvas.Children[count - 1] is Rectangle rect)
            {
                ConnectCanvas.Children.RemoveAt(count - 1);
                // 判断选中项
                Rect range = new Rect(rect.Margin.Left, rect.Margin.Top, rect.Width, rect.Height);
                foreach (RectangleAdorner item in BackCanvas.Children)
                {
                    Rect boundary = GetBoundary(item);
                    if (range.Contains(boundary))
                    {
                        item.Info.IsHitTest = true;
                        item.ShowThumbs(Visibility.Visible);
                    }
                }
            }
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);

            Point curPoint = e.GetPosition(BackCanvas);
            double ratio = e.Delta > 0 ? 1.25 : 0.8;
            double r = BackCanvas.RenderTransform.Value.M11;
            bool canZoom = false;
            if (r < MinZoom)
            {
                // 仅放大
                if (ratio > 1)
                {
                    canZoom = true;
                }
            }
            else if (r > MaxZoom)
            {
                // 仅缩小
                if (ratio < 1)
                {
                    canZoom = true;
                }
            }
            else
            {
                canZoom = true;
            }
            if (canZoom)
            {
                ZoomElement(BackCanvas, ratio, curPoint.X, curPoint.Y);
            }
        }

        #region 内部方法
        /// <summary>
        /// 移动
        /// </summary>
        /// <param name="ui"></param>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
        private void MoveElement(UIElement ui, double offsetX, double offsetY)
        {
            Matrix matrix = ui.RenderTransform.Value;
            matrix.OffsetX += offsetX;
            matrix.OffsetY += offsetY;
            ui.RenderTransform = new MatrixTransform(matrix);
        }
        /// <summary>
        /// 缩放
        /// </summary>
        /// <param name="ui"></param>
        /// <param name="ratio"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        private void ZoomElement(UIElement ui, double ratio, double centerX, double centerY)
        {
            Matrix matrix = ui.RenderTransform.Value;
            matrix.ScaleAtPrepend(ratio, ratio, centerX, centerY);
            ui.RenderTransform = new MatrixTransform(matrix);
        }

        /// <summary>
        /// 获取矩形范围
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private Rect GetBoundary(RectangleAdorner item)
        {
            double x = Canvas.GetLeft(item);
            double y = Canvas.GetTop(item);
            return new Rect(x, y, item.Width, item.Height);
        }
        /// <summary>
        /// 获取矩形范围
        /// </summary>
        /// <returns></returns>
        private Rect GetBoundary()
        {
            Rect rect = new Rect();
            if (BackCanvas.Children.Count == 0)
            {
                return rect;
            }
            if (BackCanvas.Children[0] is RectangleAdorner ui)
            {
                rect = GetBoundary(ui);
            }
            foreach (RectangleAdorner item in BackCanvas.Children)
            {
                rect = Rect.Union(rect, GetBoundary(item));
            }
            return rect;
        }
        
        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private RectangleAdorner GetItem(string id)
        {
            RectangleAdorner rectangle = null;
            foreach (RectangleAdorner item in BackCanvas.Children)
            {
                if (item.Info.ID.StartsWith(id))
                {
                    rectangle = item;
                    break;
                }
            }
            return rectangle;
        }

        /// <summary>
        /// 连接两项
        /// </summary>
        /// <param name="ui1"></param>
        /// <param name="ui2"></param>
        private void ConnectItem(RectangleAdorner ui1, RectangleAdorner ui2)
        {
            double x1 = Canvas.GetLeft(ui1);
            double y1 = Canvas.GetTop(ui1);
            double x2 = Canvas.GetLeft(ui2);
            double y2 = Canvas.GetTop(ui2);
            
            foreach (var item1 in ui1.Info.ConnectLines)
            {
                foreach (var item2 in ui2.Info.ConnectLines)
                {
                    if (item1 == item2)
                    {
                        PointCollection pts = new PointCollection();
                        // 上下
                        if (item1.OrientationSource == EnumDragThumbType.Down && item1.OrientationTarget == EnumDragThumbType.Up)
                        {
                            Point pt1 = new Point(0.5 * ui1.Width + x1, ui1.Height + y1);
                            Point pt2 = new Point(0.5 * ui2.Width + x2, y2);
                            if (y1 + ui1.Height < y2)
                            {
                                double y = 0.5 * (pt1.Y + pt2.Y);
                                pts = new PointCollection
                                {
                                    pt1,
                                    new Point(pt1.X, y),
                                    new Point(pt2.X, y),
                                    pt2
                                };
                            }
                            else
                            {
                                double x = 0.5 * (ui1.Width + x1 + x2);
                                double y = Math.Max(y1 + ui1.Height, y2 + ui2.Height);
                                if (x > x2)
                                {
                                    x = Math.Min(x1, x2) - 5;
                                }
                                if (x1 > x2 + ui2.Width)
                                {
                                    x = 0.5 * (ui2.Width + x2 + x1);
                                }
                                if (y1 + ui1.Height < y2 + ui2.Height)
                                {
                                    y = y1 + ui1.Height;
                                }
                                pts = new PointCollection
                                {
                                    pt1,
                                    new Point(pt1.X, y + 5),
                                    new Point(x, y + 5),
                                    new Point(x, pt2.Y - 5),
                                    new Point(pt2.X, pt2.Y - 5),
                                    pt2
                                };
                            } 
                        }
                        // 左右
                        else if (item1.OrientationSource == EnumDragThumbType.Right && item1.OrientationTarget == EnumDragThumbType.Left)
                        {
                            Point pt1 = new Point(ui1.Width + x1, 0.5 * ui1.Height + y1);
                            Point pt2 = new Point(x2, 0.5 * ui2.Height + y2);
                            if (x1 + ui1.Width < x2)
                            {
                                double x = 0.5 * (pt1.X + pt2.X);
                                pts = new PointCollection
                                {
                                    pt1,
                                    new Point(x, pt1.Y),
                                    new Point(x, pt2.Y),
                                    pt2
                                };
                            }
                            else
                            {
                                double x = Math.Max(x1 + ui1.Width, x2);
                                double y = 0.5 * (ui1.Height + y1 + y2);
                                if (y1 + ui1.Height > y2 && y2 + ui2.Height > y1)
                                {
                                    y = Math.Min(y1, y2) - 5;
                                }
                                pts = new PointCollection
                                {
                                    pt1,
                                    new Point(x + 5, pt1.Y),
                                    new Point(x + 5, y),
                                    new Point(pt2.X - 5, y),
                                    new Point(pt2.X - 5, pt2.Y),
                                    pt2
                                };
                            }
                        }
                        // 右左
                        else if (item1.OrientationSource == EnumDragThumbType.Left && item1.OrientationTarget == EnumDragThumbType.Right)
                        {
                            Point pt1 = new Point(x1, 0.5 * ui1.Height + y1);
                            Point pt2 = new Point(ui2.Width + x2, 0.5 * ui2.Height + y2);
                            if (x2 + ui2.Width < x1)
                            {
                                double x = 0.5 * (pt1.X + pt2.X);
                                pts = new PointCollection
                                {
                                    pt1,
                                    new Point(x, pt1.Y),
                                    new Point(x, pt2.Y),
                                    pt2
                                };
                            }
                            else
                            {
                                double x = Math.Min(x1, x2 + ui2.Width);
                                double y = 0.5 * (ui1.Height + y1 + y2);
                                if (y1 + ui1.Height > y2 && y2 + ui2.Height > y1)
                                {
                                    y = Math.Min(y1, y2) - 5;
                                }
                                pts = new PointCollection
                                {
                                    pt1,
                                    new Point(x - 5, pt1.Y),
                                    new Point(x - 5, y),
                                    new Point(pt2.X + 5, y),
                                    new Point(pt2.X + 5, pt2.Y),
                                    pt2
                                };
                            }
                        }

                        if (pts.Count < 2)
                        {
                            return;
                        }
                        // 连接线
                        Polyline line = new Polyline
                        {
                            Stroke = Brushes.Yellow,
                            StrokeThickness = 1,
                            Points = pts,
                        };
                        // 箭头
                        int index = pts.Count - 1;
                        Polygon polygon = new Polygon
                        {
                            Stroke = Brushes.Yellow,
                            StrokeThickness = 1,
                            Fill = Brushes.Yellow,
                            Points = new PointCollection
                                {
                                    pts[index],
                                    new Point(pts[index].X - 3, pts[index].Y - 3),
                                    new Point(pts[index].X + 3, pts[index].Y - 3),
                                },
                        };
                        // 上下
                        if (pts[index - 1].Y < pts[index].Y)
                        {
                            polygon.Points = new PointCollection
                            {
                                pts[index],
                                new Point(pts[index].X - 3, pts[index].Y - 3),
                                new Point(pts[index].X + 3, pts[index].Y - 3),
                            };
                        }
                        // 左右
                        else if (pts[index - 1].X < pts[index].X)
                        {
                            polygon.Points = new PointCollection
                            {
                                pts[index],
                                new Point(pts[index].X - 3, pts[index].Y - 3),
                                new Point(pts[index].X - 3, pts[index].Y + 3),
                            };
                        }
                        // 右左
                        else if (pts[index - 1].X > pts[index].X)
                        {
                            polygon.Points = new PointCollection
                            {
                                pts[index],
                                new Point(pts[index].X + 3, pts[index].Y - 3),
                                new Point(pts[index].X + 3, pts[index].Y + 3),
                            };
                        }
                        ConnectCanvas.Children.Add(line);
                        ConnectCanvas.Children.Add(polygon);
                    }
                }
            }
        }

        /// <summary>
        /// 绘制连接线
        /// </summary>
        private void DrawConnectLines()
        {
            int count = BackCanvas.Children.Count;
            ConnectCanvas.Children.Clear();
            for (int i = 0; i < count - 1; i++)
            {
                RectangleAdorner ui1 = (RectangleAdorner)BackCanvas.Children[i];
                for (int j = i + 1; j < count; j++)
                {
                    RectangleAdorner ui2 = (RectangleAdorner)BackCanvas.Children[j];
                    ConnectItem(ui1, ui2);
                }
                //RectangleAdorner ui2 = (RectangleAdorner)BackCanvas.Children[i + 1];
                //ConnectItem(ui1, ui2);
            }
        }

        private void ShowSettingWindow()
        {
            MessageBox.Show("双击弹出设置窗体!");
        }

        private void OnDragStarted(RectangleAdornerInfo info)
        {
            var pt = Mouse.GetPosition(BackCanvas);
            var item = GetItem(info.ID);
            var rect = GetBoundary(item);
            switch (info.OrientationDrag)
            {
                case EnumDragThumbType.None:
                    break;
                case EnumDragThumbType.Up:
                    pt = new Point(rect.X + 0.5 * rect.Width, rect.Y + 0.5 * info.StrokeThickness);
                    break;
                case EnumDragThumbType.Down:
                    pt = new Point(rect.X + 0.5 * rect.Width, rect.Y + rect.Height - 0.5 * info.StrokeThickness);
                    break;
                case EnumDragThumbType.Left:
                    pt = new Point(rect.X + 0.5 * info.StrokeThickness, rect.Y + 0.5 * rect.Height);
                    break;
                case EnumDragThumbType.Right:
                    pt = new Point(rect.X + rect.Width - 0.5 * info.StrokeThickness, rect.Y + 0.5 * rect.Height);
                    break;
                default:
                    break;
            }

            Polyline line = new Polyline
            {
                Stroke = Brushes.WhiteSmoke,
                StrokeThickness = 1,
            };
            line.Points.Add(pt);
            line.Points.Add(pt);
            line.Points.Add(pt);
            ConnectCanvas.Children.Add(line);
        }
        private void OnDragDelta(RectangleAdornerInfo info)
        {
            var pt = Mouse.GetPosition(BackCanvas);
            int count = ConnectCanvas.Children.Count;
            if (count > 0 && ConnectCanvas.Children[count - 1] is Polyline line)
            {
                line.Points[1] = new Point(pt.X, line.Points[0].Y);
                line.Points[2] = pt;
            }
        }
        private void OnDragCompleted(RectangleAdornerInfo info)
        {
            // 源节点
            var src = GetItem(info.ID);

            var pt = Mouse.GetPosition(BackCanvas);
            int count = ConnectCanvas.Children.Count;
            if (count > 0 && ConnectCanvas.Children[count - 1] is Polyline line)
            {
                ConnectCanvas.Children.Remove(line);

                // 目标对象
                foreach (RectangleAdorner item in BackCanvas.Children)
                {
                    Rect rect = GetBoundary(item);
                    double x1 = rect.X;
                    double y1 = rect.Y;
                    double x2 = x1 + rect.Width;
                    double y2 = y1 + rect.Height;
                    var v1 = new Point(0.5 * (x1 + x2), y1) - pt;
                    var v2 = new Point(0.5 * (x1 + x2), y2) - pt;
                    var v3 = new Point(x1, 0.5 * (y1 + y2)) - pt;
                    var v4 = new Point(x2, 0.5 * (y1 + y2)) - pt;
                    // 判断方向
                    bool hit = false;
                    EnumDragThumbType ori = EnumDragThumbType.None;
                    if (v1.Length < 5)
                    {
                        hit = true;
                        ori = EnumDragThumbType.Up;
                    }
                    else if (v2.Length < 5)
                    {
                        hit = true;
                        ori = EnumDragThumbType.Down;
                    }
                    else if (v3.Length < 5)
                    {
                        hit = true;
                        ori = EnumDragThumbType.Left;
                    }
                    else if (v4.Length < 5)
                    {
                        hit = true;
                        ori = EnumDragThumbType.Right;
                    }

                    if (hit)
                    {
                        var obj = new DragThumbInfo(info.ID, info.OrientationDrag, item.Info.ID, ori);
                        var d = src.Info.ConnectLines.FirstOrDefault(x => x.IdSource == obj.IdSource && x.OrientationSource == obj.OrientationSource &&
                                                                          x.IdTarget == obj.IdTarget && x.OrientationTarget == obj.OrientationTarget);
                        if (d == null)
                        {
                            src.Info.ConnectLines.Add(obj);
                        }

                        d = item.Info.ConnectLines.FirstOrDefault(x => x.IdSource == obj.IdSource && x.OrientationSource == obj.OrientationSource &&
                                                                       x.IdTarget == obj.IdTarget && x.OrientationTarget == obj.OrientationTarget);
                        if (d == null)
                        {
                            item.Info.ConnectLines.Add(obj);
                        }

                        // 连线
                        DrawConnectLines();
                        //ConnectItem(src, item);
                        break;
                    }
                }
            }
        }
        #endregion

        #region 外部接口
        /// <summary>
        /// 自适应大小
        /// </summary>
        public void FitItems()
        {
            if (BackCanvas.Children.Count == 0)
            {
                return;
            }
            Rect rect = GetBoundary();
            double ratio = Math.Min(ActualHeight / rect.Height, ActualWidth / rect.Width);
            if (ratio > 1)
            {
                ratio = 1;
            }
            double offsetX = 0.5 * (ActualWidth - ratio * rect.Width);
            double offsetY = 0.5 * (ActualHeight - ratio * rect.Height);
            Matrix matrix = Matrix.Identity;
            matrix.Translate(-rect.Left + offsetX / ratio, -rect.Top + offsetY / ratio);
            if (ratio <= 1)
            {
                ratio *= 0.95;
                matrix.Scale(ratio, ratio);
                matrix.Translate(0.025 * ActualWidth, 0.025 * ActualHeight);
            }
            BackCanvas.RenderTransform = new MatrixTransform(matrix);
        }

        /// <summary>
        /// 删除一项
        /// </summary>
        /// <param name="id"></param>
        public void DeleteItem(string id)
        {
            foreach (RectangleAdorner item in BackCanvas.Children)
            {
                if (item.Info.ID.StartsWith(id))
                {
                    BackCanvas.Children.Remove(item);

                    DrawConnectLines();
                    return;
                }
            }
        }
        /// <summary>
        /// 删除一项
        /// </summary>
        /// <param name="idx"></param>
        public void DeleteItem(int idx)
        {
            if (BackCanvas.Children.Count > idx)
            {
                BackCanvas.Children.RemoveAt(idx);

                DrawConnectLines();
                return;
            }
        }

        /// <summary>
        /// 末尾增加
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="autoAlignment"></param>
        public void AddItem(Point pt, string txt = "Text", bool autoAlignment = false)
        {
            double r = BackCanvas.RenderTransform.Value.M11;
            double dy = BackCanvas.RenderTransform.Value.OffsetY;
            int count = BackCanvas.Children.Count;
            if (count == 0)
            {
                BackCanvas.RenderTransform = new MatrixTransform(Matrix.Identity);
                r = 1;
            }
            else if (autoAlignment)
            {
                RectangleAdorner ct = (RectangleAdorner)BackCanvas.Children[count - 1];
                double left = Canvas.GetLeft(ct);
                double top = Canvas.GetTop(ct);
                pt = new Point(left, top + ct.Height + Space);
            }

            RectangleAdornerInfo info = new RectangleAdornerInfo(pt, txt);
            RectangleAdorner control = new RectangleAdorner(info);
            if ((pt.Y + control.Height) * r + dy < ActualHeight)
            {
                control.SetValue(Canvas.LeftProperty, pt.X);
                control.SetValue(Canvas.TopProperty, pt.Y);
            }
            else
            {
                // 换一列
                Rect rect = GetBoundary();
                control.SetValue(Canvas.LeftProperty, Space + rect.Right);
                control.SetValue(Canvas.TopProperty, rect.Top);
            }
            control.OnMoveEvent += DrawConnectLines;
            control.OnDoubleClickEvent += ShowSettingWindow;
            control.OnDragStarted += OnDragStarted;
            control.OnDragDelta += OnDragDelta;
            control.OnDragCompleted += OnDragCompleted;
            BackCanvas.Children.Add(control);

            //DrawConnectLines();
        }

        /// <summary>
        /// 中间插入
        /// </summary>
        /// <param name="idx"></param>
        public void InsertItem(int idx, string txt = "Text")
        {
            if (BackCanvas.Children.Count == 0)
            {
                AddItem(new Point(Space, Space), txt, true);
            }
            else if (idx > 0)
            {
                RectangleAdorner ct = (RectangleAdorner)BackCanvas.Children[idx - 1];
                double left = Canvas.GetLeft(ct);
                double top = Canvas.GetTop(ct);

                RectangleAdornerInfo info = new RectangleAdornerInfo(new Point(left, top), txt);
                RectangleAdorner control = new RectangleAdorner(info);
                control.SetValue(Canvas.LeftProperty, left);
                control.SetValue(Canvas.TopProperty, top + ct.Height + Space);
                control.OnMoveEvent += DrawConnectLines;
                control.OnDoubleClickEvent += ShowSettingWindow;
                BackCanvas.Children.Insert(idx, control);
            }
            SetItemsAlignment();
        }

        /// <summary>
        /// 自动对齐
        /// </summary>
        public void SetItemsAlignment()
        {
            Rect rect = GetBoundary();
            double r = BackCanvas.RenderTransform.Value.M11;
            double dy = BackCanvas.RenderTransform.Value.OffsetY;
            for (int i = 0; i < BackCanvas.Children.Count - 1; i++)
            {
                if (BackCanvas.Children[i] is RectangleAdorner control1 && BackCanvas.Children[i + 1] is RectangleAdorner control2)
                {
                    double x1 = Canvas.GetLeft(control1);
                    double y1 = Canvas.GetTop(control1);
                    double x2 = Canvas.GetLeft(control2);
                    if (i == 0)
                    {
                        Canvas.SetLeft(control1, rect.Left);
                        Canvas.SetTop(control1, rect.Top);
                        x1 = rect.Left;
                        y1 = rect.Top;
                    }

                    if (x1 + control1.Width > x2 && (y1 + control1.Height + Space + control2.Height) * r + dy < ActualHeight)
                    {
                        Canvas.SetLeft(control2, x1);
                        Canvas.SetTop(control2, y1 + control1.Height + Space);
                    }
                    else
                    {
                        // 换一列
                        Canvas.SetLeft(control2, x1 + control1.Width + Space);
                        Canvas.SetTop(control2, rect.Top);
                    }
                }
            }

            //DrawConnectLines();
        }

        /// <summary>
        /// 设置尺寸
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void SetItemSize(double width = 100, double height = 36)
        {
            foreach (RectangleAdorner item in BackCanvas.Children)
            {
                item.Width = width;
                item.Height = height;
            }
            //DrawConnectLines();
        }

        /// <summary>
        /// 锁定/解锁
        /// </summary>
        public void SetItemsLocked()
        {
            foreach (RectangleAdorner item in BackCanvas.Children)
            {
                item.IsHitTestVisible = !item.IsHitTestVisible;
            }
        }

        /// <summary>
        /// 清空
        /// </summary>
        public void ClearItems()
        {
            BackCanvas.Children.Clear();
            ConnectCanvas.Children.Clear();
        }
        #endregion
    }
}