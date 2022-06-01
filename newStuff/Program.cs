using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // A constructor is a special method that you can put inside of a C# class that will get called whenever we create an object of that class

            // made objects - An instance of a class, like making an actual physical thing inside of our program after we set what type of data it will have in a class

            // new Book(); calls on the constructor method that we made in the Book class

            // You can also pass paramaters into the constuctor inside of the Book class as well

            // This is the old & more basic way to use constructors and make objects
            /*
            Book book1 = new Book("Chris");
            book1.Title = "Harry Potter";
            book1.Author = "JK Rowling";
            book1.Pages = 400;

            Book book2 = new Book("Rock");
            book2.Title = "The Enemy";
            book2.Author = "IDEK";
            book2.Pages = 434;
            */

            //Console.WriteLine(book2.Author);

            //===============================================
            // This is the better way to make objects and use constructors for classes
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            book1.Author = "Final Destination";
            Console.WriteLine(book1.Author);

            Book book2 = new Book("The Enemy", "IDEK", 434);
            Console.WriteLine(book2.Pages);

            Book book3 = new Book();

            Console.ReadLine();

        }
    }
}
