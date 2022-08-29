using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingIfStatementsII
    {
        static void IfStatementsII(string[] args)
        {
            Console.WriteLine(GetMax(2, 5));
            Console.WriteLine(GetMax(5, 2));
            Console.WriteLine(GetMax(5, 5));

            Console.WriteLine();

            Console.WriteLine(GetMax1(2, 5, 10));
            Console.WriteLine(GetMax1(2, 50, 10));
            Console.WriteLine(GetMax1(20, 5, 10));
            Console.WriteLine(GetMax1(10, 5, 10));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 >= num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        static int GetMax1(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}