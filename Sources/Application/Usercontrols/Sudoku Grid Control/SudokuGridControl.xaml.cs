using System.Windows.Controls;

namespace DaanV2.Sudoku {
    /// <summary>Interaction logic for SudokuGridControl.xaml</summary>
    public partial class SudokuGridControl : UserControl {
        ///DOLATER <summary></summary>
        private SudokuGrid _ViewModel;

        ///DOLATER <summary></summary>
        public SudokuGrid ViewModel {
            get => this._ViewModel;
            set {
                this._ViewModel = value;
                this.DataContext = value;

                this.r0c0.ViewModel = value.Blocks[0, 0];
                this.r1c0.ViewModel = value.Blocks[1, 0];
                this.r2c0.ViewModel = value.Blocks[2, 0];

                this.r0c1.ViewModel = value.Blocks[0, 1];
                this.r1c1.ViewModel = value.Blocks[1, 1];
                this.r2c1.ViewModel = value.Blocks[2, 1];

                this.r0c2.ViewModel = value.Blocks[0, 2];
                this.r1c2.ViewModel = value.Blocks[1, 2];
                this.r2c2.ViewModel = value.Blocks[2, 2];
            }
        }
        public SudokuGridControl() {
            this.InitializeComponent();

            this.ViewModel = new SudokuGrid();
        }
    }
}
