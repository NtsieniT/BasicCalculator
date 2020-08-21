using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Models
{
    public class Subtract : Calculate 
    {
        public override double Calculator()
        {
            double sum;

            Console.WriteLine("Enter num 1");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter num 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            sum = num1 - num2;
            Console.WriteLine("The sum is " + sum.ToString() + "\n");
            return sum;
        }
    }
}
