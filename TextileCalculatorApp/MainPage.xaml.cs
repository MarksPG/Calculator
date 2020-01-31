using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;


namespace TextileCalculatorApp
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(1120, 950);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ContentFrame.Navigate(typeof(LoginRegisterPage));
        }

        private void MenuSelected(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

            var item = NavView.SelectedItem as NavigationViewItem;
            switch (item.Tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(LoginRegisterPage));
                    TitleTextBlock.Text = "Start & Inloggning";
                    break;
                case "kalkyl":
                    ContentFrame.Navigate(typeof(CalculatePage));
                    TitleTextBlock.Text = "Kalkylera gardinpris";
                    break;
                case "order":
                    ContentFrame.Navigate(typeof(OrderPage));
                    TitleTextBlock.Text = "Totalorder";
                    break;
                case "newItems":
                    ContentFrame.Navigate(typeof(AddItemsPage));
                    TitleTextBlock.Text = "Lägg till vara";
                    break;
            }
        }
    }

}
