using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // made objects - An instance of a class, like making an actual physical thing inside of our program after we set what type of data it will have in a class
            
            Book book1 = new Book();
            book1.Title = "Harry Potter";
            book1.Author = "JK Rowling";
            book1.Pages = 400;

            Book book2 = new Book();
            book2.Title = "The Enemy";
            book2.Author = "IDEK";
            book2.Pages = 434;

            Console.WriteLine(book2.Author);

            Console.ReadLine();

        }
    }
}
