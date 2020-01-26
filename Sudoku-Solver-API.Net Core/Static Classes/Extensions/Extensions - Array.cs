using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Extensions</summary>
    public static partial class Extensions {
        public static Int32 GetColumnCount<T>(this T[,] Items) {
            return Items.GetLength(0);
        }

        public static Int32 GetRowCount<T>(this T[,] Items) {
            return Items.GetLength(1);
        }
    }
}
