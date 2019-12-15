using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    class Pricing
    {
        public int ID { get; set; }

        public double RetailerPurchasePrice { get; set; }

        public double TurningFactor { get; set; }

        public const double VAT = 1.25;

        public double CustomerPrice { get; set; }


    }
}
