using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class Usingmethods
    {
        static void Methods(string[] args)
        {
            SayHi();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            SayHi1(name);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            SayHi2(name, age);


            Console.WriteLine();

            SayHi1("John");
            SayHi1("Tom");
            SayHi2("John", 70);
            SayHi2("Tom", 50);

            Console.ReadLine();
        }

        static void SayHi()
        {
            Console.WriteLine("Hello User!");
        }

        static void SayHi1(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        static void SayHi2(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age + " years old!");
        }
    }
}