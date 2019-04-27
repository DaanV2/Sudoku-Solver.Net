using System;
using System.Xml.Serialization;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    public partial class SudokuCell {
        ///DOLATER <summary></summary>
        /// <returns></returns>
        public override String ToString() {
            return this.Value.ToString();
        }
    }
}
