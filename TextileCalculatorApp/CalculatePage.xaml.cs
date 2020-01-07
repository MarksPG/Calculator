
using System.Collections.ObjectModel;
using TextileCalculatorApp.Models;
using Windows.UI.Xaml.Controls;
using System;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TextileCalculatorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalculatePage : Page
    {

        ObservableCollection<Item> textileSuspensions = new ObservableCollection<Item>();

       
        public CalculatePage()
        {
            this.InitializeComponent();

            foreach(TextileSuspension value in Enum.GetValues(typeof(TextileSuspension)))
            {
                FontsCombo.Items.Add(value);
            }
           // textileSuspensions.Add(Tex
           // textileSuspensions.Add(new FontFamily("Courier New"));
           // textileSuspensions.Add(new FontFamily("Times New Roman"));
        }

        
    }
}
