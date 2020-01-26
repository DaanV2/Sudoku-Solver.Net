using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for interface: ISolver</summary>
    public interface ISolver<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        void Solve(T ToSolve);
    }
}
