using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class BuildingAMadLibsGame
    {
        static void MadLib(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter a plural Noun: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a plural Celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}