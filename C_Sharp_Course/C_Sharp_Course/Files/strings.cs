using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class WorkingWithStrings
    {
        static void WWS(string[] args)
        {


            Console.WriteLine("C#\nCourse");
            Console.WriteLine("C#\"Course");

            string phrase = "C# Course";
            Console.WriteLine(phrase);

            Console.WriteLine("C#" + " Course");
            Console.WriteLine(phrase.Length);

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());

            Console.WriteLine(phrase.Contains("#"));
            Console.WriteLine(phrase.Contains("Courses"));

            Console.WriteLine(phrase[0]);

            Console.WriteLine(phrase.IndexOf("r"));
            Console.WriteLine(phrase.IndexOf("z"));                 // output -1 = there is no such charachter or substring inside this string

            Console.WriteLine(phrase.Substring(3));
            Console.WriteLine(phrase.Substring(3, 2));

            Console.ReadLine();
        }
    }
}