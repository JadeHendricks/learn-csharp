using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class ExceptionHandling
    {
        static void Main_ExceptionHandling(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException dbz)
            {
                Console.WriteLine(dbz.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
