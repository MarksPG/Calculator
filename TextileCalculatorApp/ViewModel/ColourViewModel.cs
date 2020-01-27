using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.ViewModel
{
    public class ColourViewModel
    {
        private Colour _colour;

        public string ColourName
        {
            get
            {
                return _colour.ColourName;
            }
        }

        public ColourViewModel(Colour colour)
        {
            _colour = colour;
        }
    }



}
