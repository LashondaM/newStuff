using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newStuff
{
    internal class Movie
    {
        // The only time you'll actually need getters & setters is if you make a property private so then the program can access the class for that specific property

        /* Getters & Setters are two types of methods that we can define inside of c# classes, which will control the access that people have to the attributes of those classes.
        It makes your classes more secure and allows you to define what data is valid for specific attributes & what data is invalid */
        public string Title { get; set; }
        public string Director { get; set; }
        private string rating { get; set; } // only code that is contained in the movie class can access rating because of the private modifier attribute

        public Movie(string title, string director, string aRating)
        {
            Title = title;
            Director = director;
            Rating = aRating; // Rating will now be calling the setter we made below now that we're using the "rating" with the capital "R"
        }

        public string Rating // The method you set for getters and setters will be places within the class's curly braces here
        {
            get { return rating; }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            }
        }
    }
}
