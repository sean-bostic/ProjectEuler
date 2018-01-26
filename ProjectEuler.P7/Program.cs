using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P7
{
    class Program
    {
        /// <summary>
        /// SAMPLE: By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

        /// PROBLEM: What is the 10 001st prime number?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i <= 10001; i++)
            {
                for (int y = 2; y < i; y++)
                {
                    if (i%y != 0)
                    {
                        x += 1;
                    }
                }

                if (x == (i -2))
                {
                    Console.WriteLine(i + "\n");

                    x = 0;
                }
            }

            Console.ReadKey();
        }
    }
}

