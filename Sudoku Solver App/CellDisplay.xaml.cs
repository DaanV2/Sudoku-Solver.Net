using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuSolver
{
    /// <summary>
    /// Interaction logic for CellDislay.xaml
    /// </summary>
    public partial class CellDislay : UserControl
    {
        /// <summary>TODO</summary>
        public Cell DisplayCell { get; private set; }

        /// <summary>TODO</summary>
        public CellDislay()
        {
            InitializeComponent();
        }

        /// <summary>TODO</summary>
        public void Set(Cell value)
        {
            this.DisplayCell = value;
            Update();
        }

        /// <summary>TODO</summary>
        public void Update()
        {
            if (this.DisplayCell.FinalValue == 0)
            {
                this.CellText.Text = this.DisplayCell.CanValuesOutput();
                this.CellText.FontSize = 6;
            }
            else
            {
                this.CellText.Text = this.DisplayCell.FinalValue.ToString();
                this.CellText.FontSize = 12;
            }
        }

        private void CellText_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.DisplayCell == null) return;

            switch (e.Key)
            {
                case Key.D0:
                    this.DisplayCell.FinalValue = 0; Update(); break;
                case Key.D1:
                    this.DisplayCell.FinalValue = 1; Update(); break;
                case Key.D2:
                    this.DisplayCell.FinalValue = 2; Update(); break;
                case Key.D3:
                    this.DisplayCell.FinalValue = 3; Update(); break;
                case Key.D4:
                    this.DisplayCell.FinalValue = 4; Update(); break;
                case Key.D5:
                    this.DisplayCell.FinalValue = 5; Update(); break;
                case Key.D6:
                    this.DisplayCell.FinalValue = 6; Update(); break;
                case Key.D7:
                    this.DisplayCell.FinalValue = 7; Update(); break;
                case Key.D8:
                    this.DisplayCell.FinalValue = 8; Update(); break;
                case Key.D9:
                    this.DisplayCell.FinalValue = 9; Update(); break;
                case Key.Back:
                    this.DisplayCell.FinalValue = 0; Update(); break;

            }
        }
    }
}
