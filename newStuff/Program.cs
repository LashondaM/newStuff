using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(2, 3));

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            // baseNum ^ powNum

            int result = 1;

            for (int i = 0; i < powNum; i++) // i++ - something we wanna do after each iteration of the loop
            {
                result *= baseNum;
            }

            return result;
        }
    }
}
 