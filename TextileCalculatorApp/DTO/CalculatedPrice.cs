using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.DTO
{
    public class CalculatedPrice
    {
        [JsonProperty("customerPrice")]
        public double CustomerPrice { get; set; }

        [JsonProperty("retailerCost")]
        public double RetailerCost { get; set; }
    }
}
