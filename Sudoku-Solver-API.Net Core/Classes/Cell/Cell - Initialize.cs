using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Cell</summary>
    public partial class Cell {
        /// <summary>Creates a new instance of <see cref="Cell"/></summary>
        public Cell() : this(0) { }

        /// <summary>Creates a new instance of <see cref="Cell"/></summary>
        public Cell(Int32 Value) {
            this.Value = Value;
        }
    }
}
