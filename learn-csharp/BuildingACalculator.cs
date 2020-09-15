using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class BuildingACalculator
    {
        static void Building_A_Calculator(string[] args)
        {
            Console.Write("Enter a numer: ");
            double num1 = Convert.ToDouble(Console.ReadLine());            
            Console.Write("Enter another numer: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
