using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P3
{
    class Program
    {
        //this currently is not working....need to figure this out
        static void Main(string[] args)
        {
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143?
            long number = 600851475143;
            long factorial = 0;

            for (long i = 2; i < number; i++)
            {
                if (number % 1 == 0)
                {
                    bool isPrimeNumber = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrimeNumber = false;
                            break;

                        }
                    }
                    if (isPrimeNumber)
                    {
                        factorial = i;
                    }
                }
            }

            Console.WriteLine(factorial);
            Console.Read();

        }
    }
}
