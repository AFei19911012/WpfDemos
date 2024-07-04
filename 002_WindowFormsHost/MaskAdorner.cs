using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace WindowFormsHost
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : Big Wang
    /// Created Time: 2024/3/9 15:21:37
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/3/9 15:21:37                     Big Wang        Init         
    ///
    public class MaskAdorner : Adorner
    {
        public MaskAdorner(UIElement adornedElement) : base(adornedElement)
        {
            IsHitTestVisible = false;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            Rect adornedElementRect = new(AdornedElement.RenderSize);
            var brush = System.Windows.Media.Brushes.Gray;
            System.Windows.Media.Pen pen = new System.Windows.Media.Pen(brush, 1.0);
            drawingContext.DrawRectangle(brush, pen, adornedElementRect);
        }
    }
}