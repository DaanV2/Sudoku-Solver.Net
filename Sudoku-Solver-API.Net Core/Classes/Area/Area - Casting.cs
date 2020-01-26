namespace DaanV2.Sudoku {
    public partial class Area {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cells"></param>
        public static implicit operator Area(Cell[,] Cells) {
            return new Area(Cells);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cells"></param>
        public static implicit operator Area(Cell[] Cells) {
            return new Area(Cells);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="area"></param>
        public static implicit operator Cell[,](Area area) {
            return area._Cells;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Collection"></param>
        public static implicit operator Area(CellCollection Collection) {
            return new Area(Collection);
        }
    }
}
