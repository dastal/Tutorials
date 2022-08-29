using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingIfStatments
    {
        static void IfStatements(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male.");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall but you are not male.");
            }
            else
            {
                Console.WriteLine("You are neither male nor tall.");
            }

            Console.WriteLine();

            bool isMale1 = true;
            bool isTall1 = false;

            if (isMale1 && isTall1)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale1 && !isTall1)
            {
                Console.WriteLine("You are a short male.");
            }
            else if (!isMale1 && isTall1)
            {
                Console.WriteLine("You are tall but you are not male.");
            }
            else
            {
                Console.WriteLine("You are neither male nor tall.");
            }

            Console.WriteLine();

            bool isMale2 = false;
            bool isTall2 = true;

            if (isMale2 && isTall2)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale2 && !isTall2)
            {
                Console.WriteLine("You are a short male.");
            }
            else if (!isMale2 && isTall2)
            {
                Console.WriteLine("You are tall but you are not male.");
            }
            else
            {
                Console.WriteLine("You are neither male nor tall.");
            }

            Console.WriteLine();

            bool isMale3 = false;
            bool isTall3 = false;

            if (isMale3 && isTall3)
            {
                Console.WriteLine("You are a tall male.");
            }
            else if (isMale3 && !isTall3)
            {
                Console.WriteLine("You are a short male.");
            }
            else if (!isMale3 && isTall3)
            {
                Console.WriteLine("You are tall but you are not male.");
            }
            else
            {
                Console.WriteLine("You are neither male nor tall.");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
