using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.DataProvider
{
    class TextileDataProvider
    {
        
        public async Task<List<Textile>> GetTextiles()
        {
            string URL = "http://localhost:5000/api/WinterItems/Textiles";
            List<Textile> textiles = new List<Textile>();

            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<Textile>>(result.Result);

                    textiles = data;
                }
            }
 
            return textiles;
        }


        public async Task<DTO.CalculatedPrice> SendDataForCalculationAsync(DTO.CustomerSelectedData csd)
        {
            string URL = "http://localhost:5000/api/WinterItems/CalcData";
            DTO.CalculatedPrice prices = new DTO.CalculatedPrice();

            using (HttpResponseMessage response = await APIHelper.ApiClient.PostAsync(URL, csd, new JsonMediaTypeFormatter()))
            {
                var result = response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<DTO.CalculatedPrice>(result.Result);

                prices = data;
            }

            return prices;
                        
        }


        public async Task<List<Order>> GetOrders()
        {
            string URL = "http://localhost:5000/api/WinterItems/Orders";
            List<Order> orders = new List<Order>();

            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<Order>>(result.Result);

                    orders = data;
                }
            }
            return orders;
        }


        public string GetPictureURL(Textile chosenTextile, Colour chosenColour)
        {

            string baseUrl = "https://www.winterstextil.se/wp-content/uploads/";
            string textileUrl = chosenTextile.ImageString;
            string selectedUrl = $"{chosenTextile.ItemNumber}-{chosenColour.ColourCode}.jpg";

            string Url = baseUrl + textileUrl + selectedUrl;
            return Url;

        }

    }
}
