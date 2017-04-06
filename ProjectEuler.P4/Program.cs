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
            string numberAsString;
            for (int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    long number = i * j;
                    numberAsString = number.ToString();
                    if ((string)numberAsString.Reverse() == number.ToString())
                    {
                        numberAsString = number.ToString();
                        Console.WriteLine("The loargest palindrome is " + number);
                        
                    }
                }
            }
            //Console.WriteLine(numberAsString);
        }
    }
}
