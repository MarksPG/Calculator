using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    public class PriceList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("priceListName")]
        public string PriceListName { get; set; }

        [JsonProperty("sewingPrice")]
        public List<SewingPrice> SewingPrice { get; set; }
    }
}
