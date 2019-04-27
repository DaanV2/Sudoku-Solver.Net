using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    ///DOLATER <summary></summary>
    [ValueConversion(typeof(Boolean), typeof(Visibility))]
    public partial class BoolToVisibillityConverter : IValueConverter {
        ///DOLATER <summary></summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Boolean Temp = (Boolean)value;

            return Temp ? Visibility.Visible : (Object)Visibility.Hidden;
        }

        ///DOLATER <summary></summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            Visibility Temp = (Visibility)value;

            switch (Temp) {
                case Visibility.Hidden:
                case Visibility.Collapsed:
                    return false;                
                case Visibility.Visible:
                    return true;
            }

            return true;
        }
    }
}
