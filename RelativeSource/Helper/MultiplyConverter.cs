using System;
using System.Globalization;
using System.Windows.Data;

namespace TimotheusUS.MVVMsamples.Helper
{
    internal class MultiplyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double originalValue && double.TryParse(parameter.ToString(), out double factor))
            {
                return originalValue * factor;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}