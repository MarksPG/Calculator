using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{

    public class Width
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("rollWidth")]
        public int RollWidth { get; set; }

        [JsonProperty("itemPrice")]
        public double ItemPrice { get; set; }
    }
}
