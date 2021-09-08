using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //integers are whole numbers

            Console.WriteLine( 5 * 8 ); //you can do math

            Console.WriteLine( 5 % 2 ); // this is a modulus operator, JS has this as well

            Console.WriteLine( 2 + 8 * 7 ); // Order of operations

            Console.WriteLine( (4+2) / 2 ); // You can change the order of operations

            Console.WriteLine( 5 / 2); // A math operation with int returns integers, even tho a decimal is needed

            Console.WriteLine( 5 / 2.0); // This however will return the decimal answer

            int num = 9;
            //num++; // you can increment numbers with variables, same with JS
            num--; // you can also drecrement
            Console.WriteLine(num);

            /* Can also write Console.WriteLine( Math. ); to pull up different methods
               that you can do with math in c# */

            Console.WriteLine( Math.Abs(-49) ); // Abs - Absolute : this gives back the absolute value of a number

            Console.WriteLine( Math.Pow(3, 4) ); // does three to the power of 4, also works with decimals

            Console.WriteLine( Math.Sqrt(40) ); // Sqrt - squareroot

            Console.WriteLine( Math.Max(53, 3) ); //spits out larger number
            Console.WriteLine( Math.Min(-44, 10) ); // spits out smaller number

            Console.WriteLine( Math.Round(10.4) ); // Rounds to the nearest number


            Console.ReadLine();
        }
    }
}
 