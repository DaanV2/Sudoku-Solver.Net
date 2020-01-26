using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Sudoku {
    public partial class Sudoku : IEquatable<Sudoku> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as Sudoku);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals([AllowNull] Sudoku other) {
            return other != null &&
                   EqualityComparer<ICellArea>.Default.Equals(this.Board, other.Board);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Board);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Sudoku left, Sudoku right) {
            return EqualityComparer<Sudoku>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Sudoku left, Sudoku right) {
            return !(left == right);
        }
    }
}
