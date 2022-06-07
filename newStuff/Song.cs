using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStuff
{
    internal class Song
    {
        // A static attribute is an attribute that isn't unique to each one of the objects, it's about the actual class.
        // A static attribute will the the same across all of the objects pertaining to a class that the static attribute is in.
        // Basically static attributes belongs to the class, not to just a specific object like how a normal attribute would be.

        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public static int SongCount = 0;

        public Song(string title, string artist, int duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            SongCount++; // song count will get incremented every time a new Song object is created
        }
        
        // We use this if we want to access static attributes on individual objects
        public int getSongCount()
        {
            return SongCount;
        }
    }
}
