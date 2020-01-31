using System;

namespace TextileCalculatorApp.Models
{
    [Obsolete]
    public class Order
    {
        public string ItemNumber { get; set; }

        public string Description { get; set; }

        public string ColourName { get; set; }

        public int Width { get; set; }

        public string Suspension { get; set; }

        public int Quantity { get; set; }

        public int RetailerPrice { get; set; }

        public bool IsOrder { get; set; }
    }
}
