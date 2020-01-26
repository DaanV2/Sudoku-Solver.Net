using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Sudoku {
    public partial class Cell : IEquatable<Cell> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as Cell);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals([AllowNull] Cell other) {
            return other != null &&
                   this.IsDetermined == other.IsDetermined;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this.Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(Cell left, Cell right) {
            return EqualityComparer<Cell>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(Cell left, Cell right) {
            return !(EqualityComparer<Cell>.Default.Equals(left, right));
        }
    }
}
