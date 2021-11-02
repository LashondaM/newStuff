using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic while loop

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i *= 2;
            //}

            // do while loop
            int juice = 6;
            do
            {
                Console.WriteLine(juice);
                juice++;
            } while (juice <= 8);


            // complex for loop, reading through the array
            string[] luckWords = { "tomato", "potato", "ravioli", "meat sauce" };

            for(int g = 0; g < luckWords.Length; g++)
            {
                Console.WriteLine(luckWords[g]);
            }


            // basic for loop

            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();

        }
    }
}
