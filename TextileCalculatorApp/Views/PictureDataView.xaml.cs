using TextileCalculatorApp.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;



namespace TextileCalculatorApp.Views
{
    public sealed partial class PictureDataView : UserControl
    {
        public TextilePictureViewModel TextilePictureViewModel { get; set; }
        //public static DependencyProperty TextilePictureViewModelProperty = DependencyProperty.Register(nameof(TextilePictureViewModel), typeof(TextilePictureViewModel), typeof(PictureDataView), null);

        public PictureDataView()
        {
            this.InitializeComponent();
            //TextilePictureViewModel = new TextilePictureViewModel();
        }

    }
}
