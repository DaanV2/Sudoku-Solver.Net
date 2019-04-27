using System;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    public partial class SudokuBlock {
        ///DOLATER <summary></summary>
        /// <param name="Cells"></param>
        public void Set(SudokuCell[,] Cells) {
            if (Cells == null)
                throw new ArgumentNullException(nameof(Cells));

            if (Cells.GetLength(0) != 3 && Cells.GetLength(1) != 3)
                throw new ArgumentException($"{nameof(Cells)} Needs to be 9x9");

            this._Cells = Cells;

            this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(this.Cells)));
        }

        ///DOLATER <summary></summary>
        /// <param name="Cells"></param>
        /// <param name="XStart"></param>
        /// <param name="YStart"></param>
        public void Set(SudokuCell[,] Cells, Int32 XStart, Int32 YStart) {
            if (Cells == null)
                throw new ArgumentNullException(nameof(Cells));

            if (XStart + 2 >= Cells.GetLength(0) && YStart + 2 >= Cells.GetLength(1))
                throw new ArgumentException($"{nameof(Cells)} Not big enough");

            if (this._Cells == null) this._Cells = new SudokuCell[3, 3];

            for (Int32 X = 0; X < 3; X++) {
                for (Int32 Y = 0; Y < 3; Y++) {
                    this._Cells[X, Y] = Cells[X + XStart, Y + YStart];
                }
            }
        }
    }
}
