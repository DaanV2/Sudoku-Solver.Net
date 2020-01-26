using System;

namespace DaanV2.Sudoku {
    public partial class CellCollection : ICellCollection {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public Cell this[Int32 Index] { get => this._Cells[Index]; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Count { get => this._Count; }
    }
}
