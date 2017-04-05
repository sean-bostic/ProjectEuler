using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P3
{
    #region attempt1
    //class Program
    //{
    //    //this currently is not working....need to figure this out
    //    static void Main(string[] args)
    //    {
    //        //The prime factors of 13195 are 5, 7, 13 and 29.
    //        //What is the largest prime factor of the number 600851475143?
    //        long number = 600851475143;
    //        long factorial = 0;

    //        for (long i = 2; i < number; i++)
    //        {
    //            if (number % 1 == 0)
    //            {
    //                bool isPrimeNumber = true;
    //                for (int j = 2; j < i; j++)
    //                {
    //                    if (i % j == 0)
    //                    {
    //                        isPrimeNumber = false;
    //                        break;

    //                    }
    //                }
    //                if (isPrimeNumber)
    //                {
    //                    factorial = i;
    //                }
    //            }
    //        }

    //        Console.WriteLine(factorial);
    //        Console.Read();

    //    }
    //}
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            long NUM = 600851475143;
            long LargestPrime = 0;
            // NUM = (long)Math.Sqrt(NUM);
            for (long i = 2; i * i < NUM; i++)
            {
                if (IsFactorOf(NUM, i))
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i + " : is prime & is factor ");
                        if (i > LargestPrime)
                            LargestPrime = i;
                    }
            }
            Console.WriteLine("\n Done.... and the Largest Prime Factor is : " + LargestPrime);
            Console.Read();
        }

        static bool IsPrime(long x)
        {
            for (int i = 2; i < x; ++i)
                if (x % i == 0)
                    return false;
            return true;
        }

        static bool IsFactorOf(long x, long y)
        {
            if (x % y == 0)
                return true;
            return false;
        }
    }
}
