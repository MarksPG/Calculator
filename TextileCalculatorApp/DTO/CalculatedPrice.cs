using Newtonsoft.Json;

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
