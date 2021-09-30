using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            string[] friends = new string[2]; /* We do this when we don't know what values to put into the array 
                                             The number in the bracket tells c# how many elements we want it to hold*/
            friends[0] = "Jim";
            friends[1] = "Tom";
            //Console.WriteLine(friends[0]);


            luckyNumbers[1] = 700;

            Console.WriteLine( luckyNumbers[1] );

            Console.ReadLine();
        }
    }
}
 