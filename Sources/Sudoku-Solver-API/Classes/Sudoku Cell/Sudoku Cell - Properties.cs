using System;
using System.ComponentModel;
using System.Xml.Serialization;

//DOLATER prune namespace: DaanV2.Sudoku
namespace DaanV2.Sudoku {
    public partial class SudokuCell {


        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can1 {
            get => this._Can1;
            set {
                this._Can1 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can1)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can2 {
            get => this._Can2;
            set {
                this._Can2 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can2)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can3 {
            get => this._Can3;
            set {
                this._Can3 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can3)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can4 {
            get => this._Can4;
            set {
                this._Can4 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can4)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can5 {
            get => this._Can5;
            set {
                this._Can5 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can5)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can6 {
            get => this._Can6;
            set {
                this._Can6 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can6)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can7 {
            get => this._Can7;
            set {
                this._Can7 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can7)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can8 {
            get => this._Can8;
            set {
                this._Can8 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can8)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public Boolean Can9 {
            get => this._Can9;
            set {
                this._Can9 = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Can9)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlAttribute]
        public Boolean Determined {
            get => this._Determined;
            set {
                this._Determined = value;

                if (this._Determined) {
                    this.Can1 = false;
                    this.Can2 = false;
                    this.Can3 = false;
                    this.Can4 = false;
                    this.Can5 = false;
                    this.Can6 = false;
                    this.Can7 = false;
                    this.Can8 = false;
                    this.Can9 = false;
                }

                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Determined)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlAttribute]
        public Int16 Value {
            get => this._Value;
            set {
                this._Value = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Value)));
            }
        }

        ///DOLATER <summary></summary>
        [XmlIgnore]
        public String DisplayValue {
            get => this.Determined ? this.Value.ToString() : String.Empty;
            set {
                this.Value = (Int16)(Int16.Parse(value) % 10);
                this.Determined = true;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.DisplayValue)));
            }
        }
    }
}
