using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Interface.Problems
{
    class P4
    {
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        public static string largestPalindrome()
        {
            string product = "";
            string largestPalindrome = "0";

            for (int x = 100; x < 999; x++)
            {
                for (int y = 100; y < 999; y++)
                {
                    product = Convert.ToString(x * y);

                    if (product == new String(product.Reverse().ToArray()))
                    {
                        if (x * y > Convert.ToInt32(largestPalindrome))
                        {
                            largestPalindrome = product;


                        }

                        else { continue; }

                    }
                }

            }
            return largestPalindrome;
        }
    }
}
