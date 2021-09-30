using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHi();
            SayHi("Mike", 78);
            SayHi("Luke", 34);
            SayHi("Batman", 26);
            Console.ReadLine();
        }

        // static void SayHi() { console.WriteLine("Hello Mike"); }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }
    }
}
 