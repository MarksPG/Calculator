using TextileCalculatorApp.Model;
using System.ComponentModel;

namespace TextileCalculatorApp.ViewModel
{
    public class InputDataViewModel : INotifyPropertyChanged
    {

        private InputData _inputData = null;
        public InputData InputData
        {
            get { return _inputData; }
            set
            {
                if (_inputData != value)
                {
                    _inputData = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("InputData"));
                    }
                }
            }
        }

        public InputDataViewModel()
        {
            LoadDefaultInput();
        }


        public void LoadDefaultInput()
        {
            var inputData = new InputData { InputLength = "240", InputNumber = "1", SelectedSuspension = "Wave", InputFactor = "2.5" };

            InputData = inputData;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}


    






