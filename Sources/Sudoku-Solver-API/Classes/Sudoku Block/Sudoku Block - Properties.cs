using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    public partial class SudokuBlock {
        ///DOLATER <summary>/// </summary>
        public SudokuCell[,] Cells { get => this._Cells; private set => this._Cells = value; }
    }
}
