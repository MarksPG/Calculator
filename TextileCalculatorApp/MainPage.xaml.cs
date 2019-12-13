using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TextileCalculatorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(CalculatePage));
        }

        private void MenuSelected(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

            var item = NavView.SelectedItem as NavigationViewItem;
            switch (item.Tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(CalculatePage));
                    TitleTextBlock.Text = "Kalkylera gardinpris";
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
