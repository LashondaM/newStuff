using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // Review Part 1


            //Variables Lesson

            string name = "Peter G";
            int age = 58;
            Console.WriteLine(name + " is " + age + " years old.");

            name = "Stewie"; // Can change the variable value down the line, like in JS
            Console.WriteLine("There was a boy named " + name + ", and he was strange.");

            // - end


            // Data Types Lesson

            string phrase = "Hello";
            char letter = 'Y';
            int num = 60;
            double num2 = 7.8;
            //float num3 = 9.1; This float sends an error when I put a decimal, The guy might go over that later
            bool isBlue = false;

            Console.WriteLine(phrase + '\n' + letter + '\n' + num + '\n' + num2);

            // - end


            // Working With Strings Lesson

            string title = "Taco Bell";
            string zeus = title;

            Console.WriteLine(title.ToUpper());
            Console.WriteLine(title.ToLower());

            Console.WriteLine(title.Contains("Taco"));
            Console.WriteLine(title.Contains("king"));

            Console.WriteLine(title.Length);
            Console.WriteLine(title[3]); // bracket notation, same in JS
            Console.WriteLine(title[title.Length - 3]); // reversed bracket Notation, same in JS

            Console.WriteLine(title.Substring(0, 6)); // first # is where it starts, 2nd # is how many characters it shows
            Console.WriteLine(title.IndexOf('a')); // single letters can use single quotes

            Console.WriteLine(zeus[zeus.Length - 8]);

            //Console.WriteLine(zeus = title[title.Length - 4]);
            // could only format it like this with the zeus variable in the JS notes

            //- end


            // Working With Numbers

            Console.WriteLine( 5 * 8);
            Console.WriteLine( 4 + 6);
            Console.WriteLine( 2 - 3 );
            Console.WriteLine( 2 / 7.0 ); // add decimal to the #, so the console prints the right value
            Console.WriteLine( (4 + 8) /2 );
            Console.WriteLine(11 % 4); // known as modulus operater in c#, used as remainder and modulus in JS

            int toy = 8;
            //anotherNum--;
            toy++;
            Console.WriteLine(toy);

            Console.WriteLine(Math.Abs(-6));
            Console.WriteLine(Math.Pow(6, 7));
            Console.WriteLine(Math.Sqrt(144));
            Console.WriteLine(Math.Max(5, 11));
            Console.WriteLine(Math.Min(0, 100));
            Console.WriteLine(Math.Round(91.5));

            // - end


            // Getting User Input

            //Console.Write("Enter a name: ");
            //string name2 = Console.ReadLine();
            //Console.Write("Enter a number: ");
            //string age2 = Console.ReadLine();

            //Console.WriteLine(name2 + " is very old. He's " + age2 + ".");

            // - end


            // Building a Calculator

            int num3 = Convert.ToInt32("32");
            Console.WriteLine(23 + num3);

            Console.Write("Enter a number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num4 + num5);

            // - end


            // Building a Mad Lib

            string noun, number, verb;

            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a number: ");
            number = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();

            Console.WriteLine("My name is " + noun);
            Console.WriteLine("I have " + number + " cats");
            Console.WriteLine("They " + verb + " a lot");

            // - end


            Console.ReadLine();
        }
    }
}
 