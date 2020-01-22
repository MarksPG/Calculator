using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.DTO
{
    class OrderFromDB
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("itemNumber")]
        public string ItemNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("colourCode")]
        public string ColourCode { get; set; }

        [JsonProperty("colourName")]
        public string ColourName { get; set; }

        [JsonProperty("suspension")]
        public string Suspension { get; set; }

        [JsonProperty("textileLength")]
        public int TextileLength { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("retailerPrice")]
        public int RetailerPrice { get; set; }

        [JsonProperty("isOrder")]
        public bool IsOrder { get; set; }
    }
}
