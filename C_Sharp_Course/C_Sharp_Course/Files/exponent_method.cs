using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class BuildingExponentMethod
    {
        static void ExponentMethod(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
            Console.WriteLine(GetPow(4, 3));
            Console.WriteLine(GetPow(5, 4));

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}