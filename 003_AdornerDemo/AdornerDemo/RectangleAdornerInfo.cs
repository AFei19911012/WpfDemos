using System;
using System.Collections.Generic;
using System.Windows;

namespace AdornerDemo
{
    public class RectangleAdornerInfo
    {
        public Point Position { get; set; }
        public double Width { get; set; } = 100;
        public double Height { get; set; } = 30;

        public double StrokeThickness { get; set; } = 1;
        public string Text { get; set; } = "Text";
        public string ID { get; set; } = Guid.NewGuid().ToString();

        public bool IsHitTest { get; set; } = false;

        public EnumDragThumbType OrientationDrag { get; set; } = EnumDragThumbType.None;

        public List<DragThumbInfo> ConnectLines = new List<DragThumbInfo>();

        public RectangleAdornerInfo()
        {
        }

        public RectangleAdornerInfo(Point position, string txt)
        {
            Position = position;
            Text = txt;
        }

        public RectangleAdornerInfo(RectangleAdornerInfo info)
        {
            Position = new Point(info.Position.X, info.Position.Y);
            Width = info.Width;
            Height = info.Height;
            StrokeThickness = info.StrokeThickness;
            Text = info.Text;
            IsHitTest = info.IsHitTest;
        }
    }
}