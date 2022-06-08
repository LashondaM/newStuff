using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStuff
{
    // ItalianChef class will inherit everything that the chef class can do, all of the functionality
    // This is called Inheritance
    class ItalianChef : Chef
    {
        public void MakeMeatballs()
        {
            Console.WriteLine("The Italian Chef makes meatballs");
        }

        // You can also override methods in sub classes in case you want a different outcome in a sub class than the super class
        // The override attribute tells C3 that we're going to override this method that came from the super class, Chef
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes lasagna with garlic bread");
        }
    }
}
