using System;
using System.Windows.Controls;
using System.Windows;

namespace DaanV2.Sudoku.UserControls {
    /// <summary>
    /// Interaction logic for CellControl.xaml
    /// </summary>
    public partial class CellControl : UserControl {

        public Cell ViewModel { get; set; }

        public CellControl() {
            this.InitializeComponent();
        }

        public void Update() {
            if (this.ViewModel == null) {
                return;
            }

            this.ValueBox.Text = this.ViewModel.Value.ToString();
            this.S1.Visibility = this.ViewModel.IsPossible(1) ? Visibility.Visible : Visibility.Hidden;
            this.S2.Visibility = this.ViewModel.IsPossible(2) ? Visibility.Visible : Visibility.Hidden;
            this.S3.Visibility = this.ViewModel.IsPossible(3) ? Visibility.Visible : Visibility.Hidden;
            this.S4.Visibility = this.ViewModel.IsPossible(4) ? Visibility.Visible : Visibility.Hidden;
            this.S5.Visibility = this.ViewModel.IsPossible(5) ? Visibility.Visible : Visibility.Hidden;
            this.S6.Visibility = this.ViewModel.IsPossible(6) ? Visibility.Visible : Visibility.Hidden;
            this.S7.Visibility = this.ViewModel.IsPossible(7) ? Visibility.Visible : Visibility.Hidden;
            this.S8.Visibility = this.ViewModel.IsPossible(8) ? Visibility.Visible : Visibility.Hidden;
            this.S9.Visibility = this.ViewModel.IsPossible(9) ? Visibility.Visible : Visibility.Hidden;
        }

        private void ValueBox_TextChanged(Object sender, TextChangedEventArgs e) {
            if (this.ViewModel != null) {
                Int32 Out = 0;

                if (this.ValueBox.Text == String.Empty) {
                    this.ViewModel.Value = 0;
                    this.Update();
                }
                else if (Int32.TryParse(this.ValueBox.Text, out Out)) {
                    this.ViewModel.Value = Out;
                    this.Update();
                }
            }
        }
    }
}
