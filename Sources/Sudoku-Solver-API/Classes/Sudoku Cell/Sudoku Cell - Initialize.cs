using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    ///DOLATER <summary> add description for class: SudokuCell</summary>
	[Serializable]
    public partial class SudokuCell {
        /// <summary>Creates a new instance of <see cref="SudokuCell"/></summary>
        public SudokuCell() {
            this._Can1 = false;
            this._Can2 = false;
            this._Can3 = false;
            this._Can4 = false;
            this._Can5 = false;
            this._Can6 = false;
            this._Can7 = false;
            this._Can8 = false;
            this._Can9 = false;
            this.Determined = false;
            this.Value = -1;
        }
    }
}
