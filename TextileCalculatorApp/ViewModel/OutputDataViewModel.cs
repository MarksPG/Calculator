using System.Collections.ObjectModel;
using System.ComponentModel;



namespace TextileCalculatorApp.ViewModel
{
    public class OutputDataViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<DTO.CalculatedPrice> _result;

        public ObservableCollection<DTO.CalculatedPrice> Result
        {
            get => _result;
            set
            {
                _result = value;
                PropertyChanged?.Invoke(this, nameof("Result"));
            }
        }


        public OutputDataViewModel()
        {
            LoadDefaultOutput();
        }


        public void LoadDefaultOutput()
        {
            ObservableCollection<DTO.CalculatedPrice> outputDataCollection = new ObservableCollection<DTO.CalculatedPrice>
            {
                new DTO.CalculatedPrice { CustomerPrice = 2500, RetailerCost = 1000 }
            };

            Result = outputDataCollection;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
