using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Calculator : ICalculator
    {
        public Calculator() { }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        //Other functions
        public double Divide(double dividend, double divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"The attempt of dividing by zero");
                return 0;
            }
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double addend)
        {
            return addend + Accumulator;
        }

        public double Subtract(double subtractor)
        {
            return subtractor - Accumulator;
        }

        public double Multiply(double multiplier)
        {
            return multiplier * Accumulator;
        }

        public double Divide(double divisor)
        {
            return divisor / Accumulator;
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }
    }
}
