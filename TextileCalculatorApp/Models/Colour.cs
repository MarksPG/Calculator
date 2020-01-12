using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    public class Colour
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("colourCode")]
        public int ColourCode { get; set; }

        [JsonProperty("colourName")]
        public string ColourName { get; set; }
    }
}
