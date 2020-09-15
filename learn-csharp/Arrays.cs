using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class Arrays
    {
        static void Working_With_Arrays(string[] args)
        {
            int[] luckyNumbers = {4, 8, 16, 20, 22, 7};
            string[] friends = new string[5]; //the number tells C# how many numbers we want the array to hold

            friends[0] = "Jim";
            friends[1] = "Kelly";

            // getting a single value from an array via index
            Console.WriteLine(luckyNumbers[0]);

            // changing a single value in an array via index
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
