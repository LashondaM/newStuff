using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32("56");
            //Console.WriteLine(num + 25);

            // converting to Double allows us to enter in decimals, not ToInt32
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
 