using System;

namespace DaanV2.Sudoku {
    public partial class Area : ICellArea {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Loctation"></param>
        /// <returns></returns>
        public Cell this[ILocation Location] { get => this._Cells[Location.Column, Location.Row]; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Location"></param>
        /// <returns></returns>
        public ICellArea this[IArea Area] { get => this.GetArea(Area); }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Column"></param>
        /// <param name="Row"></param>
        /// <returns></returns>
        public Cell this[Int32 Column, Int32 Row] { get => this._Cells[Column, Row]; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 RowCount { get => this._Rows; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 ColumnCount { get => this._Columns; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="StartColumn"></param>
        /// <param name="EndColumn"></param>
        /// <param name="StartRow"></param>
        /// <param name="EndRow"></param>
        /// <returns></returns>
        public ICellArea GetArea(Int32 StartColumn, Int32 EndColumn, Int32 StartRow, Int32 EndRow) {
            Int32 ColumnCount = EndColumn - StartColumn;
            Int32 RowCount = EndRow - StartRow;

            Cell[,] Cells = new Cell[ColumnCount, RowCount];

            //Grabs the smallest
            ColumnCount = ColumnCount < this.ColumnCount ? ColumnCount : this.ColumnCount;
            RowCount = RowCount < this.RowCount ? RowCount : this.RowCount;

            for (Int32 C = 0; C < ColumnCount; C++) {
                for (Int32 R = 0; R < RowCount; R++) {
                    Cells[C, R] = this._Cells[C + StartColumn, R + StartRow];
                }
            }

            return new Area(Cells);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Area"></param>
        /// <returns></returns>
        public ICellArea GetArea(IArea Area) {
            return this.GetArea(Area.StartColumn, Area.EndColumn, Area.StartRow, Area.EndRow);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Column"></param>
        /// <returns></returns>
        public ICellCollection GetColumn(Int32 Column) {
            Int32 Count = this.RowCount;
            Cell[] Cells = new Cell[Count];

            for (Int32 I = 0; I < Count; I++) {
                Cells[I] = this._Cells[Column, I];
            }

            return new CellCollection(Cells);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Row"></param>
        /// <returns></returns>
        public ICellCollection GetRow(Int32 Row) {
            Int32 Count = this.ColumnCount;
            Cell[] Cells = new Cell[Count];

            for (Int32 I = 0; I < Count; I++) {
                Cells[I] = this._Cells[I, Row];
            }

            return new CellCollection(Cells);
        }
    }
}
