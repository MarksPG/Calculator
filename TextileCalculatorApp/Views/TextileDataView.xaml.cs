using TextileCalculatorApp.ViewModel;
using Windows.UI.Xaml.Controls;


namespace TextileCalculatorApp.Views
{
    public sealed partial class TextileDataView : UserControl
    {
        public TextileSelectionViewModel TextileSelectionViewModel { get; set; }


        public TextileDataView()
        {
            this.InitializeComponent();
        }

    }
}
