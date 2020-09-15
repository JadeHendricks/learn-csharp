using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class InheritanceParent
    {
        static void Main(string[] args)
        {
            InheritanceChild chef = new InheritanceChild();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            InheritanceChildSpecial specialChef = new InheritanceChildSpecial();
            specialChef.MakeSalad();
            specialChef.MakePasta();
            specialChef.MakeSpecialDish();
        }
    }
}
