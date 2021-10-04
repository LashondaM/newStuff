using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall) // && (and) || (or)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) // ! (not)
            {
                Console.WriteLine("You are male, but not tall");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male, but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }

            Console.ReadLine();
        }
    }
}
 