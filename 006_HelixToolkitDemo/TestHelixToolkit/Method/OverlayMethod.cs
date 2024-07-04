using System.Windows;
using System.Windows.Media.Media3D;

namespace TestHelixToolkit.Method
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @Taosy.W 2022 All rights reserved
    /// Author      : Taosy.W
    /// Created Time: 2022/3/28 18:46:16
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time            Modified By    Modified Content
    /// V1.0.0.0     2022/3/28 18:46:16    Taosy.W                 
    ///
    public class OverlayMethod : DependencyObject
    {
        public static readonly DependencyProperty Position3DProperty = DependencyProperty.RegisterAttached("Position3D", typeof(Point3D), typeof(OverlayMethod));

        public static Point3D GetPosition3D(DependencyObject obj)
        {
            return (Point3D)obj.GetValue(Position3DProperty);
        }

        public static void SetPosition3D(DependencyObject obj, Point3D value)
        {
            obj.SetValue(Position3DProperty, value);
        }
    }
}