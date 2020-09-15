using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class MadlibsGame
    {
        static void Madlibs_Game(string[] args)
        {
            string color, pluralNoun, celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);
        }
    }
}
