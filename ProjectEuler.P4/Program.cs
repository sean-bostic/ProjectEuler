using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P4
{
    class Program
    {
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            #region 1stAttempt
            //string numberAsString;
            //for (int i = 100; i < 999; i++)
            //{
            //    for (int j = 100; j < 999; j++)
            //    {
            //        long number = i * j;
            //        numberAsString = number.ToString();
            //        if (numberAsString.Reverse() == number.ToString())
            //        {
            //            numberAsString = number.ToString();
            //            Console.WriteLine("The loargest palindrome is " + number);

            //        }
            //    }
            //}
            #endregion

            //Second attempt
            long multiplication;
            long result = 0;
            string []  test = "";

            for (int x = 100; x < 999; x++)
            {
                for (int y = 100; y < 999; y++)
                {
                    multiplication = (x * y);
                    test = multiplication.ToString().ToArray(;
                    
                    

                    if (multiplication.ToString() == test.Reverse())
                    {
                        if (multiplication > result)
                        {
                            result = multiplication;
                        }
                    }

                    else { continue; }
                }
            }
            Console.WriteLine("The largest palindrome of 3 digit numbers is: " + result);
            Console.Read();

        }
    }
}
