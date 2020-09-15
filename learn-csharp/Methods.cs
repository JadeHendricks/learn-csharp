using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class Methods
    {
        static void Main(string[] args)
        {
            SayHi("Jade", 23);
            Console.WriteLine(cube(5));

            int cubedNumber = cube(7);
            Console.WriteLine(cubedNumber);
        }

        static int cube (int num)
        {
            int result = num * num * num;
            return result;
        }

        static void SayHi (string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }
    }
}
