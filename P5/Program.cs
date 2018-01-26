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
            bool flag = false;
            int answer = 0;

            //ToDo: Figure out how to adjust the limit of the loop. Maybe a for loop isn't the best option for this problem??

            //My logic of using the modulus function seems to work well to flag when this is all true. 
            #region TestSampleSet
            for (int i = 0; i < 3000; i++)
            {

                //test round
                bool six = false,
                    seven = false,
                    eight = false,
                    nine = false,
                    ten = false;

                if (i % 6 == 0)
                {
                    six = true;
                }

                if (i % 7 == 0)
                {
                    seven = true;
                }

                if (i % 8 == 0)
                {
                    eight = true;
                }

                if (i % 9 == 0)
                {
                    nine = true;
                }

                if (i % 10 == 0)
                {
                    ten = true;
                }

                if (six && seven && eight && nine && ten)
                {
                    answer = i;
                    
                }
                //bool eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty;

                //if (i/11 % )
                //{

                //}
            }

            Console.WriteLine(answer);
            Console.ReadKey();

            #endregion
        }
    }
}
