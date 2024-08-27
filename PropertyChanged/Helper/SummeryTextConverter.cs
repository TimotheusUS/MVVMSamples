using System;
using System.Globalization;
using System.Windows.Data;

namespace TimotheusUS.MVVMsamples.PropertyChanged
{
    public class SummeryConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is string text1 && values[1] is string text2)
            {
                return $"{text1} - {text2}";
            }
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
