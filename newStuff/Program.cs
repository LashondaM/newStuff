using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            /* the Chef class will be refered to as the super class in C# and the ItalianCheff class will be refered as the sub class 
             * since it's inheriting from the Chef class */

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef chef2 = new ItalianChef();
            //chef2.MakeSalad();
            //chef2.MakeMeatballs();
            chef2.MakeSpecialDish();

            Console.ReadLine();

        }
    }
}
