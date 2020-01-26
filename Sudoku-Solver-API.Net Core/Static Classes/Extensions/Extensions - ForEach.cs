using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Extensions</summary>
    public static partial class Extensions {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static void ForEach(this Cell[,] area, Action<Cell> action) {
            Int32 ColumnCount = area.GetLength(0);
            Int32 RowCount = area.GetLength(1);

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
        public static void ForEach(this Cell[] cells, Action<Cell> action) {
            Int32 Count = cells.Length;

            for (Int32 I = 0; I < Count; I++) {
                action.Invoke(cells[I]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        /// <param name="action"></param>
        public static void ForEach(this ICellCollection cells, Action<Cell> action) {
            Int32 Count = cells.Count;

            for (Int32 I = 0; I < Count; I++) {
                action.Invoke(cells[I]);
            }
        }
    }
}
