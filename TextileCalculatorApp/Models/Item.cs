using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TextileCalculatorApp.Models
{
    class ItemRoot
    {
        public Item[] Items { get; set; }
    }

    
    class Item
    {
        [JsonProperty("itemID")]
        public int Id { get; set; }

        [JsonProperty("itemNumber")]
        public string ItemNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("patternReport")]
        public int? PatternReport { get; set; }

        [JsonProperty("colours")]
        public Colour[] Colours { get; set; }

        [JsonProperty("widths")]
        public Width[] Widths { get; set; }

        [JsonProperty("pricelist")]
        public Price PriceList { get; set; }

        [JsonProperty("additionalFactor")]
        public string AdditionalFactor { get; set; }

    }
            

    public enum TextileSuspension
    {
        Påsömnadsglid,
        Wave,
        Veckband
    }
}
