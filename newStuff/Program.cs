using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // A static method is a method that belongs to the class, which means we don't have to create an instance of a class
            // The Math.Sqrt is an example of a static method
            /* You can't create instances of static classes, you'll get errors
                Math myMath = new Math();*/
            Console.WriteLine(Math.Sqrt(142));

            // You can make an instance of a class if it's not a static class even if the methods inside are static
            //UsefulTools tools = new UsefulTools();

            UsefulTools.SayHi("Luigi");

            Console.ReadLine();

        }
    }
}
