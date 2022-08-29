using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingForLoops
    {
        static void ForLoops(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int[] luckyNubmers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNubmers.Length; i++)
            {
                Console.WriteLine(luckyNubmers[i]);
            }

            Console.ReadLine();
        }
    }
}