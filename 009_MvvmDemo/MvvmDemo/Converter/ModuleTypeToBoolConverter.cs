using MvvmDemo.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MvvmDemo.Converter
{
    public class ModuleTypeToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ModuleType type = (ModuleType)value;
            if (parameter == null)
            {
                return false;
            }
            return (int)type == int.Parse(parameter.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int flag = int.Parse(parameter.ToString());
            return (ModuleType)flag;
        }
    }
}