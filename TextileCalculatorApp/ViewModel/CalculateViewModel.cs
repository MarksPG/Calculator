using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextileCalculatorApp.DataProvider;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.ViewModel
{
    public class CalculateViewModel
    {
        public TextileSelectionViewModel TextileSelectionViewModel { get; set; }

        public TextilePictureViewModel TextilePictureViewModel { get; set; }

        public InputDataViewModel InputDataViewModel { get; set; }

        public OutputDataViewModel OutputDataViewModel { get; set; }




        public CalculateViewModel()
        {
            InputDataViewModel = new InputDataViewModel();
            TextileSelectionViewModel = new TextileSelectionViewModel();
            TextilePictureViewModel = new TextilePictureViewModel();
            OutputDataViewModel = new OutputDataViewModel();
            TextileSelectionViewModel.PropertyChanged += OnTextileColourIndexChanged;
            OutputDataViewModel.PropertyChanged += OnCalculatePriceButtonClick;
              
        }

        private void OnCalculatePriceButtonClick(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName is "CalculateButtonClick")
            {
                var calculationBasis = GetCalculationBasis();
            }

        }

        private DTO.CustomerSelectedData GetCalculationBasis()
        {
            
            DTO.CustomerSelectedData csd = new DTO.CustomerSelectedData()
            {
                InputLength = InputDataViewModel.InputDataCollection[0].InputLength,
                InputNumber = InputDataViewModel.InputDataCollection[0].InputNumber,
                InputFactor = InputDataViewModel.InputDataCollection[0].InputFactor,
                SelectedSuspension = InputDataViewModel.InputDataCollection[0].SelectedSuspension,
                SelectedTextileId = TextileSelectionViewModel.TextileDataCollection[TextileSelectionViewModel.SelectedTextileIndex].Id,
                SelectedColourId = TextileSelectionViewModel.Colours[TextileSelectionViewModel.SelectedColourIndex].Id,
                SelectedWidthId = TextileSelectionViewModel.Widths[TextileSelectionViewModel.SelectedWidthIndex].Id,
            };

            return csd;

        }

        private void OnTextileColourIndexChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(TextileSelectionViewModel.SelectedColourIndex >= 0 && TextileSelectionViewModel.SelectedTextileIndex >= 0)
            {
                if (e.PropertyName is "SelectedColourIndex" || e.PropertyName is "SelectedTextileIndex")
                    TextilePictureViewModel.GetUri(TextileSelectionViewModel.TextileDataCollection[TextileSelectionViewModel.SelectedTextileIndex], TextileSelectionViewModel.Colours[TextileSelectionViewModel.SelectedColourIndex]);
            }
            
        }

        
    }
}
