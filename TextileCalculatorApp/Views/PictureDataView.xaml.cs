using TextileCalculatorApp.ViewModel;
using Windows.UI.Xaml.Controls;



namespace TextileCalculatorApp.Views
{
    public sealed partial class PictureDataView : UserControl
    {
        public TextilePictureViewModel TextilePictureViewModel { get; set; }

        public PictureDataView()
        {
            this.InitializeComponent();
        }

    }
}
