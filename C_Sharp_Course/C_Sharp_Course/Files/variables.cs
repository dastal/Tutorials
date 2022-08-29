using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class Variable
    {
        static void Varibales(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But he didn't like being " + characterAge + ".");

            Console.ReadLine();
        }
    }
}