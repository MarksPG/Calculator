using System.ComponentModel;
using TextileCalculatorApp.DataProvider;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.ViewModel
{
    public class TextilePictureViewModel : INotifyPropertyChanged
    {
        
        public TextilePictureViewModel()
        {
              
        }
        
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

        public event PropertyChangedEventHandler PropertyChanged;

    }

}
		



    




