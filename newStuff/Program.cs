using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bobby", "Comp Sci", 4.0);

            Student student2 = new Student("Linda", "Underwater Basket Weaving", 2.7);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();

        }
    }
}
