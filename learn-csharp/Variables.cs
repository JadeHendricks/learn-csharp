using System;

namespace learn_csharp
{
    class Variables
    {
        static void Variable_Method(string[] args)
        {
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But he didn't like being " + characterAge);
        }
    }
}
