using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class GettingUserInput
    {
        static void Getting_User_Input(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
            Console.ReadLine();
        }
    }
}
