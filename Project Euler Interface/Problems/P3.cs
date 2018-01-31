using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Interface.Problems
{
    class P3
    {
        public static string LargestPrime()
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
            return LargestPrime.ToString();
        }

        public static bool IsPrime(long x)
        {
            for (int i = 2; i < x; ++i)
                if (x % i == 0)
                    return false;
            return true;
        }

        public static bool IsFactorOf(long x, long y)
        {
            if (x % y == 0)
                return true;
            return false;
        }
    }
}
