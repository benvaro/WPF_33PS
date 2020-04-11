using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPF_Converter
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = System.Convert.ToInt32(value);
            string result = "";
            switch (number)
            {
                case 0:
                    result = "Zero";
                    break;
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string number = value.ToString();
            int result = 0;
            switch (number)
            {
                case "Zero":
                    result = 0;
                    break;
                case "One":
                    result = 1;
                    break;
                case "Two":
                    result = 2;
                    break;
                case "Three":
                    result = 3;
                    break;
                case "Four":
                    result = 4;
                    break;
                case "Five":
                    result = 5;
                    break;
            }
            return result;
        }
    }
}
