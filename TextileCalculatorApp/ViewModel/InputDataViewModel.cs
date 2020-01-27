using TextileCalculatorApp.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TextileCalculatorApp.ViewModel
{
    public class InputDataViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<InputData> InputDataCollection;

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


    






