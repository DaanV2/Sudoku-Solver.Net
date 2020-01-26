using System;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>Add description for interface: ICellArea</summary>
    public interface ICellArea {
        /// <summary>
        /// 
        /// </summary>
        Int32 RowCount { get; }

        /// <summary>
        /// 
        /// </summary>
        Int32 ColumnCount { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Column"></param>
        /// <param name="Row"></param>
        /// <returns></returns>
        Cell this[Int32 Column, Int32 Row] { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Loctation"></param>
        /// <returns></returns>
        Cell this[ILocation Location] { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Loctation"></param>
        /// <returns></returns>
        ICellArea this[IArea Area] { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Column"></param>
        /// <returns></returns>
        ICellCollection GetColumn(Int32 Column);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ICellCollection GetRow(Int32 Row);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartColumn"></param>
        /// <param name="EndColumn"></param>
        /// <returns></returns>
        ICellArea GetArea(Int32 StartColumn, Int32 EndColumn, Int32 StartRow, Int32 EndRow);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartColumn"></param>
        /// <param name="EndColumn"></param>
        /// <returns></returns>
        ICellArea GetArea(IArea Area);
    }
}
