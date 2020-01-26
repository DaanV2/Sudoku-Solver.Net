using System;
using System.Globalization;
using System.Windows.Data;

namespace DaanV2.Sudoku.Converters {
    ///DOLATER <summary>add description for class: IntToStringConverter</summary>
    public partial class IntToStringConverter : IValueConverter {

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value is Int32 Int32Value) {
                return Int32Value.ToString();
            }

            return value.ToString();
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value is String StringValue) {
                return Int32.Parse(StringValue);
            }

            return 0;
        }
    }
}
