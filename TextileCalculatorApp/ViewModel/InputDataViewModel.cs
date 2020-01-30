using TextileCalculatorApp.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TextileCalculatorApp.ViewModel
{
    public class InputDataViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<InputData> _inputDataCollection = null;
        public ObservableCollection<InputData> InputDataCollection
        {
            get { return _inputDataCollection; }
            set
            {
                if (_inputDataCollection != value)
                {
                    _inputDataCollection = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("InputDataCollection"));
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
            ObservableCollection<InputData> inputDataCollection = new ObservableCollection<InputData>
            {
                new InputData { InputLength = "240", InputNumber = "1", SelectedSuspension = "Wave", InputFactor = "2.5" }
            };

            InputDataCollection = inputDataCollection;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}


    






