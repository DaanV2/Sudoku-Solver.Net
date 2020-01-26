using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Sudoku {
    public partial class Sudoku{
        /// <summary>
        /// 
        /// </summary>
        public ICellArea Board { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICellArea[,] Blocks { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICellCollection[] Columns { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICellCollection[] Rows { get; }
    }
}
