using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class WorkingWithNumbers
    {
        static void Numbers(string[] args)
        {
            int num = 6;

            Console.WriteLine(55);
            Console.WriteLine(-5.151);

            Console.WriteLine(5 + 5);
            Console.WriteLine(5 * 5);
            Console.WriteLine(6 - 5);
            Console.WriteLine(10 / 5);
            Console.WriteLine(7 % 5);
            Console.WriteLine(4 + 3 * 2);
            Console.WriteLine((4 + 3) * 2);

            Console.WriteLine(5.0 + 8.1);
            Console.WriteLine(5 + 8.1);

            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Pow(3.8, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}