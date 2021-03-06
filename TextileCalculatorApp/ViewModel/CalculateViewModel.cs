﻿using System;
using System.ComponentModel;



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
            OutputDataViewModel = new OutputDataViewModel { Root = this };
            TextileSelectionViewModel.PropertyChanged += OnTextileColourIndexChanged;
            OutputDataViewModel.PropertyChanged += OnCalculatePriceButtonClick;
              
        }

        private void OnCalculatePriceButtonClick(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName is "CalculateButtonClick")
            {
                GetCalculationBasis();
            }

        }

        public void GetCalculationBasis()
        {

            DTO.CustomerSelectedData csd = new DTO.CustomerSelectedData()
            {
                InputLength = Int32.Parse(InputDataViewModel.InputData.InputLength),
                InputNumber = Int32.Parse(InputDataViewModel.InputData.InputNumber),
                InputFactor = Double.Parse((InputDataViewModel.InputData.InputFactor).Replace(",", ".").Replace(" ", "")),
                SelectedSuspension = InputDataViewModel.InputData.SelectedSuspension,
                SelectedTextileId = TextileSelectionViewModel.TextileDataCollection[TextileSelectionViewModel.SelectedTextileIndex].Id,
                SelectedColourId = TextileSelectionViewModel.Colours[TextileSelectionViewModel.SelectedColourIndex].Id,
                SelectedWidthId = TextileSelectionViewModel.Widths[TextileSelectionViewModel.SelectedWidthIndex].Id,
            };

            OutputDataViewModel.GetCalculatedPriceObject(csd);
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
