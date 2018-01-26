using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P6
{
    class Program
    {
        /// <summary>
        /// SAMPLE: The sum of the squares of the first ten natural numbers is,

        ///    12 + 22 + ... + 102 = 385
        ///    The square of the sum of the first ten natural numbers is,

        ///    (1 + 2 + ... + 10)2 = 552 = 3025
        ///    Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        ///  PROBLEM:   Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int sumSquares = 0;
            int squareSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sumSquares = sumSquares + (i*i);
                squareSum = squareSum + i;
            }

            squareSum = squareSum * squareSum;

            Console.WriteLine(squareSum - sumSquares);
            Console.Read();
        }
    }
}
