using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextileCalculatorApp.Model;
using System.Collections.ObjectModel;

namespace TextileCalculatorApp.ViewModel
{
    public class InputDataViewModel
    {
        public ObservableCollection<InputData> InputDataCollection { get; set; }

        public ObservableCollection<string> CmbContent { get; set; }




        public void LoadDefaultInput()
        {
            ObservableCollection<InputData> inputDataCollection = new ObservableCollection<InputData>
            {
                new InputData { InputLength = "240", InputNumber = "1", SelectedSuspension = "Wave", InputFactor = "2.5" }
            };

            InputDataCollection = inputDataCollection;

            ObservableCollection<string> cmbContent = new ObservableCollection<string>
            {
                "Wave",
                "Veckband",
                "Påsömnadsglid"
            };
            CmbContent = cmbContent;


        }
    }


}
