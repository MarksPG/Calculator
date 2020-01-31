using System.ComponentModel;


namespace TextileCalculatorApp.Model
{
    class PictureDataModel
    {

    }

    public class PictureData : INotifyPropertyChanged
    {
        private string _url;

        public string Url
        {
            get { return _url; }

            set
            {
                if (_url != value)
                {
                    _url = value;
                    RaisePropertyChanged("Url");
                }
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
