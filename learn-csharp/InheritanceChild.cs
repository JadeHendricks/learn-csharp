using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class InheritanceChild
    {
        public void MakeChicken ()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }
}
