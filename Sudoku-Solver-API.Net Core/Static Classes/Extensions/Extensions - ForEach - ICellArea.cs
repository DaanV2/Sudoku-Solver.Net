using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Extensions</summary>
    public static partial class Extensions {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static void ForEach(this ICellArea area, Action<Cell> action) {
            Int32 ColumnCount = area.ColumnCount;
            Int32 RowCount = area.RowCount;

            for (Int32 C = 0; C < ColumnCount; C++) {
                for (Int32 R = 0; R < RowCount; R++) {
                    action.Invoke(area[C, R]);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static void ColumnForEach(this ICellArea area, Int32 Column, Action<Cell> action) {
            Int32 RowCount = area.RowCount;

            for (Int32 R = 0; R < RowCount; R++) {
                action.Invoke(area[Column, R]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static void RowForEach(this ICellArea area, Int32 Row, Action<Cell> action) {
            Int32 ColumnCount = area.ColumnCount;
            Int32 RowCount = area.RowCount;

            for (Int32 C = 0; C < ColumnCount; C++) {
                action.Invoke(area[C, Row]);
            }
        }
    }
}
