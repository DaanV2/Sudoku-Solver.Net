using System;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    ///DOLATER <summary> add description for class: SudokuBlock</summary>
	[Serializable]
    public partial class SudokuBlock {
        /// <summary>Creates a new instance of <see cref="SudokuBlock"/></summary>
        public SudokuBlock() {
            this._Cells = new SudokuCell[3, 3];
        }

        /// <summary>Creates a new instance of <see cref="SudokuBlock"/></summary>
        /// <param name="Cells"></param>
        /// <param name="XStart"></param>
        /// <param name="YStart"></param>
        public SudokuBlock(SudokuCell[,] Cells, Int32 XStart, Int32 YStart) : this(){
            this.Set(Cells, XStart, YStart);
        }
    }
}
