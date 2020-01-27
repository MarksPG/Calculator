using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextileCalculatorApp.Models;

namespace TextileCalculatorApp.ViewModel
{
    public class WidthViewModel
    {
        private Width _width;

        public string RollWidth
        {
            get
            {
                return _width.RollWidth + " cm";
            }
        }
        

        public WidthViewModel(Width width)
        {
            _width = width;
        }
    }
}
