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

        public TextilePictureViewModel TextilePictureViewModel { get; set; }




        public CalculateViewModel()
        {
            InputDataViewModel = new InputDataViewModel();
            TextileSelectionViewModel = new TextileSelectionViewModel();
            TextilePictureViewModel = new TextilePictureViewModel();
            TextileSelectionViewModel.PropertyChanged += OnTextileColourIndexChanged;

            //TextilePictureViewModel.TextileSelectionViewModel = TextileSelectionViewModel;
            //TextileSelectionViewModel.TextilePictureViewModel = TextilePictureViewModel;
        }

        private void OnTextileColourIndexChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName is "SelectedColourIndex")
                TextilePictureViewModel.GetUri(TextileSelectionViewModel.TextileDataCollection[TextileSelectionViewModel.SelectedTextileIndex], TextileSelectionViewModel.Colours[TextileSelectionViewModel.SelectedColourIndex]);
        }

        public void CalculatePrice()
        {

        }
    }
}
