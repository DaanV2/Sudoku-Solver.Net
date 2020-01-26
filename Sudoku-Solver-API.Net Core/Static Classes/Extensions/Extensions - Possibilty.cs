using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Extensions</summary>
    public static partial class Extensions {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="State"></param>
        public static void SetPossiblity(this ICellCollection Cells, Int32 Value, Boolean State) {
            Int32 Count = Cells.Count;

            for (Int32 I = 0; I < Count; I++) {
                Cells[I].SetPossibilty(Value, State);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="State"></param>
        public static void SetPossiblity(this ICellArea Cells, Int32 Value, Boolean State) {
            Int32 ColumnCount = Cells.ColumnCount;
            Int32 RowCount = Cells.RowCount;

            for (Int32 C = 0; C < ColumnCount; C++) {
                for (Int32 R = 0; R < RowCount; R++) {
                    Cells[C, R].SetPossibilty(Value, State);
                }
            }
        }
    }
}
