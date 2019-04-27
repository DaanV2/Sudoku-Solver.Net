using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    public partial class SudokuGrid {
        ///DOLATER <summary>/// </summary>
        public SudokuCell[,] Cells { get => this._Cells; set => this.Set(value); }

        ///DOLATER <summary>/// </summary>
        [XmlIgnore]
        public SudokuBlock[,] Blocks{ get => this._Blocks; private set => this._Blocks = value; }
    }
}
