using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class BetterCaluclator
    {
        static void Calculator2(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator!");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}