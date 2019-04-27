using System;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    ///DOLATER <summary> add description for class: SudokuGrid</summary>
	[Serializable]
    public partial class SudokuGrid {
        /// <summary>Creates a new instance of <see cref="SudokuGrid"/></summary>
        public SudokuGrid() {
            this._Cells = new SudokuCell[9, 9];

            for (Int32 X = 0; X < this._Cells.GetLength(0); X++) {
                for (Int32 Y = 0; Y < this._Cells.GetLength(0); Y++) {
                    this._Cells[X, Y] = new SudokuCell();
                }
            }

            this.Set(this._Cells);
        }
    }
}
