using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# also uses \n for "new-line" uses some of the same back slash attributes as JS in strings
            //Console.WriteLine("Hot\nChocolate");
            //Console.WriteLine("Hot \"Chocolate\"."); this back slash prints out the double quotes for a quote

            //can also concatenate strings in c# like JS
            // .Length tells us how many characters are in the string
            //string phrase = "butter" + " is tasty with toast";
            //Console.WriteLine(phrase.Length);

            string phrase = "Taco Bell";
            //this method changes all the character in the strings to uppercase, ToLower does the opposite
            //Console.WriteLine(phrase.ToUpper());

            //this is a boolean, tells us whether the value of the variable is true or false
            //Console.WriteLine( phrase.Contains("Bell") );

            //this tells us what each character is inside the string when we use a number inside the brackets
            //Console.WriteLine( phrase[6] );

            //IndexOf tells us the index position the value is located inside the string, where the value first starts
            //prints a value of -1 or 4 when you add a space inside the IndexOf method
            //if you just type a letter, it gives the position of where that letter first appears
            //-1 signifies a character is not there inside the string
            //Console.WriteLine( phrase.IndexOf("o") );

            //this method grabs a part of the string we selct from the index and prints that part out
            //you can also pass in how many characters you want it to grab after the starting point
            Console.WriteLine( phrase.Substring(1, 7) );

            Console.ReadLine();
        }
    }
}
