using System;

namespace newStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.SongCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.SongCount);

            Console.WriteLine(kashmir.getSongCount());

            Console.ReadLine();

        }
    }
}
