using System.ComponentModel;



namespace TextileCalculatorApp.Model
{
    class InputDataModel
    {

    }

    public class InputData : INotifyPropertyChanged
    {
        private string _inputLength;

        private string _inputNumber;

        private string _selectedSuspension;

        private string _inputFactor;

        public string InputLength
        {
            get { return _inputLength; }
            
            set
            {
                if (_inputLength != value)
                {
                    _inputLength = value;
                    RaisePropertyChanged("InputLength");
                }
            }
        }

        public string InputNumber
        {
            get { return _inputNumber; }

            set
            {
                if (_inputNumber != value)
                {
                    _inputNumber = value;
                    RaisePropertyChanged("InputNumber");
                }
            }
        }

        public string SelectedSuspension
        {
            get { return _selectedSuspension; }

            set
            {
                if (_selectedSuspension != value)
                {
                    _selectedSuspension = value;
                    RaisePropertyChanged("SelectedSuspension");
                }
            }
        }

        public string InputFactor
        {
            get { return _inputFactor; }

            set
            {
                if (_inputFactor != value)
                {
                    _inputFactor = value;
                    RaisePropertyChanged("InputFactor");
                }
            }
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


