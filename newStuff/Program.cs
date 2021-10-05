using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while loop executes the code inside the loop first before checking the condition
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


                //int index = 1;
                //while (index <= 5)
                //{
                //    Console.WriteLine(index);
                //    //index++; // loops infinitely because it's never told it needs to stop, the condition is never false
                //}

                Console.ReadLine();
        }
    }
}
 