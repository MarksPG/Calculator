using TextileCalculatorApp.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;





namespace TextileCalculatorApp.Views
{
    public sealed partial class PriceOutputView : UserControl
    {
        public OutputDataViewModel OutputDataViewModel { get; set; }

        public PriceOutputView()
        {
            this.InitializeComponent();
            CalculateButton.Click += (s, e) =>
            {
                Click?.Invoke(s, e);
            };
        }

        public event RoutedEventHandler Click;
    }
}


