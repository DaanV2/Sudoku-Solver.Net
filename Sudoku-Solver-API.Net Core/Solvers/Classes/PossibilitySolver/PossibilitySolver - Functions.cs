using System;

namespace DaanV2.Sudoku.Solvers {
    ///DOLATER <summary>add description for class: PossibilitySolver</summary>
    public partial class PossibilitySolver : ISolver {

        public static Int32 IsExcludingColumn(ICellArea area, Int32 Value) {
            Int32 ColumnCount = 0;
            Int32 Out = -1;

            for (Int32 C = 0; C < area.ColumnCount; C++) {
                //Count all in the column
                if (area.ColumnAny(C, (x) => x.Value == Value)) {
                    ColumnCount++;
                    Out = C;
                }
            }

            return ColumnCount > 1 ?
                -1 :
                Out;
        }

        public static Int32 IsExcludingRow(ICellArea area, Int32 Value) {
            Int32 RowCount = 0;
            Int32 Out = -1;

            for (Int32 R = 0; R < area.RowCount; R++) {
                //Count all in the column
                if (area.RowAny(R, (x) => x.Value == Value)) {
                    RowCount++;
                    Out = R;
                }
            }

            return RowCount > 1 ?
                -1 :
                Out;
        }
    }
}
