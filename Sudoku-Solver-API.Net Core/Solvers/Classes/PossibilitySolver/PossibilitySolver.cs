using System;

namespace DaanV2.Sudoku.Solvers {
    ///DOLATER <summary>add description for class: PossibilitySolver</summary>
    public partial class PossibilitySolver : ISolver {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sudoku"></param>
        public void Solve(Sudoku sudoku) {
            //Reset all
            for (Int32 C = 0; C < sudoku.Board.ColumnCount; C++) {
                for (Int32 R = 0; R < sudoku.Board.ColumnCount; R++) {
                    sudoku.Board[C, R].SetAllPossibilities(true);
                }
            }

            //Test
            Cell T;

            for (Int32 C = 0; C < sudoku.Board.ColumnCount; C++) {
                for (Int32 R = 0; R < sudoku.Board.ColumnCount; R++) {
                    T = sudoku.Board[C, R];

                    if (T.IsDetermined) {
                        sudoku.Blocks[C / 3, R / 3].SetPossiblity(T.Value, false);
                        sudoku.Columns[C].SetPossiblity(T.Value, false);
                        sudoku.Rows[R].SetPossiblity(T.Value, false);
                    }
                }
            }

            //Indepth
            for (Int32 C = 0; C < sudoku.Blocks.GetLength(0); C++) {
                for (Int32 R = 0; R < sudoku.Blocks.GetLength(1); R++) {
                    this.Solve(sudoku, C, R);
                }
            }
        }

        /// <summary></summary>
        /// <param name="sudoku"></param>
        /// <param name="Cb"></param>
        /// <param name="Rb"></param>
        private void Solve(Sudoku sudoku, Int32 Cb, Int32 Rb) {
            ICellArea Block = sudoku.Blocks[Cb, Rb];

            for (Int32 Value = 1; Value < 10; Value++) {
                Int32 Column = PossibilitySolver.IsExcludingColumn(Block, Value);

                if (Column > -1) {
                    for (Int32 R = 0; R < sudoku.Blocks.GetRowCount(); R++) {
                        if (R != Rb) {
                            sudoku.Blocks[Cb, R].ColumnForEach(Column, (x) => x.SetPossibilty(Value, false));
                        }
                    }
                }

                Int32 Row = PossibilitySolver.IsExcludingRow(Block, Value);
                if (Row > -1) {
                    for (Int32 C = 0; C < sudoku.Blocks.GetColumnCount(); C++) {
                        if (C != Cb) {
                            sudoku.Blocks[C, Rb].RowForEach(Row, (x) => x.SetPossibilty(Value, false));
                        }
                    }
                }
            }
        }
    }
}
