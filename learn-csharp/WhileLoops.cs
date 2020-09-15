using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            int index2 = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index2 <= 5);
        }
    }
}
