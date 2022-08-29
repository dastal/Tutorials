using C_Sharp_Course.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    class UsingConstructors
    {
        static void Constructors(string[] args)
        {
            NextGenBook book1 = new NextGenBook("Harry Potter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine();

            NextGenBook book2 = new NextGenBook("Lord of the Rings", "Tolkien", 700);

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Console.WriteLine();

            book1.pages = 500;
            Console.WriteLine(book1.pages);

            Console.WriteLine();

            NextGenBook book3 = new NextGenBook();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
