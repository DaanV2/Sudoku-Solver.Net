namespace DaanV2.Sudoku {
    public partial class CellCollection {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cells"></param>
        public static implicit operator CellCollection(Cell[] Cells) {
            return new CellCollection(Cells);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cells"></param>
        public static implicit operator Cell[](CellCollection Cells) {
            return Cells._Cells;
        }
    }
}
