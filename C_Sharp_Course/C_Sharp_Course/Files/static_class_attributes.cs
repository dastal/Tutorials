using C_Sharp_Course.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingStaticClassAttributes
    {
        static void StaticClassAttributes(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(holiday.title);
            Console.WriteLine(holiday.artist);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.GetSongCount());

            Console.WriteLine();

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.title);
            Console.WriteLine(kashmir.artist);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.GetSongCount());

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
