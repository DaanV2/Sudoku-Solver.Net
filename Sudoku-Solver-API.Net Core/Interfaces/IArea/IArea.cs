using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for interface: IArea</summary>
    public interface IArea {
        /// <summary>
        /// 
        /// </summary>
        Int32 StartColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Int32 EndColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Int32 StartRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Int32 EndRow { get; set; }
    }
}
