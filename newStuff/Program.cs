using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            // This prints out and stays on the same line. WriteLine prints and goes to a new line.
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you're " + age);

            Console.ReadLine();
        }
    }
}
 