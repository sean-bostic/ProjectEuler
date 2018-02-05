using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Interface.Problems
{
    class P7
    {
       public static string FindPrimeNumber()
        {
            int index = 1;
            List<int> primesList = new List<int> { 1 };
            int i = primesList[index - 1];

            while (primesList.Count < 10001)
            {
                i += 2;
                bool isPrime = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j != 0) continue;
                    isPrime = false;
                    break;
                }
                if (!isPrime)
                {
                    continue;
                }
                primesList.Add(i);
                index++;
            }

            return primesList[10000].ToString();
        } 
    }
}