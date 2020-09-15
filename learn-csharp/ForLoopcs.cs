using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class ForLoopcs
    {
        static void Main_ForLoops(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
