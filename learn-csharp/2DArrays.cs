using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class _2DArrays
    {
        static void Main_2DArrays(string[] args)
        {
            int[,] numberGrid =
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            Console.WriteLine(numberGrid[1, 1]);

            // if you don't know how many elements there will be intially
            int[,] myArray = new int[2, 3]; // two rows with 3 elements inside of them
        }
    }
}
