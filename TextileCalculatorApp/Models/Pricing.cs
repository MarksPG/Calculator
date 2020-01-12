using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    public class Pricing
    {
        
        public int Id { get; set; }

        public double RetailerPurchasePrice { get; set; }

        public double TurningFactor { get; set; }

        
        public const double VAT = 1.25;

        public double CustomerPrice { get; set; }

    }
}
