using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public string GetPictureURL(Textile chosenTextile, Colour chosenColour)
        {
            string baseUrl = "https://www.winterstextil.se/wp-content/uploads/";
            string textileUrl = chosenTextile.ImageString;
            string selectedUrl = $"{chosenTextile.ItemNumber}-{chosenColour.ColourCode.ToString()}.jpg";


            // https://www.winterstextil.se/wp-content/uploads/2019/06/03246-50.jpg

            string Url = baseUrl + textileUrl + selectedUrl;
            return Url;
        }

    }
}
