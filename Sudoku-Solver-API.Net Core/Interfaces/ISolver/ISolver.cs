namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for interface: ISolver</summary>
    public interface ISolver : ISolver<Sudoku> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sudoku"></param>
        new void Solve(Sudoku sudoku);
    }
}
