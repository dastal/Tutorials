using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingArrays
    {
        static void Arrays(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[2]);

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            string[] friends = new string[5];
            friends[0] = "Bruce Wayne";
            friends[1] = "Tony Stark";

            Console.ReadLine();
        }
    }
}