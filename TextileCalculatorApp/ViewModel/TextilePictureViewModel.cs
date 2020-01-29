using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TextileCalculatorApp.Converters;
using TextileCalculatorApp.DataProvider;
using TextileCalculatorApp.Models;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace TextileCalculatorApp.ViewModel
{
    public class TextilePictureViewModel : INotifyPropertyChanged
    {
        //public TextileSelectionViewModel TextileSelectionViewModel { get; set; }

        public TextilePictureViewModel()
        {
            //TextilePictureCollection = new ObservableCollection<string>();
            Picture = "https://www.winterstextil.se/wp-content/uploads/2019/11/2850-9.jpg";
            //ShowCurrentColourPicture(TextileSelectionViewModel.SelectedTextileIndex, TextileSelectionViewModel.SelectedColourIndex);
        }

        //private ObservableCollection<string> _textilePictureCollection = null;
        //public ObservableCollection<string> TextilePictureCollection
        //{
        //    get
        //    {
        //        return _textilePictureCollection;
        //    }
        //    set
        //    {
        //        if (_textilePictureCollection != value)
        //        {
        //            _textilePictureCollection = value;
        //            if (this.PropertyChanged != null)
        //            {
        //                this.PropertyChanged(this, new PropertyChangedEventArgs("TextilePictureCollection"));
        //            }
        //        }
        //    }
        //}

        private string _picture;
        public string Picture
        {
            get { return _picture; }
            set
            {
                if (_picture != value)
                {
                    _picture = value;
                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Picture"));
                    }
                }
            }
        }

        public void GetUri(Textile textile, Colour colour)
        {
            TextileDataProvider tdp = new TextileDataProvider();
            Picture = tdp.GetPictureURL(textile, colour);
        }

        //public void ShowCurrentColourPicture(int chosenTextileIndex, int chosenColourIndex)
        //{

        //    Textile chosenTextile = TextileSelectionViewModel.TextileDataCollection[chosenTextileIndex];
        //    Colour chosenColour = TextileSelectionViewModel.Colours[chosenColourIndex];


        //    if (chosenColour != null && chosenTextile != null)
        //    {
        //        TextileDataProvider tdp = new TextileDataProvider();
        //        string uri = tdp.GetPictureURL(chosenTextile, chosenColour);



        //        //TextilePictureCollection.Add(uri);
        //        Picture = uri;
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;

    }

}
		



    




