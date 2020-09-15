using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class StaticClassAttributesParent
    {
        static void Main_StaticClassAttributesParent(string[] args)
        {
            StaticClassAttribues holiday = new StaticClassAttribues("Holiday", "Green day", 200);
            StaticClassAttribues kashmir = new StaticClassAttribues("Kashmir", "Led Zepplin", 150);

            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);

            Console.WriteLine(kashmir.getSongCount());

            // working with a static attribute
            Console.WriteLine(StaticClassAttribues.songCount);
        }
    }
}
