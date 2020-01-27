using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextileCalculatorApp.DataProvider;

namespace TextileCalculatorApp.ViewModel
{
    public class CalculateViewModel
    {
        public InputDataViewModel InputDataViewModel { get; set; }

        public TextileSelectionViewModel TextileSelectionViewModel { get; set; }

        
        public CalculateViewModel()
        {
            InputDataViewModel = new InputDataViewModel();
            TextileSelectionViewModel = new TextileSelectionViewModel();
        }

        public void CalculatePrice()
        {

        }
    }
}
