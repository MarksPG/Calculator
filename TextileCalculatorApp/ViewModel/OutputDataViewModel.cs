using System.ComponentModel;
using System.Threading.Tasks;
using TextileCalculatorApp.DataProvider;

namespace TextileCalculatorApp.ViewModel
{
    public class OutputDataViewModel : INotifyPropertyChanged
    {

        private DTO.CalculatedPrice _result;

        public DTO.CalculatedPrice Result
        {
            get => _result;
            set
            {
                _result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }


        public OutputDataViewModel()
        {
            LoadDefaultOutput();
        }


        public void LoadDefaultOutput()
        {
            DTO.CalculatedPrice outputDataCollection = new DTO.CalculatedPrice
            {
                CustomerPrice = 2500, RetailerCost = 1000    
            };

            Result = outputDataCollection;
        }

        public void GetCalculatedPriceObject(DTO.CustomerSelectedData csd)
        {
            TextileDataProvider tdp = new TextileDataProvider();

            Task<DTO.CalculatedPrice> data = Task.Run<DTO.CalculatedPrice>(async () => await tdp.SendDataForCalculationAsync(csd));
            var output = data.Result;

            Result = output;

        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
