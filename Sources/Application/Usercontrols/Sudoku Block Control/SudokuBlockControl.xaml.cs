using System.Windows.Controls;

namespace DaanV2.Sudoku {
    /// <summary>
    /// Interaction logic for SudokuBlockControl.xaml
    /// </summary>
    public partial class SudokuBlockControl : UserControl {
        ///DOLATER <summary></summary>
        private SudokuBlock _ViewModel;

        ///DOLATER <summary></summary>
        public SudokuBlock ViewModel {
            get => this._ViewModel;
            set {
                this._ViewModel = value;
                this.DataContext = value;

                this.r0c0.ViewModel = value.Cells[0, 0];
                this.r1c0.ViewModel = value.Cells[1, 0];
                this.r2c0.ViewModel = value.Cells[2, 0];

                this.r0c1.ViewModel = value.Cells[0, 1];
                this.r1c1.ViewModel = value.Cells[1, 1];
                this.r2c1.ViewModel = value.Cells[2, 1];

                this.r0c2.ViewModel = value.Cells[0, 2];
                this.r1c2.ViewModel = value.Cells[1, 2];
                this.r2c2.ViewModel = value.Cells[2, 2];
            }
        }

        public SudokuBlockControl() {
            this.InitializeComponent();

        }
    }
}
