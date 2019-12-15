using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextileCalculatorApp.Models
{
    [Table("TextileName")]
    class Item
    {
        public int ID { get; set; }

        public string ItemNumber { get; set; }

        public string Description { get; set; }

        public int PatternReport { get; set; }

        public ICollection<Colour> Colours { get; set; }

        public ICollection<Width> Widths { get; set; }

    }

    [Table("Colour")]
    class Colour
    {
        public int ID { get; set; }

        public int ColourCode { get; set; }

        public string ColourName { get; set; }

    }

    [Table("Width")]
    class Width 
    { 
        public int ID { get; set; }

        public int RollWidth { get; set; }

        public double ItemPrice { get; set; }
    }
}
