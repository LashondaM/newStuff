using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(cube(4));

            int cubedNumber = cube(74);
            Console.WriteLine(cubedNumber);


            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
 