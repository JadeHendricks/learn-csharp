using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class MovieClassParent
    {
        static void Main_MovieClassParent(string[] args)
        {
            // VALID RATINGS - G, PG, PG-13, R, NR
            MovieClass avengers = new MovieClass("The Avengers", "Joss Whedon", "PG-13");
            MovieClass shrek = new MovieClass("Shrek", "Adam Adamson", "PG");
            MovieClass doggy2 = new MovieClass("Doggy 2", "The Shepard", "DOG");

            //Console.WriteLine(avengers.rating);
            Console.WriteLine(shrek.Rating);
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(doggy2.Rating);
        }
    }
}
