
using System;
using System.Globalization;
using System.Windows.Data;

namespace KnowledgeBase.ValueConverters
{
    public class BirthDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is DateTime birthDate)
            {
                return birthDate.ToString("dd.MM.yyyy");
            }

            return "Не указано";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
