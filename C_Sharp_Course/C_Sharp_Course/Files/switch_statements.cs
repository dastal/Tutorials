using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingSwitchStatements
    {
        static void SwitchStatements(string[] args)
        {
            Console.WriteLine(GetDay(0));
            Console.WriteLine(GetDay(4));
            Console.WriteLine(GetDay(6));
            Console.WriteLine(GetDay(7));
            Console.WriteLine(GetDay(80));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day Number.";
                    break;
            }

            return dayName;
        }
    }
}