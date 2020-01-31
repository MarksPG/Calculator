using Newtonsoft.Json;

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
