using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    // now we are not able to create an instance of this class because of static
    static class StaticMethodClasses
    {
        public static void sayHi (string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
