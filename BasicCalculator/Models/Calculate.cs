using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Models
{
    public class Calculate : ICalculate
    {
        private protected double num1 { get; set; }
        private protected double num2 { get; set; }

        public virtual double Calculator()
        {
            return 0;
        }
    }

 
}
