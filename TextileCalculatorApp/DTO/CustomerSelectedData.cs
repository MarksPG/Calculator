﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.DTO
{
    class CustomerSelectedData
    {
        [JsonProperty("inputLength")]
        public int InputLength { get; set; }

        [JsonProperty("inputNumber")]
        public int InputNumber { get; set; }

        [JsonProperty("selectedSuspension")]
        public string SelectedSuspension { get; set; }

        [JsonProperty("selectedTextileId")]
        public int SelectedTextileId { get; set; }

        [JsonProperty("selectedColourId")]
        public int SelectedColourId { get; set; }

        [JsonProperty("selectedWidthId")]
        public int SelectedWidthId { get; set; }
    }
}