using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P5
{
    class Program
    {
        /// <summary>
        ///Sample Set: 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        ///Question: What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //bool flag = false;
            //int answer = 0;

            //ToDo: Figure out how to adjust the limit of the loop. Maybe a for loop isn't the best option for this problem??

            //My logic of using the modulus function seems to work well to flag when this is all true. 
            #region TestSampleSet
            //for (int i = 0; i < 3000; i++)
            //{

            //    //test round
            //    bool six = false,
            //        seven = false,
            //        eight = false,
            //        nine = false,
            //        ten = false;

            //    if (i % 6 == 0)
            //    {
            //        six = true;
            //    }

            //    if (i % 7 == 0)
            //    {
            //        seven = true;
            //    }

            //    if (i % 8 == 0)
            //    {
            //        eight = true;
            //    }

            //    if (i % 9 == 0)
            //    {
            //        nine = true;
            //    }

            //    if (i % 10 == 0)
            //    {
            //        ten = true;
            //    }

            //    if (six && seven && eight && nine && ten)
            //    {
            //        answer = i;
            //    }
            //    //bool eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty;

            //}

            //Console.WriteLine(answer);
            //Console.ReadKey();



            //for (int i = 0; i < 100000000; i++)
            //{

            //    bool eleven = false,
            //        twelve = false,
            //        thirteen = false,
            //        fourteen = false,
            //        fifteen = false,
            //        sixteen = false,
            //        seventeen = false,
            //        eighteen = false,
            //        nineteen = false,
            //        twenty = false;


            //    if (i % 11 == 0)
            //    {
            //        eleven = true;
            //    }

            //    if (i % 12 == 0)
            //    {
            //        twelve = true;
            //    }

            //    if (i % 13 == 0)
            //    {
            //        thirteen = true;
            //    }

            //    if (i % 14 == 0)
            //    {
            //        fourteen = true;
            //    }

            //    if (i % 15 == 0)
            //    {
            //        fifteen = true;
            //    }

            //    if (i % 16 == 0)
            //    {
            //        sixteen = true;
            //    }

            //    if (i % 17 == 0)
            //    {
            //        seventeen = true;
            //    }

            //    if (i % 18 == 0)
            //    {
            //        eighteen = true;
            //    }

            //    if (i % 19 == 0)
            //    {
            //        nineteen = true;
            //    }

            //    if (i % 20 == 0)
            //    {
            //        twenty = true;
            //    }

            //    if (eleven && twelve && thirteen && fourteen && fifteen && sixteen && seventeen && eighteen && nineteen && twenty)
            //    {
            //        answer = i;
            //    }
            //}

            //Console.WriteLine(answer);
            //Console.ReadKey();
            #endregion

            ///Attempting to use a while loop with the same modulus function to continue adding i++ until all the conditions are satisfied. Brute force way of solving this but got the correct answer.
            ///Also I believe I only need to check 11, 12, 13, 14, 15, 16, 17, 18 19, 20 
            int i = 1;

            while
                (
                i % 11 != 0 ||
                i % 12 != 0 ||
                i % 13 != 0 ||
                i % 14 != 0 ||
                i % 15 != 0 ||
                i % 16 != 0 ||
                i % 17 != 0 ||
                i % 18 != 0 ||
                i % 19 != 0 ||
                i % 20 != 0 
                )

            {
                i++;
            }
            Console.WriteLine(i);
            Console.Read();

        }
    }
}
