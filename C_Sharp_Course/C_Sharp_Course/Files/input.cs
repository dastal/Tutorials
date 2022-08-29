using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class GettingUserInput
    {
        static void UserInput(string[] args)
        {
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            Console.Write("Enter your age: ");

            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            Console.ReadLine();
        }
    }
}