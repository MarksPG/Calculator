using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace TextileCalculatorApp.Converters
{
    class ImageSourceConverter : IValueConverter
    {
        public ImageSource ImageSource;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string)
            {
                Uri uri = new Uri(value as string, UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                ImageSource = imgSource;
                return ImageSource;
            }
            throw new ArgumentException("Value is not a string");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }




}
