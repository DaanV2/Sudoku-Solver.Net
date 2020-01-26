using System;

namespace DaanV2.Sudoku {
    public partial class Cell {


        /// <summary></summary>
        public Int32 Value {
            get => this._Value;
            set {
                this._Value = value;

                if (this._Value > 0 && this._Value < 10) {
                    this._Determined = true;
                    this._Possibilities = null;
                }
                else {
                    this._Determined = false;
                    this._Possibilities = new Boolean[10];
                }
            }
        }

        public Boolean IsDetermined {
            get => this._Determined;
        }
    }
}
