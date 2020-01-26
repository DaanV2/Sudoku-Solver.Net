using System;

namespace DaanV2.Sudoku {
    public partial class Cell {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public Boolean IsPossible(Int32 Value) {
            return this._Determined ? 
                false :
                this._Possibilities[Value];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Value"></param>
        public void SetPossibilty(Int32 Value, Boolean State) {
            if (this._Determined) {
                return;
            }

            this._Possibilities[Value] = State;
        }

        public void SetAllPossibilities(Boolean State) {
            if (this._Determined) {
                return;
            }

            for (Int32 I = 0; I < this._Possibilities.Length; I++) {
                this._Possibilities[I] = State;
            }
        }
    }
}
