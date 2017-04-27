using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciApplication
{
    public static class FibonacciCalculator
    {
        /// Calculate the Fibonacci series position value.
        ///
        /// Calculates the Finonacci series position value using a standard
        /// calculation with linear run time and constant space.
        /// 
        /// @param  Position in the Fibonacci series.
        /// @return Calculated value.
        /// 
        public static int CalculateFibonacci(int position)
        {
            int F_N = 0;    // Current value.
            int F_N1 = 1;   // Last value.
            int F_N2 = 1;   // Second to last value.

            for (int index = 3; index <= position; index++)
            {
                F_N = F_N1 + F_N2;

                F_N1 = F_N2;
                F_N2 = F_N;
            }

            return F_N;
        }
    }
}
