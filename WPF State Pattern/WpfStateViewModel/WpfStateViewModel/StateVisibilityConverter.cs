using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace WpfStateViewModel
{
    public class StateVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool shouldConvert = value != null &&
                                 typeof(ViewModelState).IsAssignableFrom(value.GetType()) &&
                                 targetType == typeof(Visibility) &&
                                 parameter != null &&
                                 parameter.GetType() == typeof(string);

            if (shouldConvert)
            {
                var state = (ViewModelState)value;
                
                string[] visibleWhenStates = ((string)parameter)
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                if (visibleWhenStates.Contains(state.ViewModelStateName))
                    return Visibility.Visible;
                else
                    return Visibility.Collapsed;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
