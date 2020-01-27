using TextileCalculatorApp.ViewModel;
using Windows.UI.Xaml.Controls;



namespace TextileCalculatorApp.Views
{
    public sealed partial class TextileView : UserControl
    {
        public TextileView()
        {
            this.InitializeComponent();
            this.DataContext = new TextileSelectionViewModel();
        }
    }
}
