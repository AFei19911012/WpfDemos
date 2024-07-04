using System.Windows;
using System.Windows.Documents;
using System.Windows.Interop;

namespace WindowFormsHost
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2024 All rights reserved
    /// Author      : Big Wang
    /// Created Time: 2024/3/9 15:22:13
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2024/3/9 15:22:13                     Big Wang        Init         
    ///
    public static class WindowHelper
    {
        public static nint GetHandle(this Window window)
        {
            return new WindowInteropHelper(window).EnsureHandle();
        }

        public static bool ShowDialogWithMask(this Window window, double opacity = 0.8)
        {
            Window win = null;
            if (System.Windows.Application.Current.Windows.Count > 0)
            {
                win = System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault(o => o.IsActive);
            }

            if (win == null || win.Content is not FrameworkElement ct)
            {
                return window.ShowDialog() == true;
            }
            else
            {
                // 添加装饰器
                var adornerLayer = AdornerLayer.GetAdornerLayer(ct);
                adornerLayer.Opacity = opacity;
                adornerLayer.Add(new MaskAdorner(ct));

                window.Closed += (s, e) =>
                {
                    // 移除装饰器
                    var adorners = adornerLayer.GetAdorners(ct);
                    if (adorners != null)
                    {
                        adornerLayer.Remove(adorners[^1]);
                    }
                };
                window.Owner = win;
                window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                return window.ShowDialog() == true;
            }
        }
    }
}