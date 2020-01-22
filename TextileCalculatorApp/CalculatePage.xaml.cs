using TextileCalculatorApp.DataProvider;
using TextileCalculatorApp.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml.Media.Imaging;
using System.Threading.Tasks;
using TextileCalculatorApp.Controls;
using Windows.UI.Xaml;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TextileCalculatorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalculatePage : Page
    {
        //private readonly ObservableCollection<Textile> textileSuspensions = new ObservableCollection<Textile>();

       
        public CalculatePage()
        {
            InitializeComponent();
            APIHelper.InitializeClient();
            GetAllTextiles();

            //foreach (TextileSuspension value in Enum.GetValues(typeof(TextileSuspension)))
            //{
            //    SuspensionCombo.Items.Add(value);
            //}
        }

        private async void GetAllTextiles()
        {
            TextileDataProvider tdp = new TextileDataProvider();
            var textiles = await tdp.GetTextiles();
            
            foreach (var textile in textiles)
            {
                TextileList.Items.Add(textile);
            }
            TextileList.SelectedIndex = 0;
            
        }

        private void PopulateContent()
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;

            foreach (var width in chosenTextile.Widths)
            {
                WidthList.Items.Add(width);
            }
            WidthList.SelectedIndex = 0;

            foreach (var colour in chosenTextile.Colours)
            {
                ColourList.Items.Add(colour);
            }
            ColourList.SelectedIndex = 0;
        }


        private void TextileChanged(object sender, SelectionChangedEventArgs e)
        {
            
            WidthList.Items.Clear();
            ColourList.Items.Clear();
            
            PopulateContent();

        }

        private void SelectedWidth(object sender, SelectionChangedEventArgs e)
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;


        }


        private void ShowCurrentColourPicture(object sender, SelectionChangedEventArgs e)
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;

            if (ColourList.SelectedItem is Colour chosenColour)
            {
                TextileDataProvider tdp = new TextileDataProvider();


                BitmapImage bitmapImage = new BitmapImage
                {
                    UriSource = new Uri(tdp.GetPictureURL(chosenTextile, chosenColour))
                };
                currentPicture.Source = bitmapImage;
            }


        }

        //private void CalculatePrice(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        //{
        //    Textile chosenTextile = TextileList.SelectedItem as Textile;
        //    Colour chosenColour = ColourList.SelectedItem as Colour;
        //    Width chosenWidth = WidthList.SelectedItem as Width;

            
        //    DTO.CustomerSelectedData csd = new DTO.CustomerSelectedData
        //    {
        //        InputLength = Int32.Parse(lengthInput.Text),
        //        InputNumber = Int32.Parse(numberInput.Text),
        //        SelectedSuspension = SuspensionCombo.SelectedValue.ToString(),
        //        SelectedTextileId = chosenTextile.Id,
        //        SelectedColourId = chosenColour.Id,
        //        SelectedWidthId = chosenWidth.Id,
        //        InputFactor = Double.Parse(factorInput.Text.Replace(",", ".").Replace(" ", ""))
        //    };

        //    TextileDataProvider tdp = new TextileDataProvider();

        //    Task<DTO.CalculatedPrice> data = Task.Run<DTO.CalculatedPrice>(async () => await tdp.SendDataForCalculationAsync(csd));
        //    var output = data.Result;
        //    //RetailPrice.Text = data.RetailerCost.ToString();

        //    CustomerPrice.Text = output.CustomerPrice.ToString() + "kr";

        //    RetailPrice.Text = output.RetailerCost.ToString() + "kr";
            
           
        //}

        //private void Users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var userInputItem = ((ListView)sender).SelectedItem;
        //    var userInput = userInputItem as UserInput;
        //    UserCalculateControl.UserInputData = userInput;
        //    //UserName.Text = user.Name;
        //    //UserAge.Text = user.Age.ToString();
        //}

        private void CalculatePrice(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Textile chosenTextile = TextileList.SelectedItem as Textile;
            Colour chosenColour = ColourList.SelectedItem as Colour;
            Width chosenWidth = WidthList.SelectedItem as Width;

            ViewModel.InputDataViewModel inputDataViewModelObject = new ViewModel.InputDataViewModel();

            var all = ViewModel

            











        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.InputDataViewModel inputDataViewModelObject = new ViewModel.InputDataViewModel();
            inputDataViewModelObject.LoadDefaultInput();

            InputDataViewControl.DataContext = inputDataViewModelObject;
        }
    }
}
