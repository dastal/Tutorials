using C_Sharp_Course.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingGettersAndSetters
    {
        static void GettersSetters(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("The Shrek", "Adma Adamson", "PG");

            Console.WriteLine(avengers.Rating);

            shrek.Rating = "Cat";

            Console.WriteLine(shrek.Rating);

            shrek.Rating = "R";

            Console.WriteLine(shrek.Rating);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
