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
            this.Can1 = true;
            this.Can2 = true;
            this.Can3 = true;
            this.Can4 = true;
            this.Can5 = true;
            this.Can6 = true;
            this.Can7 = true;
            this.Can8 = true;
            this.Can9 = true;
            this.Determined = false;
            this.Value = -1;
        }
    }
}
