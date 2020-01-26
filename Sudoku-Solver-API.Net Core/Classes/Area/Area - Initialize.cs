using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Area</summary>
    public partial class Area {
        /// <summary>Creates a new instance of <see cref="Area"/></summary>
        public Area() {
            this._Cells = null;
            this._Rows = 0;
            this._Columns = 0;
        }

        /// <summary>Creates a new instance of <see cref="Area"/></summary>
        public Area(Cell[,] Cells) {
            this._Cells = Cells;
            this._Columns = Cells.GetLength(0);
            this._Rows = Cells.GetLength(1);
        }

        /// <summary>Creates a new instance of <see cref="Area"/></summary>
        public Area(Cell[] Cells) {
            this._Cells = new Cell[Cells.Length, 1];
            this._Columns = Cells.GetLength(0);
            this._Rows = 0;

            for (Int32 I = 0; I < this._Columns; I++) {
                this._Cells[I, 0] = Cells[I];
            }
        }
    }
}
