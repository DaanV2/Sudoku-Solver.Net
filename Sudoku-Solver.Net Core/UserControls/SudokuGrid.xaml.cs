using System.Windows.Controls;

namespace DaanV2.Sudoku.UserControls {
    /// <summary>
    /// Interaction logic for SudokuGrid.xaml
    /// </summary>
    public partial class SudokuGrid : UserControl {
        private Sudoku _Viewmodel;

        public Sudoku Viewmodel {
            get => this._Viewmodel;
            set {
                this._Viewmodel = value;

                if (value != null) {
                    this.C1R1.ViewModel = value.Blocks[0, 0];
                    this.C1R2.ViewModel = value.Blocks[0, 1];
                    this.C1R3.ViewModel = value.Blocks[0, 2];

                    this.C2R1.ViewModel = value.Blocks[1, 0];
                    this.C2R2.ViewModel = value.Blocks[1, 1];
                    this.C2R3.ViewModel = value.Blocks[1, 2];

                    this.C3R1.ViewModel = value.Blocks[2, 0];
                    this.C3R2.ViewModel = value.Blocks[2, 1];
                    this.C3R3.ViewModel = value.Blocks[2, 2];
                }

                Update();
            }
        }

        public SudokuGrid() {
            this.InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Update() {
            this.C1R1.Update();
            this.C1R2.Update();
            this.C1R3.Update();

            this.C2R1.Update();
            this.C2R2.Update();
            this.C2R3.Update();

            this.C3R1.Update();
            this.C3R2.Update();
            this.C3R3.Update();
        }
    }
}
