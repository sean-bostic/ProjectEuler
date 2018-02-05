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
            int index = 1;
            List<int> primes = new List<int> { 1 };
            int i = primes[index - 1];
            while (primes.Count < 10001)
            {
                i += 2;
                bool isPrime = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j != 0) continue;
                    isPrime = false;
                    break;
                }
                if (!isPrime) continue;
                primes.Add(i);
                index++;
            }
            Console.WriteLine(primes[10000]);
            Console.ReadKey();
        }
    }
}

