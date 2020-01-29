using Windows.UI.Xaml.Controls;
using TextileCalculatorApp.ViewModel;



namespace TextileCalculatorApp
{

    public sealed partial class CalculatePage : Page
    {
        public CalculateViewModel CalculateViewModel { get; set; }



        public CalculatePage()
        {
            this.InitializeComponent();
            CalculateViewModel = new CalculateViewModel();
        }
        
    }
}
