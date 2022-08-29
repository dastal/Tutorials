using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class ArraysIn2D
    {
        static void Arrays2D(string[] args)
        {
            int[,] numberGrid =
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
            };

            Console.WriteLine(numberGrid[0, 0]);
            Console.WriteLine(numberGrid[1, 1]);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}