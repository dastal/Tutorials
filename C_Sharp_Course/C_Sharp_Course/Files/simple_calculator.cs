using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class BuildingASimpleCalculator
    {
        static void SimpleCalculator(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("The result is: " + result);

            Console.WriteLine();

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double result1 = num3 + num4;

            Console.WriteLine("The result is: " + result1);

            Console.ReadLine();
        }
    }
}
