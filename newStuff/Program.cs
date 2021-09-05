using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            //in c# you tell it what kind of value you want the variable to store
            //int stands for integer, args number without a decimal

            string characterName = "Rick";
            int characterAge;
            characterAge = 50;
            Console.WriteLine("There was a man named " + characterName);
            Console.WriteLine(characterName + " was " + characterAge + " and silly");

            //do this to change the value of a variable halfway, or at any point in a story
            characterName = "Morty";
            Console.WriteLine("There was something wrong with him");
            Console.WriteLine(characterName + " got a big head");


            Console.ReadLine(); //press enter when you're done looking at the console when you use ReadLine

            //two forward slashes to comment out single lines in c#

            //press ctrl K + ctrl forward slash "/" to comment in and out as well, AND ctrl K + ctrl C

            /* to coment out
            multiple lines in c# */
        }
    }
}
