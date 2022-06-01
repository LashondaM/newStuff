using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStuff
{
    internal class Book // Class was made to define what a book is by setting the data type of a book. The template for what a book is
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        // The constructor of this class
        // You can also pass paramaters into the constuctor inside of the Book class as well
        /* public Book(string name)
        {
            Console.WriteLine(name);
        } */

        // Made another constructor for another example of a better way to use constructors to make objects
        // the "a" is just short for argument in this example
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Title = aTitle;
            Author = aAuthor;
            Pages = aPages;
        }

        // You can also have more than one constructor
        /* you can also set it up to have no params so then when you make an object in the main program class, you can either set an object with params or leave them w/o 
        and the program won't mind */
        public Book() { }
    }
}
