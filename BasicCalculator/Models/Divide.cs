using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Models
{
    public class Divide : Calculate
    {
        public override double Calculator()
        {            
                       
            try
            {
                double sum;

                Console.WriteLine("Enter num 1");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter num 2");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.\n");
                }
                else
                {
                    sum = num1 / num2;
                    Console.WriteLine("The sum is " + sum.ToString() + "\n");
                    return sum;
                }               
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

        }
    }
}
