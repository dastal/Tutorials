using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingWhileLoops
    {
        static void WhileLoops(string[] args)
        {
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine();

            int index1 = 1;

            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index1 <= 5);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}