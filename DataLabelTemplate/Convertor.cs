using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLabelTemplate
{
    public class ValueToValueConverter : IValueConverter
    {
        private double sumOfValues = 0;
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null || !(value is double))
                return null;

            double numericValue = (double)value;
            sumOfValues += numericValue;
            if (numericValue == 0)
                return sumOfValues;
            else
                return numericValue;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ValueToColorConverter : IValueConverter
    {
        [Obsolete]
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || !(value is double))
                return Colors.Transparent;

            double numericValue = (double)value;
            if (numericValue == 0)
                return Color.FromHex("#3333cc");
            else
                return numericValue > 0 ? Color.FromHex("#3bab46") : Color.FromHex("#df3320");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ValueToImageConvertor : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null || !(value is double))
                return null;

            double numericValue = (double)value;
            if (numericValue == 0)
                return null;
            else
                return numericValue > 0 ? "up.png" : "down.png";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
