using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class BuildingAnExponentMethod
    {
        static void Main_BuildingAnExponentMethod(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
