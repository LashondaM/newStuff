using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // can also use var, after you set a value to var and hover over var, the value type will show up

            /* ======================== */

            //int i = 1;
            //while(i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            /* ======================== */

            int[] luckyNumbers = { 2, 4, 6, 8, 10, 1200 };
            //Console.WriteLine(luckyNumbers[5]); // use indexing to look through the array
            for(int i = 0; i < luckyNumbers.Length; i++) /* we set i = 0 since array indexes start at zero, and since we're starting at 0, i will be less than luckyNumbers.Length */
            {
                // i will try to access the 6th number at one point if we use <= 
                Console.WriteLine(luckyNumbers[i]);
            }
            /* luckyNumbers.Length tells us how many elements are in the array, it gives us access to the length
            of the array */


            /* ========================== */


            // simple for loop
            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}
 