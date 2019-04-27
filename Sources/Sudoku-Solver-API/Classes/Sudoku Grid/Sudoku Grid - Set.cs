using System;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    public partial class SudokuGrid {
        ///DOLATER <summary></summary>
        /// <param name="Cells"></param>
        public void Set(SudokuCell[,] Cells) {
            if (Cells == null)
                throw new ArgumentNullException(nameof(Cells));

            if (Cells.GetLength(0) != 9 && Cells.GetLength(1) != 9)
                throw new ArgumentException($"{nameof(Cells)} Needs to be 9x9");

            this._Cells = Cells;

            if (this._Blocks == null) this._Blocks = new SudokuBlock[3, 3];

            for (Int32 X = 0; X < 3; X++) {
                for (Int32 Y = 0; Y < 3; Y++) {
                    if (this._Blocks[X, Y] == null) this._Blocks[X, Y] = new SudokuBlock();

                    this._Blocks[X, Y].Set(this._Cells, X * 3, Y * 3);
                }
            }

            this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(this.Cells)));
        }
    }
}
