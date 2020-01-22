using TextileCalculatorApp.DataProvider;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TextileCalculatorApp.Controls
{
    public sealed partial class OrderData : UserControl
    {
        public OrderData()
        {
            this.InitializeComponent();
            APIHelper.InitializeClient();
            //GetAllTextiles();
        }

        //private async void GetAllTextiles()
        //{
        //    TextileDataProvider tdp = new TextileDataProvider();
        //    var orders = await tdp.GetOrders();

        //    foreach (var orderLine in orders)
        //    {
        //        OrderList.Items.Add(orderLine);
        //    }
        //    OrderList.SelectedIndex = 0;

        //}
    }
}
