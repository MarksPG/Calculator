using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileCalculatorApp.Models
{
    public class UserInputModel { }

    public class UserInput
    {
        public int InputLength { get; set; }

        public int InputNumber { get; set; }

        public string SelectedSuspension { get; set; }

        public double InputFactor { get; set; }
    }
}
