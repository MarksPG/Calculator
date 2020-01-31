using System;
using Windows.UI.Xaml.Data;

namespace TextileCalculatorApp.Converters
{
    class DoubleToPriceStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value is double)
            {
                return $"{value} kr";
            }
            throw new ArgumentException("Value is not a double");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

    }
}
