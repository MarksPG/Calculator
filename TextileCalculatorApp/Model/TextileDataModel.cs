using System.ComponentModel;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.Model
{
    class TextileDataModel
    {

    }

    public class TextileData : INotifyPropertyChanged
    {

        private Textile _textile;

        public string Description
        {
            get
            {
                return _textile.Description;
            }
        }

        public TextileData(Textile textile)
        {
            _textile = textile;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

