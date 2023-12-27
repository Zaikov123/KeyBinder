using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace KeyBinderV1.Converters
{
    public class ObservableCollectionToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is System.Collections.IEnumerable collection)
            {
                return string.Join(Environment.NewLine, collection.OfType<string>());
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
