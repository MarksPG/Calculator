using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    public class PriceList
    {
        public int Id { get; set; }
        public string PriceListName { get; set; }
        public List<SewingPrice> SewingPrice { get; set; }
    }
}
