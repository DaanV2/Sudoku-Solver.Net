using System;
using DaanV2.Sudoku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Serialization.Json {
    ///DOLATER <summary>add description for class: SudokuSerialization</summary>
    [TestClass]
    public partial class SudokuSerialization {
        /// <summary>
        /// 
        /// </summary>
        public void SerializeTest() {
            Int32 I = 0;
            Sudoku Out = new Sudoku();
            Out.Board.ForEach((x) => x.Value = I++);
        }
    }
}
