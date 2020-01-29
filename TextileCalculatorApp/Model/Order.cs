using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
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
