using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    public class SewingPrice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("priceLimitHeight")]
        public int PriceLimitHeight { get; set; }

        [JsonProperty("sewingCost")]
        public int SewingCost { get; set; }
    }
}
