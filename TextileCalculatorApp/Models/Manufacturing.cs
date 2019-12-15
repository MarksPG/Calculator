using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    
    class Manufacturing
    {
        public int ID { get; set; }

        public int Height { get; set; }

        public int Quantity { get; set; }

        public enum TextileSuspension
        {
            Påsömnadsglid,
            Wave,
            Veckband
        }

        public int AdditionalFactor { get; set; }

        public double SewingCost { get; set; }

    }
}
