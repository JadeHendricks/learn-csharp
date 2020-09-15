using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class WorkingWithNumbers
    {
        static void Working_With_Numbers(string[] args)
        {
            Console.WriteLine(5 + 8);
            int num = 6;
            num++;
            Console.WriteLine(num);

            // get the absolute value
            Console.WriteLine(Math.Abs(-40));

            // get the power of a number
            Console.WriteLine(Math.Pow(3, 2)); // 3 to the 2 power

            // get the sqrt of a number
            Console.WriteLine(Math.Sqrt(36));

            // get the largest number back 2 numbers max
            Console.WriteLine(Math.Max(4, 90));

            // get the lowest number back 2 numbers max
            Console.WriteLine(Math.Min(4, 90));

            // round a number 
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.7));

            // ceil a number
            Console.WriteLine(Math.Ceiling(2.2));

            // floor a number
            Console.WriteLine(Math.Floor(2.2));
        }
    }
}
