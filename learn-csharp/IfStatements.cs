using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class IfStatements
    {
        static void WORKING_WITH_IfStatements(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are not a tall male.");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not a male, but you are tall.");
            } else
            {
                Console.WriteLine("You are not male or tall.");
            }

            Console.WriteLine(GetMax(5, 6));
            Console.WriteLine(GetMaxOf3(5, 6, 10));
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            } else
            {
                result = num2;
            }
            return result;
        }

        static int GetMaxOf3(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }
            return result;
        }
    }
}
