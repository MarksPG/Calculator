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
        public async Task<List<Item>> GetItems()
        {
            string URL = "http://localhost:5001/api/WinterItems/Textiles";
            List<Item> ItemList = new List<Item>();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<>
                }
            }
        }
    }
}
