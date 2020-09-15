using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace learn_csharp
{
    class SwitchStatements
    {
        static void Main_Switch_Statements(string[] args)
        {
            Console.WriteLine(printDayOfTheWeek(0));
        }

        static string printDayOfTheWeek (int dayNum)
        {
            String dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Number";
                    break;
            }

            return dayName;
        }
    }
}
