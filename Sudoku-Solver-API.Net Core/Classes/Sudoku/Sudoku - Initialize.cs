using System;
using System.Text.Json.Serialization;

namespace DaanV2.Sudoku {
    ///DOLATER <summary>add description for class: Sudoku</summary>
    [JsonConverter(typeof(Serialization.Json.SudokuConverter))]
    public partial class Sudoku {
        /// <summary>Creates a new instance of <see cref="Sudoku"/></summary>
        public Sudoku() {
            //Initialize cells
            Cell[,] Cells = new Cell[9, 9];

            for (Int32 C = 0; C < 9; C++) {
                for (Int32 R = 0; R < 9; R++) {
                    Cells[C, R] = new Cell();
                }
            }

            this.Board = (Area)Cells;

            //Blocks
            this.Blocks = new Area[3, 3];

            for (Int32 C = 0; C < this.Blocks.GetLength(0); C++) {
                for (Int32 R = 0; R < this.Blocks.GetLength(1); R++) {
                    this.Blocks[C, R] = this.Board.GetArea(C * 3, (C + 1) * 3, R * 3, (R + 1) * 3);
                }
            }

            //Rows and Columns
            this.Columns = new ICellCollection[9];
            this.Rows = new ICellCollection[9];

            for (Int32 I = 0; I < 9; I++) {
                this.Columns[I] = this.Board.GetColumn(I);
                this.Rows[I] = this.Board.GetRow(I);
            }
        }
    }
}
