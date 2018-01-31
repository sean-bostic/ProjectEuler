using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Interface.Problems
{
    class P6
    {
        public static string SquareSum()
        {
            int sumSquares = 0;
            int squareSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sumSquares = sumSquares + (i * i);
                squareSum = squareSum + i;
            }

            squareSum = squareSum * squareSum;

            return (squareSum - sumSquares).ToString();
        }
    }
}
