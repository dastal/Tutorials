using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingReturnStatements
    {
        static void ReturnStatements(string[] args)
        {
            int cubedNumber = cube(5);

            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;

            return result;
        }
    }
}