using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using TextileCalculatorApp.DataProvider;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.ViewModel
{
    public class TextileSelectionViewModel : INotifyPropertyChanged
    {
        //public static TextileSelectionViewModel Instance { get; private set; }

        //public TextilePictureViewModel TextilePictureViewModel { get; set; }

        public TextileSelectionViewModel()
        {
            APIHelper.InitializeClient();
            LoadTextilesFromDatabase();
            Widths = new ObservableCollection<Width>();
            Colours = new ObservableCollection<Colour>();
            
            PopulateWidthAndColour(TextileDataCollection[SelectedTextileIndex]);
            SelectedWidthIndex = 0;
            SelectedColourIndex = 0;

            //Instance = this;
            //TextilePictureViewModel = new TextilePictureViewModel();
        }


        private ObservableCollection<Textile> _textileDataCollection = null;
        public ObservableCollection<Textile> TextileDataCollection
        {
            get { return _textileDataCollection; }
            set
            {
                if (_textileDataCollection != value)
                {
                    _textileDataCollection = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("TextileDataCollection"));
                    }
                }
            }
        }

        private ObservableCollection<Width> _widths = null;
        public ObservableCollection<Width> Widths
        {
            get { return _widths; }
            set
            {
                if (_widths != value)
                {
                    _widths = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Widths"));
                    }
                }
            }
        }

        private ObservableCollection<Colour> _colours = null;
        public ObservableCollection<Colour> Colours
        {
            get { return _colours; }
            set
            {
                if (_colours != value)
                {
                    _colours = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Colours"));
                    }
                }
            }
        }


        internal void LoadTextilesFromDatabase()
        {
            TextileDataProvider tdp = new TextileDataProvider();

            Task<List<Textile>> data = Task.Run<List<Textile>>(async () => await tdp.GetTextiles());
            var importedData = data.Result;

            ObservableCollection<Textile> textileDatas = new ObservableCollection<Textile>();
            

            foreach (Textile item in importedData)
            {
                textileDatas.Add(item);
            }

            TextileDataCollection = textileDatas;

        }

        private Textile _selectedTextile;
        public Textile SelectedTextile
        {
            get { return _selectedTextile; }
            set
            {
                if (_selectedTextile != value)
                {
                    _selectedTextile = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedTextile)));
                }
            }
        }

        private int _selectedTextileIndex;
        public int SelectedTextileIndex
        {
            get { return _selectedTextileIndex; }
            set
            {
                if (_selectedTextileIndex != value)
                {
                    _selectedTextileIndex = value;
                    PopulateWidthAndColour(TextileDataCollection[value]);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedTextileIndex)));
                }
            }
        }

        private Width _selectedWidth;
        public Width SelectedWidth
        {
            get { return _selectedWidth; }
            set
            {
                if (_selectedWidth != value)
                {
                    _selectedWidth = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedWidth)));
                }
            }
        }

        private int _selectedWidthIndex;
        public int SelectedWidthIndex
        {
            get { return _selectedWidthIndex; }
            set
            {
                if (_selectedWidthIndex != value)
                {
                    _selectedWidthIndex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedWidthIndex)));
                }
            }
        }

        private Colour _selectedColour;
        public Colour SelectedColour
        {
            get { return _selectedColour; }
            set
            {
                if (_selectedColour != value)
                {
                    _selectedColour = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedColour)));
                }
            }
        }

        private int _selectedColourIndex;
        public int SelectedColourIndex
        {
            get { return _selectedColourIndex; }
            set
            {
                if (_selectedColourIndex != value)
                {
                    _selectedColourIndex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedColourIndex)));
                }
            }
        }

        private void PopulateWidthAndColour(Textile selectedTextile)
        {
            Widths.Clear();
            Colours.Clear();
            
            foreach (var colour in selectedTextile.Colours)
            {
                Colours.Add(colour);
            }
            SelectedColourIndex = 0;

            foreach (var width in selectedTextile.Widths)
            {
                Widths.Add(width);
            }
            SelectedWidthIndex = 0;
            



        }

        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
