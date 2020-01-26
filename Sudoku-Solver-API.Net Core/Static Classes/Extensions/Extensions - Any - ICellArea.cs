using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Extensions</summary>
    public static partial class Extensions {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Boolean Any(this ICellArea area, Func<Cell, Boolean> action) {
            Int32 ColumnCount = area.ColumnCount;
            Int32 RowCount = area.RowCount;

            for (Int32 C = 0; C < ColumnCount; C++) {
                for (Int32 R = 0; R < RowCount; R++) {
                    if (action.Invoke(area[C, R])) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static Boolean ColumnAny(this ICellArea area, Int32 Column, Func<Cell, Boolean> action) {
            Int32 ColumnCount = area.ColumnCount;
            Int32 RowCount = area.RowCount;

            for (Int32 R = 0; R < RowCount; R++) {
                if (action.Invoke(area[Column, R])) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static Boolean RowAny(this ICellArea area, Int32 Row, Func<Cell, Boolean> action) {
            Int32 ColumnCount = area.ColumnCount;
            Int32 RowCount = area.RowCount;

            for (Int32 C = 0; C < ColumnCount; C++) {
                if (action.Invoke(area[C, Row])) {
                    return true;
                }
            }

            return false;
        }
    }
}
