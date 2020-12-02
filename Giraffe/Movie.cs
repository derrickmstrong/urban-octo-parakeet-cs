using System;
namespace Refresher
{
    public class Movie
    {
        // Attributes
        public string title;
        public string director;
        /* 
         Private modifier means that rating can only be changed insided of the Movie class thus making it secure
         It provides more control of what can be assigned to the attribute
         When you set an attribute to private then you have to create a getter and setter to access it
         We want to make sure that only valid rating are passed in to this attribute: G, PG, PG-13, R, NR
        */
        private string rating; 

        // Constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // the rating attribute (above) is now set through the Rating setter (below)
        }

        // Properties (Gettter /Setters)
        public string Rating // It's traditional to name it the same as the private attribute
        {
            get // Gets the attribute that we want to control (ie. rating)
            {
                return rating;
            }
            set // Sets a specific rule for the rating attribute; value is pre-defined and references the value of the given argument
            {
                // Check to see if the ratings argument is set to one of the following
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        // Method
        public void Introduction()
        {
            Console.WriteLine($"The movie {title} was directed by {director} and is rated {Rating}."); 
        }
    }
}
