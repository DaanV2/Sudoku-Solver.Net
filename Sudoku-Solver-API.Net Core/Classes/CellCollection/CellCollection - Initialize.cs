using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: CellCollection</summary>
    public partial class CellCollection {
        /// <summary>Creates a new instance of <see cref="CellCollection"/></summary>
        public CellCollection() {
            this._Cells = null;
            this._Count = 0;
        }

        /// <summary>Creates a new instance of <see cref="CellCollection"/></summary>
        public CellCollection(Cell[] Cells) {
            this._Cells = Cells;
            this._Count = Cells.Length;
        }
    }
}
