using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    // using : we are inheriting from another class
    class InheritanceChildSpecial : InheritanceChild
    {
        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Noooodles!");
        }
    }
}
