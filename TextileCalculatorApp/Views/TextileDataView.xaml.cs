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
            TextileSelectionViewModel = new TextileSelectionViewModel();
            
        }

        

        //private void TextileChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}
