using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fibonacci Calculator!");
            Console.WriteLine();

            // Displays the Fibonacci series value for position 10 & 40 to the console.
            WriteFibonacciNumber(10);
            WriteFibonacciNumber(40);

            Console.ReadLine();
        }

        /// Write the Fibonacci series value for given position to the console.
        ///
        /// @param  Position in the Fibonacci series.
        /// 
        static void WriteFibonacciNumber(int position)
        {
            int value = FibonacciCalculator.CalculateFibonacci(position);
            Console.WriteLine(String.Format("The value at position {0} is {1}", position, value));
        }
    }
}
