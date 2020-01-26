using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>Add description for interface: ICellCollection</summary>
    public interface ICellCollection {
        /// <summary>
        /// 
        /// </summary>
        Int32 Count { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        Cell this[Int32 Index] { get; }
    }
}
