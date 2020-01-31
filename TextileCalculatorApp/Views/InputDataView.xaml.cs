using TextileCalculatorApp.ViewModel;
using Windows.UI.Xaml.Controls;


namespace TextileCalculatorApp.Views
{

    public sealed partial class InputDataView : UserControl
    {

        public InputDataViewModel InputDataViewModel { get; set; }

        public InputDataView()
        {
            this.InitializeComponent();
        }
                
    }
}
