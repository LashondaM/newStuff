using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // the comma tells c# we want a 2 dimensional array, and in order to add more dimensions to an array, you just add more commas EX: for 5D you'll add 5 commas
            int[,] numberGrid = {
                { 1, 2},
                { 3, 4},
                { 5, 6}
            };

            // if you don't know what elements you'll put into your array initally, you put in those two numbers and it'll tell c# how many rows and columns you want to have
            // There will be 2 elements, and then those 2 elements will have 3 elements inside of it
            int[,] myArray = new int[2,3];

            Console.WriteLine(numberGrid[2, 0]);

            Console.ReadLine();

        }
    }
}
