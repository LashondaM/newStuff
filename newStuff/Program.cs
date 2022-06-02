using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "bacon");
            Movie shrek = new Movie("Shrek", "Adamn Adamson", "PG");

            Console.WriteLine(avengers.Rating);

            Console.ReadLine();

        }
    }
}
