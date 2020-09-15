using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class MovieClass
    {
        public string title;
        public string director;
        private string rating; // only code inside of the movie class can access the rating

        public MovieClass(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // we are setting the rating through the setter now
        }

        // creating getters and setters
        // value represents whatever got passed in
        public string Rating
        {
            get { return rating; }
            set { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
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
