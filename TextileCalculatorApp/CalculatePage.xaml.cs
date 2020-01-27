using Windows.UI.Xaml.Controls;
using TextileCalculatorApp.ViewModel;



namespace TextileCalculatorApp
{

    public sealed partial class CalculatePage : Page
    {
        public CalculateViewModel CalculateViewModel { get; set; } = new CalculateViewModel();

        public CalculatePage()
        {
            this.InitializeComponent();
        }
        
    }
}
