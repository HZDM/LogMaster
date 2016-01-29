using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace logviewer
{
    [ValueConversion(typeof(byte[]), typeof(string))]
    class ByteArrayConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            /*
            byte[] bytes = (byte[])value;
            StringBuilder sb = new StringBuilder(1000);
            for (int x = 0; x < bytes.Length; x++)
            {
                sb.Append(bytes[x].ToString()).Append(" ");
            }
            return sb.ToString();
            */
            return BitConverter.ToString((byte[])value).Replace("-", " ");
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
