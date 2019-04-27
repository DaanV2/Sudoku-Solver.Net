using System.Windows.Controls;

namespace DaanV2.Sudoku {
    /// <summary>
    /// Interaction logic for SudokuCellControl.xaml
    /// </summary>
    public partial class SudokuCellControl : UserControl {
        ///DOLATER <summary></summary>
        private SudokuCell _ViewModel;

        ///DOLATER <summary></summary>
        public SudokuCell ViewModel {
            get => this._ViewModel;
            set {
                this._ViewModel = value;
                this.DataContext = value;
            }
        }

        public SudokuCellControl() {
            this.InitializeComponent();
        }
    }
}
