using Newtonsoft.Json;

namespace TextileCalculatorApp.Models
{
    public class Colour
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("colourCode")]
        public string ColourCode { get; set; }

        [JsonProperty("colourName")]
        public string ColourName { get; set; }
    }
}
