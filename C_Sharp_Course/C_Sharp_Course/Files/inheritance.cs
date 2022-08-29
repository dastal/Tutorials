using C_Sharp_Course.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingInheritance
    {
        static void Inheritance(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            Console.WriteLine();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}