using BasicCalculator.Models;
using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu == true)
            {
               displayMenu =  Menu();
            }           
           
            Console.Read();
        }

        private static bool Menu()
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine(
                                "1. Addition\n" +
                                "2. Subtraction\n" +
                                "3. Division\n" +
                                "4. Multiplcation\n"+
                                "5. Exit\n");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.WriteLine("**Addition**\n");
                var calculate = new Add();
                calculate.Calculator();
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine("**Subtration**\n");
                var calculate = new Subtract();
                calculate.Calculator();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("**Division**\n");
                var calculate = new Divide();
                calculate.Calculator();
                return true;
            }
            else if (result == "4")
            {
                Console.WriteLine("**Multiplication**\n");
                var calculate = new Multiply();
                calculate.Calculator();
                return true;
            }
            else if (result == "5")
            {
                Console.WriteLine("Exiting calculator.\n");
                Environment.Exit(1);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
