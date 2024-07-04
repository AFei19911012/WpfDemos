using HelixToolkit.Wpf;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Media3D;

namespace TestHelixToolkit.Converter
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @Taosy.W 2022 All rights reserved
    /// Author      : Taosy.W
    /// Created Time: 2022/3/30 11:51:59
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time            Modified By    Modified Content
    /// V1.0.0.0     2022/3/30 11:51:59    Taosy.W                 
    ///
    [ValueConversion(typeof(Visual3D), typeof(Rect3D))]
    public class BoundsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visual = value as Visual3D;
            return visual != null ? visual.FindBounds(Transform3D.Identity) : Rect3D.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}