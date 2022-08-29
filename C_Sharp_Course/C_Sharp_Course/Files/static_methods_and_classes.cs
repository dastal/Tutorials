using C_Sharp_Course.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingStaticMethodsAndClasses
    {
        static void StaticMehtodsAndClasses(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("Dave");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}