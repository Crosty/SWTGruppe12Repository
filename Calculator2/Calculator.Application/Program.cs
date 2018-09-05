using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator2.Calculator test = new Calculator2.Calculator();

            Console.WriteLine("Enter the first number: ");
            string firstNumber = Console.ReadLine();
            double a = double.Parse(firstNumber);

            Console.WriteLine("Enter the second number: ");
            string secondNumber = Console.ReadLine();
            double b = double.Parse(secondNumber);

            Console.WriteLine("Add:");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {test.Add(a, b)}");

            Console.WriteLine("\n\nSubtract:");
            Console.Write($"{firstNumber} - {secondNumber} = {test.Subtract(a, b)}");

            Console.WriteLine("\n\nMultiply:");
            Console.Write($"{firstNumber} * {secondNumber} = {test.Multiply(a, b)}");

            Console.WriteLine("\n\nPower:");
            Console.Write($"{firstNumber} power to {secondNumber} = {test.Power(a, b)}");

            Console.WriteLine("\n\nPress enter to exit");
            Console.ReadLine();
        }
    }
}
