using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class WorkingWithStrings
    {
        static void Strings_Methods(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase);
            Console.WriteLine("Giraffe\nAcademy");

            // concatenation
            string new_phrase = "Giraffe Academy" + " is cool";
            Console.WriteLine(new_phrase);

            // see length of a string
            Console.WriteLine(new_phrase.Length);

            // convert string to all uppercase
            Console.WriteLine(new_phrase.ToUpper());

            // convert string to all lowercase
            Console.WriteLine(new_phrase.ToLower());

            // see if a string contains something
            Console.WriteLine(new_phrase.Contains("Academy"));
            Console.WriteLine(new_phrase.Contains("Academies"));

            // get the first character in your string
            Console.WriteLine(new_phrase[0]);
            Console.WriteLine(new_phrase[3]);

            // get the index of a value inside of a string
            Console.WriteLine(new_phrase.IndexOf("Academy"));
            Console.WriteLine(new_phrase.IndexOf("G"));

            // get back a peice of a string
            Console.WriteLine(new_phrase.Substring(1)); //grab from [1]
            Console.WriteLine(new_phrase.Substring(1, 6)); //grab from [1] and get 6 characters
        }
    }
}
